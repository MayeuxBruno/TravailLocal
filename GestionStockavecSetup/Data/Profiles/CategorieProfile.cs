using AutoMapper;
using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionStock.Data.Dtos.CategorieDTO;

namespace GestionStock.Data.Profiles
{
    class CategorieProfile:Profile
    {
        public CategorieProfile()
        {
            CreateMap<Categorie, CategorieDTOIn>();
            CreateMap<CategorieDTOIn, Categorie>();
            CreateMap<Categorie, CategorieDTOOut>();
            CreateMap<CategorieDTOOut, Categorie>();
        }
    }
}
