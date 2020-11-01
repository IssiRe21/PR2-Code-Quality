using System;
using System.Collections.Generic;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Maneja todo lo relacionado con los grupos (cada grupo incluye un nombre y una lista de alumnos)
    /// </summary>
    class Grupo
    {
        string nombre;
        List<Alumno> listaDeAlumnos = new List<Alumno>();
        Carrera carrera { get; set; }
        public Grupo(string nombre,List<Alumno> listaDeAlumnos, Carrera carrera)
        {
            this.nombre = nombre;
            this.listaDeAlumnos = listaDeAlumnos;
            this.carrera = carrera;
        }

        public string TomarNombre()
        {
            return nombre;
        }
        public Carrera TomarCarrera()
        {
            return carrera;
        }

        public List<Alumno> TomarAlumnos()
        {
            return listaDeAlumnos;
        }
    }
}
