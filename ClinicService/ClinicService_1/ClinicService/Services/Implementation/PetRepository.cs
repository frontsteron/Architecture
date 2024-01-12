using ClinicService.Models;
using Microsoft.Data.Sqlite;

namespace ClinicService.Services.Implementation
{
    /// <summary>
    /// Реализация работа с базами данных по справочнику животные
    /// </summary>
    public class PetRepository : IPetRepository
    {
        private const string connectionString = "Data Source = clinic.db;"; //Строка соединения с БД

        public int Create(Pet item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на добавление данных
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO pets(ClientId, Name, Birthday) VALUES(@ClientId, @Name, @Birthday)";
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
                // подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                return command.ExecuteNonQuery();
            }
        }

        public int Update(Pet item)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на добавление данных
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE pets SET ClientId = @ClientId, Name = @Name, Birthday = @Birthday WHERE PetId=@PetId";
                command.Parameters.AddWithValue("@PetId", item.PetId);
                command.Parameters.AddWithValue("@ClientId", item.ClientId);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
                // подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                return command.ExecuteNonQuery();
            }
        }

        public int Delete(int id)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                // Прописываем в команду SQL-запрос на добавление данных
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM pets WHERE PetId=@PetId";
                command.Parameters.AddWithValue("@PetId", id);
                // подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                return command.ExecuteNonQuery();
            }
        }

        public List<Pet> GetAll()
        {
            List<Pet> list = new List<Pet>();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                // Прописываем в команду SQL-запрос
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM pets";
                // Выполнение команды
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pet pet = new Pet
                    {
                        PetId = reader.GetInt32(0),
                        ClientId = reader.GetInt32(1),
                        Name = reader.GetString(2),
                        Birthday = new DateTime(reader.GetInt64(3))
                    };

                    list.Add(pet);
                }
            }
            return list;
        }

        public Pet GetById(int id)
        {
            List<Pet> list = new List<Pet>();
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                // Прописываем в команду SQL-запрос
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM pets WHERE PetId=@PetId";
                command.Parameters.AddWithValue("@PetId", id);
                // подготовка команды к выполнению
                command.Prepare();
                // Выполнение команды
                SqliteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Pet pet = new Pet
                    {
                        PetId = reader.GetInt32(0),
                        ClientId = reader.GetInt32(1),
                        Name = reader.GetString(2),
                        Birthday = new DateTime(reader.GetInt64(3))
                    };
                    return pet;
                }
            }
            return null;
        }

    }
}