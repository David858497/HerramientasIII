using Feriados.Dominio.Entidades;

namespace Feriados.Core.Repositorios
{
    public interface ITipoFeriadoRepositorio
    {
        Task<Tipo> ObtenerTodos(DateOnly IdTipo);//Traigo todos los festivos por tipo
        Task<IEnumerable<Tipo>> Buscar(int Dia, int mes);//Busco por una fecha en especifico
    }
}
