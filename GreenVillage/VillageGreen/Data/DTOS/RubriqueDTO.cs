using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageGreen.Data.DTOS
{
    class RubriqueDTOIN
    {
        public RubriqueDTOIN()
        {
        }
        public string LibelleRubrique { get; set; }
        public int? IdRubriqueMere { get; set; }
    }

    class RubriqueDTOOut
    {
        public RubriqueDTOOut()
        {
        }
        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public int? IdRubriqueMere { get; set; }
        public string LibelleRubriqueMere { get; set; }
    }
}
