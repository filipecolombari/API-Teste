using API_Teste.Data;
using Microsoft.AspNetCore.Mvc;

namespace API_Teste.Controllers
{
    public class BaseController : ControllerBase
    {
        protected readonly APITesteContext _context;

        public BaseController(APITesteContext context)
        {
            _context = context;
        }
    }
}
