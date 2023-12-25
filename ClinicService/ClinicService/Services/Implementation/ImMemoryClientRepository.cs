using ClinicService.Models;

namespace ClinicService.Services.Implementation
{

    /// <summary>
    /// Реализация хранения данных записей в памяти приложения
    /// </summary>
    public class ImMemoryClientRepository : IClientRepository
    {
        public int Create(Client item)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Client item)
        {
            throw new NotImplementedException();
        }
    }
}
