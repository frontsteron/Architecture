namespace ClinicService.Models
{
    /// <summary>
    /// Класс описывает животное клиента
    /// </summary>
    public class Pet
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
