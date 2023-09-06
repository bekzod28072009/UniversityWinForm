using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer.Domein.Entity
{
    public class Student
    {
        public long Id { get; set; }    

        public string Name { get; set; }

        public string Teacher { get; set; }

        public string Course { get; set; }

        public string Faculty { get; set; }
    }
}
