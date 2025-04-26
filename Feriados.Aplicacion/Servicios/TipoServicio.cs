using Feriados.Core.Repositorios;
using Feriados.Core.Servicios;
using Feriados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feriados.Aplicacion.Servicios
{
    public class TipoServicio: ITipoFeriadoServicio
    {
        private readonly ITipoFeriadoRepositorio repositorio;
        public TipoServicio(ITipoFeriadoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task<Tipo> ObtenerTodos(DateOnly festivo)
        {
            return await repositorio.ObtenerTodos(festivo);
        }
        public async Task<IEnumerable<Tipo>> Buscar(int Dia, int mes)
        {
            return await repositorio.Buscar(Dia, mes);
        }
    }
}
