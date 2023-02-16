using Manuelvalueentry.Core.Models;
using Manuelvalueentry.Entity.Models;

namespace Manuelvalueentry.Core.Mapper
{
    public class ParameterMapper
    {
        public static Parameter MapToActiveParameter(ParameterModel _parameterModel)
        {
            Parameter _parameter = new Parameter();
            _parameter.Id = _parameterModel.Id;
            _parameter.Name = _parameterModel.Name;
            _parameter.Type = _parameterModel.Type;
            _parameter.Unit = _parameterModel.Unit;
            return _parameter;
        }
        public static ParameterModel MapToEntityParameter(Parameter _parameter)
        {
           ParameterModel _parameterModel = new ParameterModel();
            _parameterModel.Id = _parameter.Id;
            _parameterModel.Name = _parameter.Name;
            _parameterModel.Type = _parameter.Type;
            _parameterModel.Unit = _parameter.Unit;
            return _parameterModel;
        }
    }
}
