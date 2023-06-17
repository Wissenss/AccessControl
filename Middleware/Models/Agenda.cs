using AccessControl.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Models
{
    public class Agenda
    {
        public Dictionary<int, SemanaTipo> Semanas;

        public Agenda()
        {

        }

        public SemanaTipo GetSemanaPorFecha(DateTime fecha)
        {
            try
            {
                CultureInfo culture = new CultureInfo("es-Mx");
                Calendar calendar = culture.Calendar;

                int index = calendar.GetWeekOfYear(fecha, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
                SemanaTipo semana = this.Semanas[index];

                return semana;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
