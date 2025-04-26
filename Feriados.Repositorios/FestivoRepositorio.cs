using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Feriados.Dominio.Entidades;
using Feriados.Core.Repositorios;
using Feriados.Core.Servicios;
using Feriados.Infraestructura.Persistencia.Contexto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Feriados.Repositorios
{
    public class FestivoRepositorio : IFestivoRepositorio
    {
        private readonly FeriadosContext context;
        public FestivoRepositorio(FeriadosContext context)
        {
            this.context = context;
        }

        /*public async Task<Festivo> ObtenerTodos(DateOnly festivo)
        {
            //return await context.ObtenerTodos(festivo);
        }
        public async Task<IEnumerable<Festivo>> Buscar(int Dia, int mes)
        {
            return await context.Festivos
            .Where(item => (Dia == 0 && item.Nombre.Contains(mes))
            || (Dia == 1 && item.Año.ToString() == mes)
                || (Dia == 2 && item.PaisOrganizador.Nombre.Contains(mes)))
                .Include(e => e.PaisOrganizador)   // Incluir el objeto Pais Organizador
                .ToArrayAsync();
        }*/
        public Task<string> VerificarFestivo(int año, int mes, int dia)
        {
            try
            {
                DateTime fecha;
                if (!DateTime.TryParseExact($"{año}/{mes}/{dia}", "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
                {
                    return Task.FromResult("Fecha no válida.");
                }

                // Obtener festivos calculados
                List<DateTime> festivos = ObtenerFestivos(año);

                // Verificar si la fecha es festivo
                if (festivos.Contains(fecha))
                {
                    return Task.FromResult($"La fecha {fecha:dd/MM/yyyy} es un festivo.");
                }
                else
                {
                    return Task.FromResult($"La fecha {fecha:dd/MM/yyyy} NO es un festivo.");
                }
            }
            catch (Exception ex)
            {
                return Task.FromResult($"Error en la verificación: {ex.Message}");
            }
        }

        private List<DateTime> ObtenerFestivos(int año)
        {
            List<DateTime> festivos = new List<DateTime>
            {
                new DateTime(año, 1, 1), // Año Nuevo
                ServicioFechas.SiguienteLunes(new DateTime(año, 1, 6)), // Reyes Magos
                ServicioFechas.obtenerInicioSemanaSanta(año), // Domingo de Ramos
                ServicioFechas.AgregarDias(ServicioFechas.obtenerInicioSemanaSanta(año), 7), // Domingo de Pascua
                ServicioFechas.SiguienteLunes(ServicioFechas.AgregarDias(ServicioFechas.obtenerInicioSemanaSanta(año), 61)), // Cuerpo de Cristo
                ServicioFechas.AgregarDias(ServicioFechas.obtenerInicioSemanaSanta(año), -2), // Viernes Santo
                ServicioFechas.AgregarDias(ServicioFechas.obtenerInicioSemanaSanta(año), -3), // Jueves Santo
                ServicioFechas.SiguienteLunes(ServicioFechas.AgregarDias(ServicioFechas.obtenerInicioSemanaSanta(año), 68)), // Sagrado Corazón
            };

            return festivos;
        }
    }
}