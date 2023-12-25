using ClinicService.Models;

namespace ClinicService.Services
{
    /// <summary>
    /// Конкретный тип интерфейса репозитория для работы со справочником животных в БД
    /// </summary>
    public interface IPetRepository : IRepository<Pet, int>
    {

    }
}
