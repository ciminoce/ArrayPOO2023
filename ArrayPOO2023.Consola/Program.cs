using ArrayPOOO2023.Entidades;

namespace ArrayPOO2023.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Arrays!");
            var miArray = new MiArray();
            Console.WriteLine(miArray.GetCantidad());
            miArray.Fill(1, 6);
            Console.WriteLine(miArray.ShowArray());
            miArray.Sort(true);
            Console.WriteLine(miArray.ShowArray());
            int numero = miArray;
            Console.WriteLine(numero);
            var nro = 1;
            var resultadoBusqueda = miArray.IfExist(nro);
            if (resultadoBusqueda.Item1) {
                Console.WriteLine($"{nro} existe y se encuentra en la posición {resultadoBusqueda.Item2}");
            }
            else
            {
                Console.WriteLine("No Existe");
            }
        }

       
    }
}