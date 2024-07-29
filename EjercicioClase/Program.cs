using EjercicioClase;
string Vuela;
double contador;
contador= 1;
SuperPoder superpoder = new SuperPoder();
while (contador <= 3){
    
    Console.WriteLine("Ingrese el Nombre del SuperHeroe");
    superpoder.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la Identidad Secreta , shhhhh");
    superpoder.IdentidadSecreta = Console.ReadLine();
    Console.WriteLine("Este Super Heroe Puede Volar, S/N?");
    Vuela = Console.ReadLine();
    if (Vuela == "S" || Vuela == "s")
    {
        superpoder.PuedeVolar = true;
    }
    else
    {
        superpoder.PuedeVolar = false;
    }
    Console.WriteLine("Ingrese el Nombre del SuperPoder");
    superpoder.SuperPoder = Console.ReadLine();
    Console.WriteLine("Ingrese el Nombre del Poder");
    superpoder.NombrePoder = Console.ReadLine();
    Console.WriteLine("Ingrese el Descripcion del Poder");
    superpoder.Descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese el nivel del Poder");
    superpoder.Nivel = Convert.ToInt32(Console.ReadLine());


    contador++;
}

superpoder.Imprimir();


