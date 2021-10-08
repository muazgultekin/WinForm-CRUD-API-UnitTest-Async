using System.Collections.Generic;

namespace Employees.Models
{
    public class Root
    {
        public int code { get; set; }
        public Meta meta { get; set; }
        public List<Personel> data { get; set; }
    }


    public class SetRoot
    {
        public int code { get; set; }
        public object meta { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
    }
}
