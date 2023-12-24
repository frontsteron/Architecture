
using ClinicService.Services;
using ClinicService.Services.Impl;
using Microsoft.Data.Sqlite;

namespace ClinicService
{
    public class Program
    {
        /// <summary>
        /// https://sqlitestudio.pl/
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //ConfigureSqlLiteConnection();
            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IClientRepository, ClientRepository>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        private static void ConfigureSqlLiteConnection()
        {
            string connectionString = "Data Source = clinic.db;";
            SqliteConnection sqliteConnection = new SqliteConnection(connectionString);
            sqliteConnection.Open();
            PrepareSchema(sqliteConnection);
            sqliteConnection.Close();   
        }

        private static void PrepareSchema(SqliteConnection sqliteConnection)
        {
            SqliteCommand sqliteCommand = new SqliteCommand();
            sqliteCommand.Connection = sqliteConnection;

            sqliteCommand.CommandText = "DROP TABLE IF EXISTS consultations";
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand.CommandText = "DROP TABLE IF EXISTS pets";
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand.CommandText = "DROP TABLE IF EXISTS clients";
            sqliteCommand.ExecuteNonQuery();

            sqliteCommand.CommandText =
                    @"CREATE TABLE Clients(ClientId INTEGER PRIMARY KEY,
                    Document TEXT,
                    SurName TEXT,
                    FirstName TEXT,
                    Patronymic TEXT,
                    Birthday INTEGER)";
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand.CommandText =
                    @"CREATE TABLE Pets(PetId INTEGER PRIMARY KEY,
                    ClientId INTEGER,
                    Name TEXT,
                    Birthday INTEGER)";
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand.CommandText =
                @"CREATE TABLE Consultations(ConsultationId INTEGER PRIMARY KEY,
                    ClientId INTEGER,
                    PetId INTEGER,
                    ConsultationDate INTEGER,
                    Description TEXT)";
            sqliteCommand.ExecuteNonQuery();
            sqliteCommand.Dispose();

        }

    }
}