namespace ClinicService.Models.Requests
{
    /// <summary>
    /// Передача данных о клиенте 
    /// </summary>
    public class UpdateClientRequest
    {
        /// <summary>
        /// ID Клиента в БД
        /// </summary>
        public int ClientId { get; set; }

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
        public string Patronymic { get; set; }

        /// <summary>
        /// Дата рождения клиента
        /// </summary>
        public DateTime Birthday { get; set; }
    }
}
