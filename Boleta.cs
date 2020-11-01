using System;
using System.Collections.Generic;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Maneja todo lo relacionado con la boleta (acomodar la informacion e imprimir las calificaciones)
    /// </summary>
    class Boleta
    {
        Calculadora calculadora = new Calculadora();
        List<Alumno> alumnos = new List<Alumno>();  

         
        /// <summary>
        /// Imprime las boletas de todo un grupo, incluye el nombre, grupo, carrera, materias y calificaciones de cada alumno en dicho grupo
        /// (Las calificaciones llevan decimales)
        /// </summary>
        /// <param name="grupo"></param>
        public void ImprimirBoleta(Grupo grupo)
        {    
            alumnos = grupo.TomarAlumnos();
            foreach (Alumno alumno in alumnos)
            {
                System.Console.WriteLine($"Boleta de {alumno.TomarNombre()} del grupo {grupo.TomarNombre()} de la carrera {grupo.TomarCarrera().TomarNombre()}: \n");
                System.Console.WriteLine($"{grupo.TomarCarrera().TomarMateriaUno().TomarNombre()} - - - - - {alumno.TomarPrimeraCalificacion()}");
                System.Console.WriteLine($"{grupo.TomarCarrera().TomarMateriaDos().TomarNombre()} - - - - - {alumno.TomarSegundaCalificacion()}");
                System.Console.WriteLine($"{grupo.TomarCarrera().TomarMateriaTres().TomarNombre()} - - - - - {alumno.TomarTerceraCalificacion()}");
                System.Console.WriteLine($"{grupo.TomarCarrera().TomarMateriaCuatro().TomarNombre()} - - - - - {alumno.TomarCuartaCalificacion()} \n");
                System.Console.WriteLine($"Promedio: - - - - - {calculadora.CalcularPromedio(alumno)} \n");
            }
        }
    }
}