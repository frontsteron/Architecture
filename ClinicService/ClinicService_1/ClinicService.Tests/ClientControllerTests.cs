using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicService.Tests
{
    public class ClientControllerTests
    {
        private ClientController _clientController;
        private Mock<IClientRepository> _mockClientRepository;

        public ClientControllerTests()
        {
            _mockClientRepository = new Mock<IClientRepository>();
            _clientController = new ClientController(_mockClientRepository.Object);
        }


        [Fact]
        public void GetAllClientsTest()
        {
            // [1.1] Подготовка данных для тестирования

            //[1.2]

            List<Client> clientsList = new List<Client>();
            clientsList.Add(new Client());
            clientsList.Add(new Client());
            clientsList.Add(new Client());

            _mockClientRepository.Setup(repository =>
                repository.GetAll()
            ).Returns(clientsList);

            //[2] Исполнение тестируемого метода


            var operationResult = _clientController.GetAll();

            //[3] Подготовка эталонного результата, проверка результата
            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<List<Client>>(((OkObjectResult)operationResult.Result).Value);
            _mockClientRepository.Verify(repository => repository.GetAll(), Times.AtLeastOnce());

        }

        // Подготовка для тестирования создания
        public static readonly object[][] CorrectCreateClientData =
        {
            new object []{ new DateTime(1985, 5, 20), "1234 123456", "Иванов", "Иван", "Иванович"},
            new object []{ new DateTime(1987, 2, 18), "1234 321456", "Иванов", "Иван", "Иванович"},
            new object []{ new DateTime(1975, 2, 22), "1234 123654", "Иванов", "Иван", "Иванович"},
        };

        [Theory]
        [MemberData(nameof(CorrectCreateClientData))]
        public void CreateclientsListTest(DateTime birthday, string document, string surName, string firstName, string patronymic)
        {
            _mockClientRepository.Setup(repository => repository.Create(It.IsNotNull<Client>())).Returns(1).Verifiable();


            var operationResult = _clientController.Create(new CreateClientRequest
            {
                Birthday = birthday,
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mockClientRepository.Verify(repository => repository.Create(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }

        // Подготовка для тестирования обновления
        public static readonly object[][] CorrectUpdateClientData =
       {
            new object []{ new DateTime(1985, 5, 20), "1234 123456", "Иванов", "Иван", "Иванович", 1},
            new object []{ new DateTime(1987, 2, 18), "1234 321456", "Иванов", "Иван", "Иванович", 2},
            new object []{ new DateTime(1975, 2, 22), "1234 123654", "Иванов", "Иван", "Иванович", 3},
        };

        [Theory]
        [MemberData(nameof(CorrectUpdateClientData))]
        public void UpdateclientsListTest(DateTime birthday, string document, string surName, string firstName, string patronymic, int id)
        {
            _mockClientRepository.Setup(repository => repository.Update(It.IsNotNull<Client>())).Returns(1).Verifiable();


            var operationResult = _clientController.Update(new UpdateClientRequest
            {
                ClientId = id,
                Birthday = birthday,
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mockClientRepository.Verify(repository => repository.Update(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }

        [Theory]
        [InlineData(1)]
        public void DeleteclientsListTest(int id)
        {
            _mockClientRepository.Setup(repository => repository.Delete(id)).Returns(id);

            var operationResult = _clientController.Delete(id);

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mockClientRepository.Verify(repository => repository.Delete(id), Times.AtLeastOnce());
        }
    }
}
