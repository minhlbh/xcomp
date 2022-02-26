using AutoMapper;
using Xcomp.Cloud.Share.Domain;
using Xcomp.Cloud.Share.Models;
using Xcomp.Cloud.Share.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xcomp.Web.Cloud.Share.Map
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserModel>()
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.HospitalRoles.FirstOrDefault(c => c.Used == "Allowed")))
                .ReverseMap();
            CreateMap<User, InvitedUserByFacultyModel>()
                .ForMember(dest => dest.HospitalRole, opt => opt.MapFrom(src => src.HospitalRoles.FirstOrDefault(c => c.FacultyActive == "Pendding")))
                .ReverseMap();
            CreateMap<User, CreateUserModel>().ReverseMap();
            CreateMap<User, CreateCloudUserModel>().ReverseMap();
            CreateMap<User, UpdateUserModel>().ReverseMap();
            CreateMap<User, DutyGroupUser>().ReverseMap();
            CreateMap<User, Doctor>().ReverseMap();

            CreateMap<Hospital, HospitalModel>().ReverseMap();
            CreateMap<Hospital, CreateHospitalModel>().ReverseMap();
            CreateMap<Hospital, UpdateHospitalModel>().ReverseMap();
            

            CreateMap<Faculty, FacultyModel>().ReverseMap();
            CreateMap<Faculty, BasicFacultyModel>().ReverseMap();
            CreateMap<Faculty, CreateFacultyModel>().ReverseMap();
            CreateMap<Faculty, UpdateFacultyModel>().ReverseMap();

            CreateMap<Device, DeviceModel>().ReverseMap();
            CreateMap<Device, CreateDeviceModel>().ReverseMap();
            CreateMap<Device, UpdateDeviceModel>().ReverseMap();
            CreateMap<Device, CreateHomeDeviceModel>().ReverseMap();
            CreateMap<Device, DeviceFollowDetail>().ReverseMap();

            CreateMap<App, AppModel>().ReverseMap();
            CreateMap<App, CreateAppModel>().ReverseMap();
            CreateMap<App, UpdateAppModel>().ReverseMap();

            CreateMap<DeviceOfUser, DeviceOfUserModel>().ReverseMap();
            CreateMap<DeviceOfUser, CreateDeviceOfUserModel>().ReverseMap();
            CreateMap<DeviceOfUser, UpdateDeviceOfUserModel>().ReverseMap();

            CreateMap<Room, RoomModel>().ReverseMap();
            CreateMap<Room, CreateRoomModel>().ReverseMap();
            CreateMap<Room, UpdateRoomModel>().ReverseMap();
            CreateMap<Room, DutyGroupRoom>().ReverseMap();

            CreateMap<Bed, BedModel>().ReverseMap();
            CreateMap<Bed, CreateBedModel>().ReverseMap();
            CreateMap<Bed, UpdateBedModel>().ReverseMap();
            CreateMap<Bed, BedInDeviceModel>().ReverseMap();

            CreateMap<DutyGroup, DutyGroupModel>().ReverseMap();
            CreateMap<DutyGroup, CreateDutyGroupModel>().ReverseMap();
            CreateMap<DutyGroup, UpdateDutyGroupModel>().ReverseMap();
            CreateMap<ScheduleTime, ScheduleTimeModel>().ReverseMap();
            CreateMap<ScheduleTime, UpdateScheduleTimeModel>().ReverseMap();
            CreateMap<ScheduleTime, ScheduleTimeWithDutyInfoModel>().ReverseMap();

            CreateMap<Patient, PatientModel>()
                .ForMember(dest => dest.Room, opt => opt.MapFrom(src => src.Bed.RoomParent.Name))
                .ReverseMap();
            CreateMap<Patient, CreatePatientModel>().ReverseMap();
            CreateMap<Patient, UpdatePatientModel>().ReverseMap();
            CreateMap<Patient, PatientFullInfoModel>().ReverseMap();
            CreateMap<Patient, DutyGroupPatientModel>()
                .ForMember(dest => dest.Room, opt => opt.MapFrom(src => src.Bed.RoomParent.Name))
                .ReverseMap();

            CreateMap<PatientFollow, PatientFollowModel>().ReverseMap();
            CreateMap<Doctor, DoctorModel>().ReverseMap();
            CreateMap<PatientRelative, PatientRelativeModel>().ReverseMap();
            CreateMap<PatientRelative, CreatePatientRelativeModel>().ReverseMap();
            CreateMap<PatientRelative, UpdatePatientRelativeModel>().ReverseMap();
            CreateMap<HomePatientFollow, HomePatientFollowModel>().ReverseMap();
            CreateMap<DeviceFollow, DeviceFollowModel>().ReverseMap();

            CreateMap<HomePatient, HomePatientModel>().ReverseMap();
            CreateMap<HomePatient, CreateHomePatientModel>().ReverseMap();
            CreateMap<HomePatient, UpdateHomePatientModel>().ReverseMap();
            CreateMap<HomePatient, HomePatientFullInfoModel>().ReverseMap();

            CreateMap<RoleRequest, RoleRequestModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.HospitalRole.Name))
                .ForMember(dest => dest.Note, opt => opt.MapFrom(src => src.HospitalRole.Note))
                .ForMember(dest => dest.Faculty, opt => opt.MapFrom(src => src.HospitalRole.Faculty))
                .ReverseMap();
            CreateMap<HospitalRole, HospitalRoleModel>().ReverseMap();

        }
    }
}
