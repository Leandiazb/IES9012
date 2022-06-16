//using IES9012.Core.Modelos;
//using Microsoft.EntityFrameworkCore;

//namespace IES9012.UI.Data
//{
//    public class IES9012Context : DbContext
//    {
//        public IES9012Context (DbContextOptions<IES9012Context> options)
//            : base(options)
//        {
//        }

//        public DbSet<IES9012.Core.Modelos.Estudiante>? Estudiante { get; set; }
//        public DbSet<Estudiante>? Estudiantes { get; set; }
//        public DbSet<Inscripcion>? Inscripciones { get; set; }
//        public DbSet<Materia>? Materias { get; set; }


using IES9012.Core.Modelos;
using Microsoft.EntityFrameworkCore;
public class IES9012Context : DbContext
{
    public IES9012Context(DbContextOptions<IES9012Context> options)
    : base(options)
    {
    }
    public DbSet<Estudiante>? Estudiantes { get; set; }
    public DbSet<Inscripcion>? Inscripciones { get; set; }
    public DbSet<Materia>? Materias { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)

    {
        modelBuilder.Entity<Materia>().ToTable("Materias");
        modelBuilder.Entity<Inscripcion>().ToTable("Inscripciones");
        modelBuilder.Entity<Estudiante>().ToTable("Estudiantes");
    }
}
