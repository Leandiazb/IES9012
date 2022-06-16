using IES9012.Core.Enumeraciones;
using IES9012.Core.Modelos;
namespace IES9012.UI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IES9012Context context)
        {
            // Look for any students.
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            if (context.Estudiantes.Any())
            {
                return; // DB has been seeded
            }
#pragma warning restore CS8604 // Posible argumento de referencia nulo
            var estudiantes = new Estudiante[]
            {
                new Estudiante{Nombre="Carson",Apellido="Alexander",FechaInscripcion=DateTime.Parse("2019-09-01")},
                new Estudiante{Nombre="Meredith",Apellido="Alonso",FechaInscripcion=DateTime.Parse("2017-09-01")},
                new Estudiante{Nombre="Arturo",Apellido="Anand",FechaInscripcion=DateTime.Parse("2018-09-01")},
                new Estudiante{Nombre="Gytis",Apellido="Barzdukas",FechaInscripcion=DateTime.Parse("2017-09-01")},
                new Estudiante{Nombre="Yan",Apellido="Li",FechaInscripcion=DateTime.Parse("2017-09-01")},
                new Estudiante{Nombre="Peggy",Apellido="Justice",FechaInscripcion=DateTime.Parse("2016-09-01")},
                new Estudiante{Nombre="Laura",Apellido="Norman",FechaInscripcion=DateTime.Parse("2018-09-01")},
                new Estudiante{Nombre="Nino",Apellido="Olivetto",FechaInscripcion=DateTime.Parse("2019-09-01")}
            };
            context.Estudiantes.AddRange(estudiantes);
            context.SaveChanges();
            var materias = new Materia[]
            {
                new Materia{NombreMateria="Chemistry",Creditos=3},
                new Materia{NombreMateria="Microeconomics",Creditos=3},
                new Materia{NombreMateria="Macroeconomics",Creditos=3},
                new Materia{NombreMateria="Calculus",Creditos=4},
                new Materia{NombreMateria="Trigonometry",Creditos=4},
                new Materia{NombreMateria="Composition",Creditos=3},
                new Materia{NombreMateria="Literature",Creditos=4}
            };
            context.Materias.AddRange(materias);
            context.SaveChanges();
            var inscripciones = new Inscripcion[]
            {
                new Inscripcion{EstudianteId=1,MateriaId=1,Nota=Nota.Mal},
                new Inscripcion{EstudianteId=1,MateriaId=2,Nota=Nota.Bien},
                new Inscripcion{EstudianteId=1,MateriaId=3,Nota=Nota.MuyBien},
                new Inscripcion{EstudianteId=2,MateriaId=4,Nota=Nota.Sobresaliete},
                new Inscripcion{EstudianteId=2,MateriaId=5,Nota=Nota.Deficiente},
                new Inscripcion{EstudianteId=2,MateriaId=2,Nota=Nota.Sobresaliete},
                new Inscripcion{EstudianteId=3,MateriaId=6},
                new Inscripcion{EstudianteId=4,MateriaId=7},
                new Inscripcion{EstudianteId=4,MateriaId=1,Nota=Nota.MuyBien},
                new Inscripcion{EstudianteId=5,MateriaId=6,Nota=Nota.Mal},
                new Inscripcion{EstudianteId=6,MateriaId=7},
                new Inscripcion{EstudianteId=7,MateriaId=1,Nota=Nota.Sobresaliete},
            };
            context.Inscripciones.AddRange(inscripciones);
            context.SaveChanges();
        }
    }
}
