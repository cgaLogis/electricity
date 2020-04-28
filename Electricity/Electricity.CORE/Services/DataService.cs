using AutoMapper;
using Electricity.DAL.Core;
using Electricity.DAL.Core.Repositories;
using Electricity.DAL.Entity;
using Electricity.DTO.Dtos;
using Microsoft.EntityFrameworkCore;
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

        private IRepository<ElectricityTransformator> _electricityTransformatorRepository;

        private IRepository<VoltageTransformator> _voltageTransformatorRepository;

        private IRepository<ElectricityMeter> _electricityMeterRepository;
        
        private DataContext _context;

        public DataService( IMapper mapper, 
                            IRepository<ElectricityPoint> electricityPointRepository, 
                            IRepository<DeliveryPointMeter> deliveryPointMetersRepository , 
                            IRepository<ElectricityTransformator> electricityTransformatorRepository,
                            IRepository<VoltageTransformator> voltageTransformatorRepository,
                            IRepository<ElectricityMeter> electricityMeterRepository,
                            DataContext context
            )
        {
            _mapper = mapper;

            _electricityPointRepository = electricityPointRepository;

            _deliveryPointMetersRepository = deliveryPointMetersRepository;

            _electricityTransformatorRepository = electricityTransformatorRepository;

            _electricityMeterRepository = electricityMeterRepository;

            _voltageTransformatorRepository = voltageTransformatorRepository;

            _context = context;
        }

        public async Task<ElectricityPointDto> AddElectricityPoint(ElectricityPointDto model)
        {
            try
            {
                var entity = _mapper.Map<ElectricityPoint>( model );

                _context.ElectricityPoints.Add( entity );

                _context.SaveChanges();

                var item = _context.ElectricityPoints.Find( entity.Id );
                var retItem = _mapper.Map<ElectricityPointDto>( item );

                return retItem;
            }catch (Exception ex )
            {
                throw ex;
            }
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
            var items = _electricityPointRepository.GetAll()
                .Include(e=>e.VoltageTransformator)
                .Include(e=>e.ElectricityMeter)
                .Include(e=>e.ElectricityTransformator);

            var filterTest = items.ToList();

            var filterData = items
                .Where( e => e.ObjectId == consumptionObjectId )
                .Select( e => e.ElectricityMeter)
                .ToList();

            var result = filterData.Select( e => _mapper.Map<ElectricityMeterDto>( e ) ).ToList();

            return result;
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
