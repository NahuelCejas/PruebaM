using Aplication.Interfaces;
using CRMSystem.Data;
using Microsoft.AspNetCore.Mvc;


namespace CRMSystem.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class InteractionTypesController : ControllerBase
    {
        private readonly IInteractionTypeService _service;

        public InteractionTypesController(IInteractionTypeService service)
        {
            _service = service;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllInteractions();
            return new JsonResult(result);
        }
    }
}
