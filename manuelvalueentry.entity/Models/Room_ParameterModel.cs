using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Entity.Models
{
    public class Room_ParameterModel
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Room")]
        public int Room_Id { get; set; }
        public virtual RoomModel Room { get; set; }
        [ForeignKey("Parameter")]
        public int Parameter_Id { get; set; }
        public virtual ParameterModel Parameter { get; set; }
        public bool Closed { get; set; }
        public override string ToString()
        {
            return this.Room + "-" + this.Parameter;
        }
    }
}
