using System;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Maneja todo lo relacionado a los alumnos (cada alumno contiene un nombre y cuatro calificaciones, una por cada materia)
    /// </summary>
    class Alumno
    {
       string nombre { get; set; }
       decimal CalificacionUno { get; set; }
       decimal CalificacionDos { get; set; }
       decimal CalificacionTres { get; set; }
       decimal CalificacionCuatro { get; set; }
       public Alumno(string nombre, decimal CalificacionUno, decimal CalificacionDos, decimal CalificacionTres, decimal CalificacionCuatro)
       {
           this.nombre = nombre;
           this.CalificacionUno = CalificacionUno;
           this.CalificacionDos = CalificacionDos;
           this.CalificacionTres = CalificacionTres;
           this.CalificacionCuatro = CalificacionCuatro;
       }

        public string TomarNombre()
        {
            return nombre;
        }
        public decimal TomarPrimeraCalificacion()
        {
            return CalificacionUno;
        }
        public decimal TomarSegundaCalificacion()
        {
            return CalificacionDos;
        }
         public decimal TomarTerceraCalificacion()
        {
            return CalificacionTres;
        }
         public decimal TomarCuartaCalificacion()
        {
            return CalificacionCuatro;
        }
    }
}
