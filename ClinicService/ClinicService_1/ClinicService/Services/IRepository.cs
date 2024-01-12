using ClinicService.Models;

namespace ClinicService.Services
{
    /// <summary>
    /// Обобщенный интерфейс репозиторий для работы с БД по записям
    /// </summary>
    /// <typeparam name="T">Класс записи (клиент, животное, запись на консультацию)</typeparam>
    /// <typeparam name="TId">Идентификатор записи (клиент, животное, запись на консультацию)</typeparam>
    public interface IRepository<T, TId>
    {
        /// <summary>
        /// Создание записи (клиент, животное, запись на консультацию)
        /// </summary>
        /// <param name="item">Переданные данные для записи</param>
        /// <returns>Результат создания записи в БД</returns>
        int Create(T item);

        /// <summary>
        /// Редактирование записи (клиент, животное, запись на консультацию)
        /// </summary>
        /// <param name="item">Переданные данные для изменения записи</param>
        /// <returns>Результат изменение записи в БД</returns>
        int Update(T item);

        /// <summary>
        /// Удаление записи по ID
        /// </summary>
        /// <param name="id">Идентификатор записи в БД (клиент, животное, запись на консультацию)</param>
        /// <returns>Результат удаления записи из БД</returns>
        int Delete(TId id);

        /// <summary>
        /// Получение записи из БД по ID (клиент, животное, запись на консультацию)
        /// </summary>
        /// <param name="id">Идентификатор записи в БД (клиент, животное, запись на консультацию)</param>
        /// <returns>Информацию из БД по запрошенной записи</returns>
        T GetById(TId id);

        /// <summary>
        /// Получение всех записей в программе
        /// </summary>
        /// <returns>Всех записей по справочнику класса записи</returns>
        List<T> GetAll();
    }
}
