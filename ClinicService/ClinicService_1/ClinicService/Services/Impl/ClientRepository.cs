using ClinicService.Models;
using Microsoft.Data.Sqlite;

namespace ClinicService.Services.Impl
{
    public class ClientRepository : IClientRepository
    {
        private const string connectionString = "Data Source = clinic.db;";


        public int Create(Client item)
        {
            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            using SqliteCommand command =
               new SqliteCommand("INSERT INTO clients(Document, SurName, FirstName, Patronymic, Birthday) VALUES(@Document, @SurName, @FirstName, @Patronymic, @Birthday)", connection);
            command.Parameters.AddWithValue("@Document", item.Document);
            command.Parameters.AddWithValue("@SurName", item.SurName);
            command.Parameters.AddWithValue("@FirstName", item.FirstName);
            command.Parameters.AddWithValue("@Patronymic", item.Patronymic);
            command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
            command.Prepare();
            return command.ExecuteNonQuery();
        }

        public int Update(Client item)
        {
            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            using SqliteCommand command =
                new SqliteCommand("UPDATE clients SET Document = @Document, FirstName = @FirstName, SurName = @SurName, Patronymic = @Patronymic, Birthday = @Birthday WHERE ClientId=@ClientId", connection);
            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@Document", item.Document);
            command.Parameters.AddWithValue("@SurName", item.SurName);
            command.Parameters.AddWithValue("@FirstName", item.FirstName);
            command.Parameters.AddWithValue("@Patronymic", item.Patronymic);
            command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
            command.Prepare();
            return command.ExecuteNonQuery();
        }

        public IList<Client> GetAll()
        {
            List<Client> list = new List<Client>();
            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            using SqliteCommand command =
                new SqliteCommand("SELECT * FROM clients", connection);
            command.Prepare();
            using SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Client client = new Client();
                client.ClientId = reader.GetInt32(0);
                client.Document = reader.GetString(1);
                client.SurName = reader.GetString(2);
                client.FirstName = reader.GetString(3);
                client.Patronymic = reader.GetString(4);
                client.Birthday = new DateTime(reader.GetInt64(5));
                list.Add(client);
            }
            return list;
        }

        public Client GetById(int id)
        {
            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            using SqliteCommand command =
                new SqliteCommand("SELECT * FROM clients WHERE ClientId=@ClientId", connection);
            command.Parameters.AddWithValue("@ClientId", id);
            command.Prepare();
            SqliteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Client client = new Client();
                client.ClientId = reader.GetInt32(0);
                client.Document = reader.GetString(1);
                client.SurName = reader.GetString(2);
                client.FirstName = reader.GetString(3);
                client.Patronymic = reader.GetString(4);
                client.Birthday = new DateTime(reader.GetInt64(5));
                return client;
            }
            return null;
        }

        public int Delete(int id)
        {
            using SqliteConnection connection = new SqliteConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            using SqliteCommand command =
                new SqliteCommand("DELETE FROM clients WHERE ClientId=@ClientId", connection);
            command.Parameters.AddWithValue("@ClientId", id);
            command.Prepare();
            return command.ExecuteNonQuery();
        }
        
    }
}
