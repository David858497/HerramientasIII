using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feriados.Infraestructura.Persistencia.Contexto;
using Feriados.Core.Repositorios;
using Feriados.Dominio.Entidades;

namespace Feriados.Repositorios
{
    internal class FestivoRepositorio: IFestivoRepositorio
    {
        private readonly FeriadosContext context;
         
        public FestivoRepositorio (FeriadosContext context) {
            this.context = context;

        }

        public Task<Festivo> ObtenerTodos(DateOnly IdTipo)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Festivo>> Buscar(int Dia, int mes)
        {
            throw new NotImplementedException();
        }
    }
}
