using Manuelvalueentry.Core.Models;
using Manuelvalueentry.Entity.Models;

namespace Manuelvalueentry.Core.Mapper
{
    public class FactoryMapper
    {
        public static Factory MapToActiveFactory(FactoryModel _factoryModel)
        {
            Factory _factory = new Factory();
            _factory.Id = _factoryModel.Id;
            _factory.Name = _factoryModel.Name;
            return _factory;
        }
        public static FactoryModel MapToEntityFactory(Factory _factory)
        {
            FactoryModel _factoryModel = new FactoryModel();
            _factoryModel.Id = _factory.Id;
            _factoryModel.Name = _factory.Name;
            return _factoryModel;
        }
    }
}
