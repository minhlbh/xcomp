using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Xcomp.Cloud.Core.Extentions;
using Xcomp.Cloud.Data;
using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Common;
using Xcomp.Cloud.Share.Domain;
using Xcomp.Cloud.Share.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Xcomp.Cloud.Api.Controllers.V1_0
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class BedController : ControllerBase
    {
        private readonly IBedRepository _bedRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly IDeviceRepository _deviceRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public BedController(IUnitOfWork uow,
            IMapper mapper,
            IBedRepository bedRepository,
            IUserRepository userRepository,
            IRoomRepository roomRepository,
            IDeviceRepository deviceRepository,
            IPatientRepository patientRepository)
        {
            _uow = uow;
            _mapper = mapper;
            _bedRepository = bedRepository;
            _userRepository = userRepository;
            _roomRepository = roomRepository;
            _deviceRepository = deviceRepository;
            _patientRepository = patientRepository;
        }

        [HttpGet("list")]
        public async Task<ExcuteResult> GetAsync()
        {
            var beds = await _bedRepository.GetAllAsync();
            if (beds != null)
            {
                return new ExcuteResult(Result: _mapper.Map<IList<BedModel>>(beds));
            }
            return new NotFoundRecordResult();
        }

        [HttpGet("list-in-room")]
        public async Task<ExcuteResult> GetByRoomAsync(string roomId)
        {
            var beds = await _bedRepository.GetAllAsync(c => c.RoomParent.Id == roomId);
            if (beds != null)
            {
                var bedIds = beds.Select(c => c.Id).ToList();
                var existPatients = await _patientRepository.GetAllAsync(c => c.Bed.RoomParent.Id == roomId && bedIds.Contains(c.Bed.Id));
                var existDevices = await _deviceRepository.GetAllAsync(c => c.Bed.RoomParent.Id == roomId && bedIds.Contains(c.Bed.Id));
                var bedResult = _mapper.Map<IList<BedModel>>(beds);
                foreach (var item in bedResult)
                {
                    var existPatient = existPatients.FirstOrDefault(c => c.Bed.Id == item.Id);
                    if (existPatient != null)
                    {
                        item.Patient = _mapper.Map<PatientModel>(existPatient);
                    }
                    var existDevice = existDevices.FirstOrDefault(c => c.Bed.Id == item.Id);
                    if (existDevice != null)
                    {
                        item.Device = _mapper.Map<DeviceModel>(existDevice);
                    }
                }
                return new ExcuteResult(Result: bedResult);
            }
            return new NotFoundRecordResult();
        }

        [HttpGet("page")]
        public async Task<ExcuteResult> GetAsync(string search = "", string parentId = null, int pageIndex = 0, int pageSize = 25)
        {
            search ??= "";
            DataResult dataResult = new DataResult();
            if (pageIndex > 0 && pageSize > 0 && pageSize <= 100)
            {
                var result = await _bedRepository.GetListPagingAsync(c => c.Name.Contains(search) && (parentId == null || c.RoomParent.Id == parentId), c => c.CreatedAt, pageSize, pageIndex);
                dataResult.Data = _mapper.Map<IList<BedModel>>(result.Item1);
                dataResult.Total = result.Item2;
                return new ExcuteResult(Result: dataResult);
            }
            dataResult.Data = Enumerable.Empty<object>();
            return new ExcuteResult(Result: dataResult);
        }

        [HttpGet("detail")]
        public async Task<ExcuteResult> GetAsync(string id)
        {
            if (id.IsNotNullOrEmpty())
            {
                var existBed = await _bedRepository.GetByIdAsync(id);
                if (existBed != null)
                {
                    var resultBed = _mapper.Map<BedModel>(existBed);
                    var existPatient = await _patientRepository.GetAsync(c => c.Bed.Id == resultBed.Id);
                    if (existPatient != null)
                    {
                        resultBed.Patient = _mapper.Map<PatientModel>(existPatient);
                    }
                    var existDevice = await _deviceRepository.GetAsync(c => c.Bed.Id == resultBed.Id);
                    if (existDevice != null)
                    {
                        resultBed.Device = _mapper.Map<DeviceModel>(existDevice);
                    }
                    return new ExcuteResult(Result: resultBed);
                }
            }

            return new NotFoundRecordResult();
        }

        [HttpPost("add")]
        public async Task<ExcuteResult> PostAsync([FromBody] CreateBedModel input)
        {
            var existBed = await _bedRepository.GetAsync(c => c.RoomParent.Id == input.RoomParentId && c.Name == input.Name);
            if (existBed != null)
            {
                return new ExistRecordResult("Bed is exist");
            }
            var existRoom = await _roomRepository.GetAsync(c => c.Id == input.RoomParentId);
            if (existRoom == null)
            {
                return new NotFoundRecordResult("Room has not exist");
            }
            var bed = _mapper.Map<Bed>(input);
            bed.CreatedAt = DateTime.Now;
            bed.UpdatedAt = DateTime.Now;
            bed.CreatedBy = "";
            bed.UpdatedBy = "";
            bed.RoomParent = new Room
            {
                Id = existRoom.Id,
                Name = existRoom.Name,
                FacultyParent = existRoom.FacultyParent
            };

            _bedRepository.Add(bed);
            var result = await _uow.CommitAsync();
            if (result)
            {
                return new ExcuteResult();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        [HttpPost("update")]
        public async Task<ExcuteResult> UpdateAsync([FromBody] UpdateBedModel input)
        {
            var existBed = await _bedRepository.GetByIdAsync(input.Id);
            if (existBed == null)
            {
                return new NotFoundRecordResult();
            }
            _mapper.Map(input, existBed);
            existBed.UpdatedAt = DateTime.Now;
            existBed.UpdatedBy = "";
            _bedRepository.Update(input.Id, existBed);
            var result = await _uow.CommitAsync();
            if (result)
            {
                var updatedBed = await _bedRepository.GetByIdAsync(input.Id);
                return new ExcuteResult(true, "", _mapper.Map<BedModel>(updatedBed));
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        [HttpPost("delete")]
        public async Task<ExcuteResult> DeleteAsync([FromBody] ModelId input)
        {
            var existBed = await _bedRepository.GetByIdAsync(input.Id);
            if (existBed == null)
            {
                return new NotFoundRecordResult("Bed has not exist");
            }

            _bedRepository.DeleteOne(existBed.Id);
            var result = await _uow.CommitAsync();
            if (result)
            {
                return new ExcuteResult();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

    }
}
