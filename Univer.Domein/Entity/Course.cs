using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer.Domein.Entity
{
    public class Course
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long Students { get; set; }
    }
}
