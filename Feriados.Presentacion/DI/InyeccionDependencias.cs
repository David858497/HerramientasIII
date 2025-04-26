using Feriados.Core.Repositorios;
using Feriados.Core.Servicios;
using Feriados.Repositorios;
using Feriados.Aplicacion.Servicios;
using Feriados.Infraestructura.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Feriados.Presentacion.DI
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AgregarDependencias(this IServiceCollection servicios,
                                                            IConfiguration configuracion)
        {
            servicios.AddDbContext<FeriadosContext>(opciones =>
            {
                opciones.UseSqlServer(configuracion.GetConnectionString("Feriados"));
            });

            //agregar repositorios
            servicios.AddTransient<IFestivoRepositorio, FestivoRepositorio>();
            servicios.AddTransient<ITipoFeriadoRepositorio, TipoFestivoRepositorio>();

            //agregar servicios
            servicios.AddTransient<IFestivoServicio, FestivoServicio>();
            servicios.AddTransient<ITipoFeriadoServicio, TipoServicio>();

            return servicios;
        }
    }
}
