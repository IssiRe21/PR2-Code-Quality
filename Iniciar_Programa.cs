using System;
using System.Collections.Generic;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Inicia todo el programa para calcular las calificaciones
    /// </summary>
    class IniciarPrograma
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Boleta boleta = new Boleta();

            Materia biologiaGatuna = new Materia("Biología gatuna", 80,15,5);
            Materia matematicasEnGatos = new Materia("Matematicas aplicadas en gatos", 50,30,20);
            Materia lenguajeFelino = new Materia("Lenguaje felino", 60,40,0);
            Materia apreciacionFelina = new Materia("Apreciacion a la belleza felina", 30,60,10);

            Carrera LicenciaturaEnGatos = new Carrera("Licenciatura en gatos", biologiaGatuna, matematicasEnGatos, lenguajeFelino, apreciacionFelina);

            Alumno Ruperto = new Alumno("Ruperto", calculadora.CalcularCalificacionMateria(biologiaGatuna,7m,8m,8m), calculadora.CalcularCalificacionMateria(matematicasEnGatos,8m,6m,6m),calculadora.CalcularCalificacionMateria(lenguajeFelino,7m, 7m, 7m), calculadora.CalcularCalificacionMateria(apreciacionFelina, 9m,6m,7m) );
            Alumno Jiji = new Alumno("Jiji", calculadora.CalcularCalificacionMateria(biologiaGatuna,9m,10m,10m), calculadora.CalcularCalificacionMateria(matematicasEnGatos,10m,10m,10m),calculadora.CalcularCalificacionMateria(lenguajeFelino,8m, 10m, 9m), calculadora.CalcularCalificacionMateria(apreciacionFelina,10m,10m,10m));
            Alumno Masafecio = new Alumno("Masafecio", calculadora.CalcularCalificacionMateria(biologiaGatuna,4m,7m,5m), calculadora.CalcularCalificacionMateria(matematicasEnGatos,6m,7m,7m),calculadora.CalcularCalificacionMateria(lenguajeFelino,3m, 2m, 0m), calculadora.CalcularCalificacionMateria(apreciacionFelina, 4m,6m,0m));

            List<Alumno> Grupo1 = new List<Alumno>();
            Grupo1.Add(Ruperto);
            Grupo1.Add(Jiji);
            Grupo1.Add(Masafecio);

            Grupo grupo1 = new Grupo("1ro A",Grupo1, LicenciaturaEnGatos);

            boleta.ImprimirBoleta(grupo1);           
        }
    }
}
