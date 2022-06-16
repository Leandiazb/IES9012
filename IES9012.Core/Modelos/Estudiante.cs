using System.ComponentModel.DataAnnotations;
namespace IES9012.Core.Modelos
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        // campo de identidad de clave primaria 
        // la propiedad id se convierte en la columna de clave principal de la tabla de base de datos.
        [Required]
        [StringLength(50)]
        // largo del campo 
        // requerido que no acepta datos nulos 

        public string Nombre { get; set; } = null!;
        [Required]
        [StringLength(35)]


        public string Apellido { get; set; } = null!;
        [DataType(DataType.Date)]
        [DisplayFormat( DataFormatString = "{0:MM/yyy}", ApplyFormatInEditMode = true)]
        
        public DateTime FechaInscripcion { get; set; }= DateTime.Now;

        // la propiedad de inscripcion es una opcion de navegacion
        // 

        public ICollection<Inscripcion>? Incripciones { get; set; }

        public static implicit operator Estudiante(int v)
        {
            throw new NotImplementedException();
        }

        // si empieza con i es interfa 
        // icollection es una 

    }
}
