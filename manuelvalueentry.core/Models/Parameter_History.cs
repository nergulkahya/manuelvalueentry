using System;

namespace Manuelvalueentry.Core.Models
{
    public class Parameter_History
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public DateTime SaveDate { get; set; }
        public string Comment { get; set; }
        public int Room_Parameter_Id { get; set; }
    }
}
