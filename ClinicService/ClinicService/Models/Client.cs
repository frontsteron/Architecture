namespace ClinicService.Models
{
    /// <summary>
    /// Класс описания клиента
    /// </summary>
    public class Client
    {
        /// <summary>
        /// ID клиента в БД
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Документ клиента (например паспорт)
        /// </summary>
        public string Document { get; set; }

        /// <summary>
        /// Имя клиента в БД
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// Фамилия клиента в БД
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество клиента в БД
        /// </summary>
        public string? Patronymic { get; set; }

        /// <summary>
        /// Дата рождения клиента в БД
        /// </summary>
        public DateTime Birthday { get; set; }
    }
}
