namespace ClinicService.Models.Requests
{
    /// <summary>
    /// Передача данных о животном 
    /// </summary>
    public class UpdatePetRequest
    {
        /// <summary>
        /// ID животного в БД
        /// </summary>
        public int PetId { get; set; }

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
