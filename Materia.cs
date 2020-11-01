using System;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Maneja todo lo relacionado con las materias (El nombre de la materia y los criterios de evaluación)
    /// </summary>
    class Materia
    {
       string nombre { get; set; }
       /// <summary>
       /// Es el porcentaje del examen en proporción a la calificacion final - ej: el examen vale el 50% de la calificacion (Entre los 3 valores deben sumar 100)
       /// </summary>
       public int valorExamen { get; set; }
       /// <summary>
       /// Es el porcentaje de los trabajos en proporción a la calificacion final - ej: los trabajos valen el 50% de la calificacion (Entre los 3 valores deben sumar 100)
       /// </summary>
       /// <value></value>
       public int valorTrabajos { get; set; }
       /// <summary>
       /// (Es un valor opcional, a criterio del maestro ej: asistencia y puntualidad o un proyecto )Es el porcentaje de los valores extra en proporción a la calificacion final - ej: los extras valen el 50% de la calificacion (Entre los 3 valores deben sumar 100)
       /// </summary>
       public int valorExtra { get; set; }

       public Materia(string nombre, int valorExamen, int valorTrabajos, int valorExtra)
       {
           this.nombre = nombre;
           this.valorExamen = valorExamen;
           this.valorTrabajos = valorTrabajos;
           this.valorExtra = valorExtra;
       }

       public string TomarNombre()
        {
            return nombre;
        }
    }
}
