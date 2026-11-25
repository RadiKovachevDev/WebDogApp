
using System.Collections.Generic;
using System.Linq;

using WebDogApp.Core.Contracts;
using WebDogApp.Infrastructure.Data;
using WebDogApp.Infrastructure.Data.Domain;

namespace WebDogApp.Core.Services
{
    public class BreedService : IBreedService
    {
        private readonly ApplicationDbContext _context;

        public BreedService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Breed GetBreedById(int breedId)
        {
            return _context.Breeds.Find(breedId);
        }

        public List<Breed> GetBreeds()
        {
            List<Breed> breeds = _context.Breeds.ToList();

            return breeds;
        }

        public bool Create(string name) { _context.Breeds.Add(new Breed { Name=name }); return _context.SaveChanges()>0; }
        public bool Update(int id,string name) { var breed=_context.Breeds.Find(id); if(breed==null)return false; breed.Name=name; return _context.SaveChanges()>0; }
        public bool Delete(int id) { var breed=_context.Breeds.Find(id); if(breed==null || _context.Dogs.Any(d=>d.BreedId==id))return false; _context.Breeds.Remove(breed); return _context.SaveChanges()>0; }

        public List<Dog> GetDogsByBreed(int breedId)
        {
            return _context.Dogs
                .Where(x => x.BreedId == breedId)
                .ToList();
        }
    }
}
