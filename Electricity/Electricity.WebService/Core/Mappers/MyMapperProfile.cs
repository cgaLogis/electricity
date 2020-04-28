using AutoMapper;
using Electricity.DAL.Entity;
using Electricity.DTO.Dtos;
using Electricity.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricity.WebService.Core.Mappers
{
    /// <summary>
    /// маппинг
    /// </summary>
    public class MyMapperProfile : Profile
    {
        /// <summary>
        /// маппинг
        /// </summary>
        public MyMapperProfile()
        {
            CreateMap<Organization, OrganizationDto>().ReverseMap();
            CreateMap<ChildOrganization, ChildOrganizationDto>().ReverseMap();
            CreateMap<ConsumptionObject, ConsumptionObjectDto>().ReverseMap();
            CreateMap<ElectricityPoint, ElectricityPointDto>().ReverseMap();
            CreateMap<DeliveryPoint, DeliveryPointDto>().ReverseMap();
            CreateMap<ElectricityMeter, ElectricityMeterDto>().ReverseMap();
            CreateMap<ElectricityTransformator, ElectricityTransformatorDto>().ReverseMap();
            CreateMap<VoltageTransformator, VoltageTransformatorDto>().ReverseMap();
            CreateMap<DeliveryPointMeter, DeliveryPointMeterDto>().ReverseMap();


            // api models => dto

            CreateMap<ElectricityPointModel, ElectricityPointDto>().ReverseMap();
            CreateMap<ElectricityTransformatorModel, ElectricityTransformatorDto>().ReverseMap();
            CreateMap<ElectricityMeterModel, ElectricityMeterDto>().ReverseMap();
            CreateMap<VoltageTransformatorModel, VoltageTransformatorDto>().ReverseMap();
        }
    }
}
