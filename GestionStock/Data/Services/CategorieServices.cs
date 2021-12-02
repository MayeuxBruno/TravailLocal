using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Services
{
    class CategorieServices
    {
        private readonly MyDbContext _context;
        public CategorieServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddCategorie(Categorie categorie)
        {
            if (categorie == null)
            {
                throw new ArgumentNullException(nameof(categorie));
            }
            _context.Add(categorie);
            _context.SaveChanges();
        }

        public IEnumerable<Categorie> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public void DeleteCategorie(Categorie categorie)
        {
            if (categorie == null)
            {
                throw new ArgumentNullException(nameof(categorie));
            }
            _context.Remove(categorie);
            _context.SaveChanges();
        }

        public Categorie GetCategorieById(int id)
        {
            return _context.Categories.FirstOrDefault(p => p.IdCategorie == id);
        }

        public void UpdateCategorie(Categorie obj)
        {
            _context.SaveChanges();
        }
    }
}
