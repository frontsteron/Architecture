using ClinicService.Models;

namespace ClinicService.Services
{
    /// <summary>
    /// Конкретный тип интерфейса репозитория для работы со справочником записи на консультацию в БД
    /// </summary>
    public interface IConsultationRepository : IRepository<Consultation, int>
    {

    }
}
