using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    /// <summary>
    /// Clase que muestra un alumno
    /// </summary>
    public class Alumno
    {
        /// <summary>
        /// Representa el nombre del alumno
        /// </summary>
        private string nombre; 
        /// <summary>
        /// Representa la nota del alumno
        /// </summary>
        private int nota;
        
        /// <summary>
        /// Obtiene y devuelve el nombre y apellidos del alumno
        /// </summary>
        /// <value>El nombre y los apellidos</value>
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        /// <summary>
        /// Obtiene y devuelve la nota del alumno
        /// La nota debe estar entre 0 y 10
        /// </summary>
        /// <value>La nota</value>
        public int Nota
        {
            get { return nota; }
            set
            {
                if (value >= 0 && value <= 10)
                    nota = value;
            }
        }

        /// <summary>
        /// Devuelve verdadero si la nota es mayor a 5 y false en caso contrario
        /// </summary>
        public Boolean Aprobado
        {
            get
            {
                if (nota >= 5)
                    return true;
                else
                    return false;
            }
        }
        /// <summary>
        /// Función que muestra los datos de los alumnos
        /// </summary>
        /// <returns>Lista de alumnos con su calificación</returns>
        public string mostrardatos()
        {
            string texto;

            texto = "Nombre: " + nombre + "   Nota: " + nota;

            if (Aprobado)
                texto = texto + "   [Aprobado]";
            else
                texto = texto + "   [Suspendido]";

            return texto;
        }
    }
}
