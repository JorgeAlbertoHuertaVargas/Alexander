using ENTIDADES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA.CourseLogic
{
    public interface ICourseLogic
    {
        public List<Course> GetCursosListar();
        public int CreatCursos(Course cursos);
        public bool CheckNomberNoExists(string degreeName);
        public object showCurses(int idcurso);
        public List<Course> SelecDeCursos();
        public int DeleteCourses(int Idcurso);
        public int UpdateCourses(Course cursos);

    }
}
