using AutoMapper;
using Electricity.DAL.Core.Repositories;
using Electricity.DAL.Entity;
using Electricity.DTO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity.CORE.Services
{
    public class DataService : IDataService
    {
        private IMapper _mapper;

        private IRepository<ElectricityPoint> _electricityPointRepository;

        private IRepository<DeliveryPointMeter> _deliveryPointMetersRepository;


        public DataService( IMapper mapper, IRepository<ElectricityPoint> electricityPointRepository, IRepository<DeliveryPointMeter> deliveryPointMetersRepository )
        {
            _mapper = mapper;

            _electricityPointRepository = electricityPointRepository;

            _deliveryPointMetersRepository = deliveryPointMetersRepository;
        }

        public async Task<ElectricityPointDto> AddElectricityPoint(ElectricityPointDto model)
        {
            var entity = _mapper.Map<ElectricityPoint>( model );

            var result = _electricityPointRepository.Add( entity );

            var retItem = _mapper.Map<ElectricityPointDto>( result );

            return retItem;
        }

        public async Task<List<DeliveryPointMeterDto>> GetAllDeliveryPointMeters2018()
        {
            var listItems = _deliveryPointMetersRepository.GetAll().ToList();

            var listDtos = listItems.Select( e => _mapper.Map<DeliveryPointMeterDto>( e ) ).ToList();
            //var filter = query.Where(e=>e.)

            return listDtos;
        }

        public async Task<List<ElectricityMeterDto>> GetAllElectricityMeter( int consumptionObjectId )
        {
            var items = _electricityPointRepository.GetAll();

            var filterTest = items.ToList();

            var filter = items
                .Where( e => e.ObjectId == consumptionObjectId )
                .Select( e => _mapper.Map<ElectricityMeterDto>(e.ElectMeter))
                .ToList();

            return filter;
        }

        /// <summary>
        /// По указанному объекту потребления выбрать все трансформаторы тока с закончившимся сроком поверке.
        /// </summary>
        /// <param name="consumptionObjectId"></param>
        /// <returns></returns>
        public async Task<List<ElectricityTransformatorDto>> GetAllElectricityTransformators( int consumptionObjectId )
        {
            var items = _electricityPointRepository.GetAll();

            var filterTest = items.ToList();

            var filter = items
                .Where( e => e.ObjectId == consumptionObjectId )
                .Select( e => _mapper.Map<ElectricityTransformatorDto>( e.ElectricityTransformator ) )
                .ToList();

            return filter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consumptionObjectId"></param>
        /// <returns></returns>
        public async Task<List<VoltageTransformatorDto>> GetAllVoltageTransformators( int consumptionObjectId )
        {
            var items = _electricityPointRepository.GetAll();

            var filterTest = items.ToList();

            var filter = items
                .Where( e => e.ObjectId == consumptionObjectId )
                .Select( e => _mapper.Map<VoltageTransformatorDto>( e.VoltageTransformator ) )
                .ToList();

            return filter;
        }
    }
}
