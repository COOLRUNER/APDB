using Microsoft.AspNetCore.Authorization;
using WebApplication3.Models;
namespace WebApplication3.Repositories;

public interface IAnimalRepository
{
    IEnumerable<Animals> GetAnimalsOrderedBy(string orderBy);
    Animals AddAnimal(Animals animal);
    int EditAnimal(int id, Animals animal);
    int DeleteAnimal(int id);
}