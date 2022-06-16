using IES9012.Core.Enumeraciones;
using System.ComponentModel.DataAnnotations;
namespace IES9012.Core.Modelos
{
    public class Inscripcion
    {
        public int InscripcionId { get; set; }
        // la propiedad materiaid es una clave externa y la propiedad de navegacion 
        // correspondiente es materia 
        // una identidad inscripcion esta asociada con una entidad materia

        public int MateriaId { get; set; }
        // la propiedad estudianteID es una clave externa y la propiedad de navegacion 
        // correspondiente es estudiante. una entidad inscripcion esta asociada con 
        // una entidad estudiante, por lo que la propuedad contiene una unica entidad estidiante.

        [DisplayFormat(NullDisplayText = "Sin Calificación")]
        public Calificacion? Calificacion { get; set; }

        public Materia? Materia { get; set; }
        public Estudiante? EstudianteId { get; set; }
        public Nota Nota { get; set; }
    }
}