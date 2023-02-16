using Manuelvalueentry.Core.Models;
using Manuelvalueentry.Entity.Models;

namespace Manuelvalueentry.Core.Mapper
{
    public class Parameter_HistoryMapper
    {
        public static Parameter_History MapToActiveParameter_History(Parameter_HistoryModel _parameter_HistoryModel)
        {
            Parameter_History _parameter_History = new Parameter_History();
            _parameter_History.Id = _parameter_HistoryModel.Id;
            _parameter_History.SaveDate = _parameter_HistoryModel.SaveDate;
            _parameter_History.Room_Parameter_Id = _parameter_HistoryModel.Room_Parameter_Id;
            _parameter_History.Value = _parameter_HistoryModel.Value;
            _parameter_History.Comment = _parameter_HistoryModel.Comment;
            return _parameter_History;
        }
        public static Parameter_HistoryModel MapToEntityParameter_History(Parameter_History _parameter_History)
        {
            Parameter_HistoryModel _parameter_HistoryModel = new Parameter_HistoryModel();
            _parameter_HistoryModel.Id = _parameter_History.Id;
            _parameter_HistoryModel.SaveDate = _parameter_History.SaveDate;
            _parameter_HistoryModel.Room_Parameter_Id = _parameter_History.Room_Parameter_Id;
            _parameter_HistoryModel.Value = _parameter_History.Value;
            _parameter_HistoryModel.Comment = _parameter_History.Comment;
            return _parameter_HistoryModel;
        }
    }
}
