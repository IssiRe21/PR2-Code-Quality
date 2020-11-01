using System;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Maneja los cálculos de las calificaciones y promedios
    /// </summary>
    class Calculadora
    {

        /// <summary>
        /// Toma los criterios de evaluación de una materia y las calificaciones de un alumno
        /// </summary>
        /// <returns>La calificacion de la materia </returns>
        public decimal CalcularCalificacionMateria(Materia materia, decimal calificacionExamen, decimal calificacionTrabajos, decimal calificacionExtra)
        {
            decimal calificacion = (calificacionExamen*materia.valorExamen) + (calificacionTrabajos*materia.valorTrabajos) + (calificacionExtra*materia.valorExtra);
            calificacion = calificacion/100;
          return calificacion;   
        }

        
        /// <summary>
        /// Toma las calificaciones de las materias de un alumno y calcula el promedio
        /// </summary>
        /// <returns>El promedio final</returns>
        public decimal CalcularPromedio(Alumno alumno)
        {
            decimal promedio;
            promedio = (alumno.TomarPrimeraCalificacion() + alumno.TomarSegundaCalificacion() + alumno.TomarTerceraCalificacion() + alumno.TomarCuartaCalificacion()) / 4;
            return promedio;
        }
    }
}