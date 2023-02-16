using Manuelvalueentry.Core.Models;
using Manuelvalueentry.Entity.Models;

namespace Manuelvalueentry.Core.Mapper
{
    public class UserMapper
    {
        public static User MapToActiveUser(UserModel _userModel)
        {
            User _user = new User();
            _user.Id = _userModel.Id;
            _user.Name = _userModel.Name;
            _user.Surname = _userModel.Surname;
            _user.UserName = _userModel.UserName;
            _user.Mail = _userModel.Mail;
            _user.MemberShipDate = _userModel.MemberShipDate;
            _user.Role_Id = _userModel.Role_Id;
            _user.Password = _userModel.Password;
            return _user;
        }
        public static UserModel MapToEntityUser(User _user)
        {
            UserModel _userModel = new UserModel();
            _userModel.Id = _user.Id;
            _userModel.UserName = _user.UserName;
            _userModel.Name = _user.Name;
            _userModel.Surname = _user.Surname;
            _userModel.MemberShipDate = _user.MemberShipDate;
            _userModel.Role_Id = _user.Role_Id;
            _userModel.Password = _user.Password;
            return _userModel;
        }
    }
}
