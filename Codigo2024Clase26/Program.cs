
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



    Console.WriteLine(ReferenceEquals(producto, producto1));

    Console.WriteLine(producto.Nombre); //TV SAMSUMNG
    Console.WriteLine(producto1.Nombre); //TV LG
    Console.WriteLine(producto2.Nombre); //TV LG



    Console.WriteLine(producto.Stock); //TV SAMSUMNG
    Console.WriteLine(producto1.Stock); //TV LG


    Console.Read();
}

void ClonarCorrecto()
{
    Persona persona = new Persona("Hugo", "Torrico", "", "", 36);
    Console.WriteLine(persona.Nombres + " " + persona.Apellidos);

    Persona persona1 = persona.ClonarManual();
    Console.WriteLine(persona1.Nombres + " " + persona1.Apellidos);

    Persona persona2 = persona.Clonar();
    Console.WriteLine(persona2.Nombres + " " + persona2.Apellidos);


    Console.WriteLine("===========================================");

    persona1.Apellidos = "Marquez";
    persona1.Nombres = "Felipe";

    persona2.Apellidos = "xxxx";
    persona2.Nombres = "yyyyy";


    Console.WriteLine(persona.Nombres + " " + persona.Apellidos);
    Console.WriteLine(persona1.Nombres + " " + persona1.Apellidos);
    Console.WriteLine(persona2.Nombres + " " + persona2.Apellidos);


}



void Prueba1()
{
    Logger logger11 = new Logger();
    logger11.Log("Inicio de la aplicación.");
}

void Prueba2()
{
    Logger logger22 = new Logger();
    logger22.Log("Inicio de la aplicación.");
}


void PruebaSingleton1()
{
    Logger logger11 = Logger.Instance;
    logger11.Log("Inicio de la aplicación.");
}

void PruebaSingleton2()
{
    Logger logger22 = Logger.Instance;
    logger22.Log("Inicio de la aplicación.");
}

void PruebaSingleton3()
{
    Logger logger33 = Logger.Instance;
    logger33.Log("Inicio de la aplicación.");
}


ProxyServidor proxy = new ProxyServidor();
proxy.ProcesarSolicitudPermiso("usuario");
proxy.ProcesarSolicitudPermiso("administrador");


Console.Read();





