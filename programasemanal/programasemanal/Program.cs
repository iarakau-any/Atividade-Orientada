class Program

{

    static void Main()

    {

        List<string> nomes = new List<string>();

        string entrada;



        Console.WriteLine("=== Sorteador de Nomes ===");

        Console.WriteLine("Digite os nomes (ou deixe vazio e aperte ENTER para finalizar):");



        // Coleta de nomes 

        while (true)

        {

            Console.Write("Nome: ");

            entrada = Console.ReadLine();



            if (string.IsNullOrWhiteSpace(entrada))

                break; // Sai do loop se apertar ENTER sem digitar nada 



            nomes.Add(entrada);

        }



        // Verifica se há nomes na lista 

        if (nomes.Count == 0)

        {

            Console.WriteLine("Nenhum nome foi inserido. Encerrando programa.");

            return;

        }



        // Sorteio 

        Random rand = new Random();

        int indiceSorteado = rand.Next(nomes.Count);

        string vencedor = nomes[indiceSorteado];



        Console.WriteLine("\nO vencedor sorteado é: " + vencedor + " ! ");

    }

}
