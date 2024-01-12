using ClinicService.Models.Requests;
using ClinicService.Models;
using ClinicService.Services;
using ClinicService.Services.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {

        private readonly IPetRepository _petRepository;

        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpPost("create")]
        [SwaggerOperation(OperationId = "PetCreate")]
        public ActionResult<int> Create([FromBody] CreatePetRequest createRequest)
        {
            int res = _petRepository.Create(new Pet
            {
                ClientId = createRequest.ClientId,
                Name = createRequest.Name,
                Birthday = createRequest.Birthday,
            });
            return Ok(res);
        }

        [HttpPut("update")]
        [SwaggerOperation(OperationId = "PetUpdate")]
        public ActionResult<int> Update([FromBody] UpdatePetRequest updateRequest)
        {
            int res = _petRepository.Update(new Pet
            {
                PetId = updateRequest.PetId,
                ClientId = updateRequest.ClientId,
                Name = updateRequest.Name,
                Birthday = updateRequest.Birthday,
            });
            return Ok(res);
        }

        [HttpDelete("delete")]
        [SwaggerOperation(OperationId = "PetDelete")]
        public ActionResult<int> Delete([FromQuery] int petId)
        {
            int res = _petRepository.Delete(petId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "PetGetAll")]
        public ActionResult<List<Pet>> GetAll()
        {
            return Ok(_petRepository.GetAll());
        }


        [HttpGet("get/{petId}")]
        [SwaggerOperation(OperationId = "PetGetById")]
        public ActionResult<Pet> GetById([FromRoute] int petId)
        {
            return Ok(_petRepository.GetById(petId));
        }
    }
}
