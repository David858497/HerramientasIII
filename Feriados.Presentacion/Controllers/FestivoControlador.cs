using Feriados.Core.Servicios;
using Feriados.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Feriados.Presentacion.Controllers
{
    [ApiController]
    [Route("festivos")]
    public class FestivoControlador : ControllerBase
    {
        private readonly IFestivoServicio servicio;
        public FestivoControlador(IFestivoServicio servicio)
        {
            this.servicio = servicio;
        }

        [HttpGet("verificar/{Dia}/{mes}")]
        public async Task<IEnumerable<Festivo>> Buscar(int Dia, int mes)
        {
            return await servicio.Buscar(Dia, mes);
        }
    }
}
