namespace ClinicService.Models.Requests
{
    /// <summary>
    /// Передоваемые параметры о записи на консультацию для создания записи в БД
    /// </summary>
    public class CreateConsultationRequest
    {
        /// <summary>
        /// Клиент записанный на консультацию
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Животное с которым клиент записался на консультацию
        /// </summary>
        public int PetId { get; set; }

        /// <summary>
        /// Дата на которую записан клиент на консультацию
        /// </summary>
        public DateTime ConsultationDate { get; set; }

        /// <summary>
        /// Причина обращения на консультацию
        /// </summary>
        public string Description { get; set; }
    }
}
