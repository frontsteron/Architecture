namespace ClinicService.Models.Requests
{
    /// <summary>
    /// Передоваемые параметры о животном для создания записи в БД
    /// </summary>
    public class CreatePetRequest
    {
        /// <summary>
        /// Клиент к которому принадлежит животное
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Кличка животного
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата рождения животного
        /// </summary>
        public DateTime Birthday { get; set; }
    }
}
