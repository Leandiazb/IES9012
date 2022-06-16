
namespace IES9012.Core.Enumeraciones
{
    public enum Nota
        // un enum es algo que asocia un texto a un valor numerico, una enumeracion
        // vamos a crear una tabla de notas nuevas 
        // de forma predeterminada los valores de constante asociados de miembros de numeracion son de tipo entero (int)
        // comienzan con cero y aumentan en uno despues del texto de la definicion.
        // puede especificar explicitamente cualquier otro tipo de numero entero como un tipo subyacente de un 
        // tipo de enumeracion.
        // tambien puede especificar explicitamente los valores 
    {   // de constante asociados, como se muenstran en el ejemplo siguiente:

        Mal = 0,
        Deficiente = 20,
        Regular = 40,
        Bien = 60,
        MuyBien = 80,
        Sobresaliete = 100,


    }
}