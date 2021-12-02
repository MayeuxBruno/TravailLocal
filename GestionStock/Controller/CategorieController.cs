using AutoMapper;
using GestionStock.Data;
using GestionStock.Data.Models;
using GestionStock.Data.Profiles;
using GestionStock.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionStock.Data.Dtos.CategorieDTO;

namespace GestionStock.Controller
{
    class CategorieController : ControllerBase
    {
        private readonly CategorieServices _service;
        private readonly IMapper _mapper;

        public CategorieController(MyDbContext _context)
        {
            _service = new CategorieServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CategorieProfile>();
            });
            _mapper = config.CreateMapper();
        }

        public ActionResult<IEnumerable<CategorieDTOOut>> GetAllArticles()
        {
            IEnumerable<Categorie> listeCategories = _service.GetAllCategories();
            return Ok(_mapper.Map<IEnumerable<CategorieDTOOut>>(listeCategories));
        }

        public ActionResult<Categorie> GetCategorieById(int id)
        {
            Categorie commandItem = _service.GetCategorieById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Categorie>(commandItem));
            }
            return NotFound();
        }
        public ActionResult<Categorie> CreateCategorie(Categorie obj)
        {
            Categorie newCategorie = _mapper.Map<Categorie>(obj);
            _service.AddCategorie(newCategorie);
            return CreatedAtRoute(nameof(GetCategorieById), new { Id = newCategorie.IdCategorie }, newCategorie);
        }
        public ActionResult UpdateCategorie(int id, Article obj)
        {
            Categorie objFromRepo = _service.GetCategorieById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCategorie(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]

        /* 
         public ActionResult PartialCourseUpdate(int id, JsonPatchDocument<Article> patchDoc)
         {
             Article objFromRepo = _service.GetArticleById(id);
             if (objFromRepo == null)
             {
                 return NotFound();
             }
             Article objToPatch = _mapper.Map<Article>(objFromRepo);
             patchDoc.ApplyTo(objToPatch, ModelState);
             if (!TryValidateModel(objToPatch))
             {
                 return ValidationProblem(ModelState);
             }
             _mapper.Map(objToPatch, objFromRepo);
             _service.UpdateArticle(objFromRepo);
             return NoContent();
         }
        */

        public ActionResult DeleteCategorie(int id)
        {
            Categorie obj = _service.GetCategorieById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCategorie(obj);
            return NoContent();
        }

    }
}
