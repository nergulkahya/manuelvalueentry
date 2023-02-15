using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Entity.Models
{
    public class ParameterModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Type { get; set; }//1=>int,2=double,3=string,4=boolean bu view için
        public bool Closed { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
