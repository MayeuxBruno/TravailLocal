using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.DTOS
{
    class AdresseDTO
    {
        public AdresseDTO()
        {
        }
        public int IdAdresse { get; set; }
        public string EmailAdresse { get; set; }
        public string TelMobile { get; set; }
        public string TelFixe { get; set; }
        public string AdressePostale { get; set; }
        public string Province { get; set; }
        public string ComplementAdresse { get; set; }
        public int IdVille { get; set; }
    }
}
