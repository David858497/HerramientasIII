using Feriados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feriados.Core.Servicios
{
    internal class ITipoFeriadoServicio
    {
        Task<Tipo> ObtenerTodos(DateOnly IdTipo);//Traigo todos los festivos por tipo
        Task<IEnumerable<Tipo>> Buscar(int Dia, int mes);//Busco por una fecha en especifico
    }
}
