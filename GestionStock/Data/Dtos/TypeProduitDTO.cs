using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionStock.Data.Dtos.CategorieDTO;

namespace GestionStock.Data.Dtos
{
    class TypeProduitDTO
    {
        public partial class TypeProduitDTOIn
        {
            public TypeProduitDTOIn()
            {
            }
            public string LibelleTypeProduit { get; set; }
        }

        public partial class TypeProduitDTOOut
        {
            public TypeProduitDTOOut()
            {
                Categories = new HashSet<CategorieDTOOut>();
            }
            public string LibelleTypeProduit { get; set; }
            public virtual ICollection<CategorieDTOOut> Categories { get; set; }

        }
    }
}
