using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationParse
{
    public class AktifYazarModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CorporateInformation { get; set; }
        public bool IsEmployee { get; set; }
        public string EMail { get; set; }
        public bool IsActive { get; set; }
        public string LastAutoUpdateTime { get; set; }
    }
}


