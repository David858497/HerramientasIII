using Feriados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feriados.Core.Repositorios
{
    public class IFestivoRepositorio
    {
        Task<Festivo> ObtenerTodos(DateOnly IdTipo);//Traigo todos los festivos por tipo
        Task<IEnumerable<Festivo>> Buscar(int Dia, int mes);//Busco por una fecha en especifico
    }
}
