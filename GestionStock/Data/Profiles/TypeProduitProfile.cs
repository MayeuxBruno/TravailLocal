using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionStock.Data.Dtos.TypeProduitDTO;

namespace GestionStock.Data.Profiles
{
    class TypeProduitProfile:Profile
    {
        public TypeProduitProfile()
        {
            CreateMap<TypeProduit, TypeProduitDTOIn>();
            CreateMap<TypeProduitDTOIn, TypeProduit>();
            CreateMap<TypeProduit, TypeProduitDTOOut>();
            CreateMap<TypeProduitDTOOut, TypeProduit>();
        }
    }
}
