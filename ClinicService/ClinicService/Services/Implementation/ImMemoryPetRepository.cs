using ClinicService.Models;

namespace ClinicService.Services.Implementation
{

    /// <summary>
    /// Реализация хранения данных записей в памяти приложения
    /// </summary>
    public class ImMemoryPetRepository : IPetRepository
    {
        public int Create(Pet item)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pet> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pet GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Pet item)
        {
            throw new NotImplementedException();
        }
    }
}
