namespace Manuelvalueentry.Core.Models
{
    public class Parameter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Type { get; set; }//1=>int,2=double,3=string,4=boolean bu view için
        public override string ToString()
        {
            return this.Name;
        }
    }
}
