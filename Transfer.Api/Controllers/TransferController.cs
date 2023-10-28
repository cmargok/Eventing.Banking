using Microsoft.AspNetCore.Mvc;
using Transfer.Application.Interfaces;
using Transfer.Domain.Models;

namespace Transfer.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;
        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = _transferService.GetTransferLogs();

            return Ok(result);
        }

    }
}
