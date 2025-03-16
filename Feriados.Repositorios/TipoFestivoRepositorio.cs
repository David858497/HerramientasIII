using Feriados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feriados.Core.Reposiorios;
using Feriados.Infraestructura.Persistencia;

namespace Feriados.Repositorios
{
    internal class TipoFestivoRepositorio: ITipoFeriadoRepositorio
    {
        private readonly FeriadosContext context;
        public TipoFestivoRepositorio(FeriadosContext context)
        {
            this.context = context;
        }
        public Task<Tipo> ObtenerTodos(DateOnly IdTipo)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Tipo>> Buscar(int Dia, int mes)
        {
            throw new NotSupportedException();
        }
    }
}
