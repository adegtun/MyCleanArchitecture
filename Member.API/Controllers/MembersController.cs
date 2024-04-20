using Member.Application;
using Microsoft.AspNetCore.Mvc;

namespace Member.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService _memberService;
        private readonly ILogger<MembersController> _logger;
        public MembersController(ILogger<MembersController> logger, IMemberService memberService)
        {
            _logger = logger;
            _memberService = memberService;
        }

        [HttpGet]
        public ActionResult<IList<Domain.Member>> Get() {
            return Ok(_memberService.GetAllMembers());
        }
    }
}
