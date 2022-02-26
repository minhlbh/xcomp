using AutoMapper;
using Xcomp.Cloud.Share.Domain;
using Xcomp.Cloud.Share.Models;
using Xcomp.Cloud.Share.Models.EditModel;
using Xcomp.Cloud.Share.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xcomp.Cloud.Share.Map
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            
            CreateMap<HospitalModel, HospitalEditModel>().ReverseMap();
            CreateMap<HospitalEditModel, CreateHospitalModel>().ReverseMap();
            CreateMap<HospitalEditModel, UpdateHospitalModel>().ReverseMap();
            CreateMap<HospitalModel, HospitalViewModel>().ReverseMap();

            CreateMap<FacultyModel, FacultyEditModel>().ReverseMap();
            CreateMap<FacultyEditModel, CreateFacultyModel>().ReverseMap();
            CreateMap<FacultyEditModel, UpdateFacultyModel>().ReverseMap();
            CreateMap<FacultyModel, FacultyViewModel>().ReverseMap();

            CreateMap<RoomModel, RoomEditModel>().ReverseMap();
            CreateMap<RoomEditModel, CreateRoomModel>().ReverseMap();
            CreateMap<RoomEditModel, UpdateRoomModel>().ReverseMap();
            CreateMap<RoomModel, RoomViewModel>().ReverseMap();

            CreateMap<BedModel, BedEditModel>().ReverseMap();
            CreateMap<BedEditModel, CreateBedModel>().ReverseMap();
            CreateMap<BedEditModel, UpdateBedModel>().ReverseMap();
            CreateMap<BedModel, BedViewModel>().ReverseMap();

            CreateMap<UserModel, UserEditModel>().ReverseMap();
            CreateMap<UserEditModel, CreateUserModel>().ReverseMap();
            CreateMap<UserEditModel, UpdateUserModel>().ReverseMap();
            CreateMap<UserModel, UserViewModel>().ReverseMap();

            CreateMap<DutyGroupModel, DutyGroupEditModel>()
                .ForMember(dest => dest.AdminId, opt => opt.MapFrom(src => src.AdminUser.Id))
                .ReverseMap();
            CreateMap<DutyGroupEditModel, CreateDutyGroupModel>().ReverseMap();
            CreateMap<DutyGroupEditModel, UpdateDutyGroupModel>().ReverseMap();
            CreateMap<DutyGroupModel, DutyGroupViewModel>().ReverseMap();

            CreateMap<ScheduleTimeModel, ScheduleTimeEditModel>().ReverseMap();
            CreateMap<ScheduleTimeEditModel, CreateScheduleTimeModel>().ReverseMap();
            CreateMap<ScheduleTimeEditModel, UpdateScheduleTimeModel>().ReverseMap();
            CreateMap<ScheduleTimeModel, ScheduleTimeViewModel>().ReverseMap();
        }
    }
}
