using AutoMapper;
using GestionStock.Data.Models;
using GestionStock.Data.Profiles;
using GestionStock.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionStock.Data.Dtos.TypeProduitDTO;

namespace GestionStock.Data.Dtos
{
    class TypeProduitController : ControllerBase
    {
        private readonly TypeProduitServices _service;
        private readonly IMapper _mapper;

        public TypeProduitController(MyDbContext _context)
        {
            _service = new TypeProduitServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<TypeProduitProfile>();
            });
            _mapper = config.CreateMapper();
        }

        public ActionResult<IEnumerable<TypeProduitDTOOut>> GetAllArticles()
        {
            IEnumerable<Typesproduit> listeTypeproduit = _service.GetAllTypeProduit();
            return Ok(_mapper.Map<IEnumerable<TypeProduitDTOOut>>(listeTypeproduit));
        }

        public ActionResult<Categorie> GetTypeProduitById(int id)
        {
            Typesproduit commandItem = _service.GetTypeProduitById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Typesproduit>(commandItem));
            }
            return NotFound();
        }
        public ActionResult<Typesproduit> CreateTypeProduit(Typesproduit obj)
        {
            Typesproduit newTypeProduit = _mapper.Map<Typesproduit>(obj);
            _service.AddTypeProduit(newTypeProduit);
            return CreatedAtRoute(nameof(GetTypeProduitById), new { Id = newTypeProduit.IdTypeProduit }, newTypeProduit);
        }
        public ActionResult UpdateTypeProduit(int id, Typesproduit obj)
        {
            Typesproduit objFromRepo = _service.GetTypeProduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateTypeProduit(objFromRepo);
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

        public ActionResult DeleteTypeProduit(int id)
        {
            Typesproduit obj = _service.GetTypeProduitById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteTypeProduit(obj);
            return NoContent();
        }

    }
}
