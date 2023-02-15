using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Entity.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        public string Mail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [ForeignKey("Role")]
        public int Role_Id { get; set; }
        public RoleModel Role { get; set; }//1-Admin,2-mühendis,3-user
        public DateTime MemberShipDate { get; set; }
        public bool Closed { get; set; }
        public override string ToString()
        {
            return this.Name + " " + this.Surname;
        }
    }
}
