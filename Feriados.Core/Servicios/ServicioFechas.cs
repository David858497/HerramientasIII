using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feriados.Core.Servicios
{
    public interface ServicioFechas
    {
        public static DateTime obtenerInicioSemanaSanta(int año)
        {
            int a = año % 19;
            int b = año % 4;
            int c = año % 7;
            int d = (19 * a + 24) % 30;
            int dias = d + (2 * b + 4 * c + 6 * d + 5) % 7;
            int mes = 3;
            int dia = 15 + dias;

            if (dia > 31)
            {
                mes = mes + 1;
                dia = dia - 31;
                return new DateTime(año, mes, dia);
            }

            return new DateTime(año, mes, dia);
        }
        public static DateTime AgregarDias(DateTime fecha, int dias)
        {
            return fecha.AddDays(dias);
        }
        public static DateTime SiguienteLunes(DateTime fecha)
        {
            DayOfWeek diaSemana = fecha.DayOfWeek;
            int diasLunes = (DayOfWeek.Monday - diaSemana + 7) % 7;
            return AgregarDias(fecha, diasLunes);
        }
    }
}
