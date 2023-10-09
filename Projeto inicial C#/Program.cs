internal class Program
{
    private static void Main(string[] args)
    {
        string nomeDigitado;
        int idadeDigitada;

        Console.WriteLine(" Digite seu nome");
        nomeDigitado = Console.ReadLine();


        Console.WriteLine("idade: ");
        idadeDigitada = Convert.ToInt32(Console.ReadLine());

        if (idadeDigitada < 18)
        {
            Console.WriteLine("Você é menor de idade");
        }
        else
        {
            Console.WriteLine("Você é maior de idade");
        }
    }
}