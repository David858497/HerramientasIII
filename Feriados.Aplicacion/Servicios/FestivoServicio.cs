using Feriados.Core.Servicios;
using Feriados.Core.Repositorios;
using Feriados.Dominio.Entidades;

namespace Feriados.Aplicacion.Servicios
{
    public class FestivoServicio: IFestivoServicio
    {
        private readonly IFestivoRepositorio repositorio;
        public FestivoServicio(IFestivoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task<Festivo> ObtenerTodos(DateOnly festivo)
        {
            return await repositorio.ObtenerTodos(festivo);
        }
        public async Task<IEnumerable<Festivo>> Buscar(int Dia, int mes)
        {
            return await repositorio.Buscar(Dia, mes);
        }
    }
}
