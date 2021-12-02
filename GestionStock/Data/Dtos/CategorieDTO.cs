using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionStock.Data.Dtos.ArticleDTO;

namespace GestionStock.Data.Dtos
{
    class CategorieDTO
    {
        public partial class CategorieDTOIn
        {
            public CategorieDTOIn()
            {
            }
            public string LibelleCategorie { get; set; }
            public int IdTypeProduit { get; set; }
        }

        public partial class CategorieDTOOut
        {
            public string LibelleCategorie { get; set; }
        }
    }
}
