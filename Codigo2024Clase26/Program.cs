
using Codigo2024Clase26;

void ClonarError()
{
    Producto producto = new Producto
    {
        Nombre = "TV Samsumng",
        Precio = 5000,
        Descripcion = "TV LED Smart Tv",
        Stock = 10
    };


    Producto producto1 = producto;
    producto1.Nombre = "TV LG";
    producto.Stock = 20;


    Producto producto2 = new Producto
    {
        Nombre = producto.Nombre,
        Descripcion = producto.Descripcion,
        Precio = producto.Precio,
        Stock = producto.Stock
    };
    producto2.Nombre = "Hyunday";




    Console.WriteLine(producto.Nombre); //TV SAMSUMNG
    Console.WriteLine(producto1.Nombre); //TV LG
    Console.WriteLine(producto2.Nombre); //TV LG



    Console.WriteLine(producto.Stock); //TV SAMSUMNG
    Console.WriteLine(producto1.Stock); //TV LG


    Console.Read();
}



Persona persona = new Persona("Hugo", "Torrico");
Console.WriteLine(persona.Nombres + " " + persona.Apellidos);



Persona persona1 = persona.ManualClone();
Console.WriteLine(persona1.Nombres + " " + persona1.Apellidos);

Console.WriteLine("===========================================");

persona1.Apellidos = "Marquez";
persona1.Nombres = "Felipe";




Console.WriteLine(persona.Nombres + " " + persona.Apellidos);
Console.WriteLine(persona1.Nombres + " " + persona1.Apellidos);



Console.Read();





