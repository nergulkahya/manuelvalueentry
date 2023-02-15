using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Entity.Models
{
    public class Parameter_HistoryModel
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
        public DateTime SaveDate { get; set; }
        public string Comment { get; set; }
        [ForeignKey("Room_Parameter")]
        public int Room_Parameter_Id { get; set; }
        public virtual Room_ParameterModel Room_Parameter { get; set; }
        public bool Closed { get; set; }
        public override string ToString()
        {
            return this.Room_Parameter.Room + "-" + this.Value;
        }
    }
}
