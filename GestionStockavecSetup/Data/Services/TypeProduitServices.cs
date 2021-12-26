using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Services
{
    class TypeProduitServices
    {
        private readonly MyDbContext _context;
        public TypeProduitServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddTypeProduit(Typesproduit typeproduit)
        {
            if (typeproduit == null)
            {
                throw new ArgumentNullException(nameof(typeproduit));
            }
            _context.Add(typeproduit);
            _context.SaveChanges();
        }

        public IEnumerable<Typesproduit> GetAllTypeProduit()
        {
            return _context.Typesproduits.ToList();
        }

        public void DeleteTypeProduit(Typesproduit typeproduit)
        {
            if (typeproduit == null)
            {
                throw new ArgumentNullException(nameof(typeproduit));
            }
            _context.Remove(typeproduit);
            _context.SaveChanges();
        }

        public Typesproduit GetTypeProduitById(int id)
        {
            return _context.Typesproduits.FirstOrDefault(p => p.IdTypeProduit == id);
        }

        public void UpdateTypeProduit(Typesproduit obj)
        {
            _context.SaveChanges();
        }
    }
}
