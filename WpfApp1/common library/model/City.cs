using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common_library.model
{
    class City
    {
        [Table("CITIES")]
        public class City : AbstractBase
        {
            [Column("CITY_NAME")]

            public string Name { get; set; }
        }
    }
}
