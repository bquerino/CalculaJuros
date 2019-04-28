using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculaJuros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet()]
        public ActionResult<string> Get(int valorinicial, int meses)
        {
            double juros = 0.01;
            double valorFinal = valorinicial * Math.Pow((1 + juros), meses);
            return valorFinal.ToString("0.00");
        }
    }
}
