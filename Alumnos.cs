using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Alumnos
{
    /// <summary>
    /// Representa una lista con alumnos en cada posición del Arraylist
    /// </summary>    
    class Alumnos
    {
        /// <summary>
        /// Crea el Arraylist para guardar los alumnos
        /// </summary>        
        private ArrayList listaAlumnos = new ArrayList();

        /// <summary>
        /// Retorna la lista de alumnos
        /// </summary>
        public ArrayList ListaAlumnos
        {
            get { return listaAlumnos; }
        }

        /// <summary>
        /// Agrega un nuevo alumno a la lista
        /// </summary>
        /// <param name="alumno">Alumno a introducir</param>
        public void AgregarAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }

        /// <summary>
        /// Calcula la media de las notas de todos los alumnos
        /// </summary>
        /// <returns>El valor de la nota media</returns>
        public double MediaNotas()
        {
            Alumno alu;

            double media;
            int i;

            media = 0;

            for (i = 0; i < listaAlumnos.Count; i++)
            {
                alu = (Alumno)listaAlumnos[i];
                media = media + alu.Nota;
            }

            if (listaAlumnos.Count == 0)
                media = 0;
            else
                media = media / listaAlumnos.Count;

            return media;
        }
    }
}
