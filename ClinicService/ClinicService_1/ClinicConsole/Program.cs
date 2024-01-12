using ClinicService.Data;

namespace ClinicConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите на любую клавишу для загрузки данных ...");
            Console.ReadKey();

            ClinicServiceClient clinicClient = new ClinicServiceClient("http://localhost:5036/", new HttpClient());

            List<Client> clients = clinicClient.ClientGetAllAsync().Result.ToList();

            foreach (Client client in clients)
            {
                Console.WriteLine("Фамилия: " + client.SurName);
                Console.WriteLine("Имя: " + client.FirstName);
                Console.WriteLine("Отчество: " + client.Patronymic);
                Console.WriteLine("Дата рождения: " + client.Birthday.DateTime);
                Console.WriteLine("Документ: " + client.Document);
                Console.WriteLine();
            }

            Console.WriteLine("Нажмите на любую клавишу для завершения работы приложения ...");
            Console.ReadKey();
        }
    }
}
