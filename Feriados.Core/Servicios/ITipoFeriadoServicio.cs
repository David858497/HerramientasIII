using Feriados.Dominio.Entidades;

namespace Feriados.Core.Servicios
{
    public interface ITipoFeriadoServicio
    {
        Task<Tipo> ObtenerTodos(DateOnly IdTipo);//Traigo todos los festivos por tipo
        Task<IEnumerable<Tipo>> Buscar(int Dia, int mes);//Busco por una fecha en especifico
    }
}
