using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _247
{
    class Horario
    {
        private int APERTURA = 0, CIERRE = 1;
        DateTime now = DateTime.Now;
        private string entrada;

        public Horario(string horario) 
        {
            entrada = horario;
        }

        /// <summary>
        /// indica si definitivamente esta abierto o cerrado el local. 
        /// 247 es un shorcut que dice que esta abierto 247
        /// </summary>
        /// <returns>True: abierto. False: cerrado</returns>
        public bool estaAbierto() 
        {           
            return ((!diaCerrado() 
                & (Convert.ToInt32(convertirDiaHoy()) < Convert.ToInt32(horarioHoyTienda(CIERRE)))
                    & (Convert.ToInt32(convertirDiaHoy()) > Convert.ToInt32(horarioHoyTienda(APERTURA))))
                          || (String.Compare(entrada, "247") == 0));
        }

        /// <summary>
        /// devueve el dia obtenido por el metodo day of week
        /// </summary>
        /// <returns></returns>
        private int numeroDia() 
        {
            string day = now.DayOfWeek.ToString();

            if (String.Compare(day, "Monday") == 0)
                return 1;
            if (String.Compare(day, "Tuesday") == 0)
                return 2;
            if (String.Compare(day, "Wednesday") == 0)
                return 3;
            if (String.Compare(day, "Thursday") == 0)
                return 4;
            if (String.Compare(day, "Friday") == 0)
                return 5;
            if (String.Compare(day, "Saturday") == 0)
                return 6;
            if (String.Compare(day, "Sunday") == 0)
                return 7;
            return 0;
        }

        /// <summary>
        /// Retorna el string coorrespondiente al horario de la tienda el dia de hoy
        /// </summary>
        /// <param name="entrada">String con todo el horario de la tienda</param>
        /// <param name="especificacion">escifica que dato necesita, puede ser apertura o cierre</param>
        /// <returns></returns>
        private string horarioHoyTienda(int especificacion)
        {
            int dia = numeroDia(), inicio, fin;
            string salida = entrada;

            //en caso de los shorcut, sale inmediatamente
            if (salida.Length < 55)
                return "0000";
            
            //en caso que sea solo la hora de apertura, solo toma 
            //los primeros 4 valores del horario
            if (especificacion == APERTURA)
                inicio = (dia - 1) * 4;
            else
                inicio = ((dia - 1) * 4) + 4;
            
            //la cantidad de caracteres simepre es el mismo
            fin = inicio + 3;
            
            //cortar a parte derecha
            if(fin != salida.Length - 1)
                salida = salida.Remove(fin, salida.Length - 1 - fin);

            //cortar la parte izquierda
            if (inicio != 0)
                salida = salida.Remove(0, inicio);
            
            return salida;
        }

        /// <summary>
        /// cambia el formato de la hora dado por DateTime a a formato usado por la app
        /// </summary>
        /// <returns>hora actual en string. ejm: "1905"</returns>
        private string convertirDiaHoy() 
        {
            string hora = now.Hour.ToString();
            string minutos = now.Minute.ToString();
            return hora + minutos;
        }

        /// <summary>
        /// Indica si ese dia a tienda esta cerrada o no
        /// </summary>
        /// <returns>true: cerrada, false: abierta</returns>
        private bool diaCerrado() 
        {
            return (String.Compare(horarioHoyTienda(APERTURA), horarioHoyTienda(CIERRE)) == 0);
        }
    }
}
