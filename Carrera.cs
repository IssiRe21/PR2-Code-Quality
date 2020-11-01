using System;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Maneja todo lo relacionado a las carreras (El nombre de la carrera y las materias que las conforman)
    /// </summary>
    class Carrera                                                                                                     
    {
        string nombre;
        Materia materiaUno;
        Materia materiaDos;
        Materia materiaTres;
        Materia materiaCuatro;
         public Carrera(string nombre, Materia materiaUno, Materia materiaDos, Materia materiaTres, Materia materiaCuatro)
        {
            this.nombre = nombre;
            this.materiaUno = materiaUno;
            this.materiaDos = materiaDos;
            this.materiaTres = materiaTres;
            this.materiaCuatro = materiaCuatro;
        }

        public string TomarNombre()
        {
            return nombre;
        }
        public Materia TomarMateriaUno()
        {
            return materiaUno;
        }
        public Materia TomarMateriaDos()
        {
            return materiaDos;
        }
        public Materia TomarMateriaTres()
        {
            return materiaTres;
        }
        public Materia TomarMateriaCuatro()
        {
            return materiaCuatro;
        }
    }
}
