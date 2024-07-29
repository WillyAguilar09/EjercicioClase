

namespace EjercicioClase
{
    public class SuperPoder:SuperHeroe
    {
        public string NombrePoder { get; set; }
        public string Descripcion { get; set; }
        public double Nivel { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Puede Volar: {(PuedeVolar ? "Si":"No")}");
            Console.WriteLine($"Super Poder: {SuperPoder}");
            Console.WriteLine($"Nombre del Poder: {NombrePoder}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Nivel: {Nivel}");

        }


    }
}
