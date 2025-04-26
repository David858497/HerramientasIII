using Feriados.Dominio.Entidades;

namespace Feriados.Core.Servicios
{
    public interface IFestivoServicio
    {
        Task<Festivo> ObtenerTodos(DateOnly IdTipo);//Traigo todos los festivos por tipo
        Task<IEnumerable<Festivo>> Buscar(int Dia, int mes);//Busco por una fecha en especifico
    }
}
