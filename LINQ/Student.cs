using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student
    {
        public int idStudent { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }
        public int age { get; set; }
       public string nacionalidad { get; set; }
        //metodo con la cloleccion de datos
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{idStudent= 1001, firstName = "Jose", lastName = "Robles", age = 25, nacionalidad="Colombiano" },
                new Student{idStudent= 1002, firstName = "Ana", lastName = "Lopez", age = 20, nacionalidad="Costarisence" },
                new Student{idStudent= 1003, firstName = "Rafael", lastName = "Gonzalez", age = 21, nacionalidad="Mexicano" },
                new Student{idStudent= 1004, firstName = "Alfredo", lastName = "Valladares", age = 23, nacionalidad="Hondureño" },
                new Student{idStudent= 1005, firstName = "Amanda", lastName = "Flores", age = 22, nacionalidad="Salvadoreña" },
            };
            return students; //retornamos la colección
        }
    }
}
