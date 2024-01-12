namespace ClinicService.Models.Requests
{
    /// <summary>
    /// Передоваемые параметры о клиенте для создания записи в БД
    /// </summary>
    public class CreateClientRequest
    {
        /// <summary>
        /// Документ клиента
        /// </summary>
        public string Document { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество клиента
        /// </summary>
        public string? Patronymic { get; set; }

        /// <summary>
        /// Дата рождения клиента
        /// </summary>
        public DateTime Birthday { get; set; }
    }
}
