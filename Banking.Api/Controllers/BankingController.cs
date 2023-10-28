using Banking.Application.interfaces;
using Banking.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet(Name = "GetAccounts")]
        public async Task<IActionResult> Get()
        {
            var result = _accountService.GetAccounts();

           return Ok(result);
        }


        [HttpPost(Name = "Transfer")]
        public async Task<IActionResult> Post(AccountTransfer accountTransfer)
        {

            _accountService.Transfer(accountTransfer);

            return Ok();
        }


    }

   
}
