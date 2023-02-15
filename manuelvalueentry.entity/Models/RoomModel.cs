using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Entity.Models
{
    public class RoomModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Factory")]
        public int Factory_Id { get; set; }
        public FactoryModel Factory { get; set; }
        public bool Closed { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
