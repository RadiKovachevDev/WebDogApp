
using System.Collections.Generic;

using WebDogApp.Infrastructure.Data.Domain;

namespace WebDogApp.Core.Contracts
{
    public interface IBreedService
    {
        List<Breed> GetBreeds();

        Breed GetBreedById(int breedId);

        List<Dog> GetDogsByBreed(int breedId);
        bool Create(string name);
        bool Update(int id, string name);
        bool Delete(int id);
    }
}
