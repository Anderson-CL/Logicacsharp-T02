using AulaRegistrosArquivos;

namespace AulaRegistrosArquivos
{
    public struct Cliente
    {
        public string Nome;
        public int Idade;
        public string Email;
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Declaração e uso básico de registros
            Cliente cliente1;
            cliente1.Nome = "Joca";
            cliente1.Idade = 16;
            cliente1.Email = "jocagames@games.com";

            Console.WriteLine("=== Cliente 1 ===");
            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Idade: " + cliente1.Idade);
            Console.WriteLine("Email: " + cliente1.Email);
            Console.WriteLine();

            //Segunda gravação e exibição de informações
            Cliente cliente2;
            cliente2.Nome = "Mimi";
            cliente2.Idade = 78;
            cliente2.Email = "colunaveia@meajude.com";

            Console.WriteLine("=== Cliente 2 ===");
            Console.WriteLine("Nome: " + cliente2.Nome);
            Console.WriteLine("Idade: " + cliente2.Idade);
            Console.WriteLine("Email: " + cliente2.Email);
            Console.WriteLine();

            // Organização de dados em tabela (vetor de registros)
            Cliente[] clientes = new Cliente[2];
            clientes[0].Nome = "Joca";
            clientes[0].Idade = 16;
            clientes[0].Email = "jocagames@games.com";
            clientes[1].Nome = "Mimi";
            clientes[1].Idade = 78;
            clientes[1].Email = "colunaveia@meajude.com";

            Console.WriteLine("=== Tabela de Clientes ===");

            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("Idade: " + cliente.Idade);
                Console.WriteLine("Email: " + cliente.Email);
                Console.WriteLine();
            }

            // ==Gravação de dados em arquivo==
            Cliente cliente3;
            cliente3.Nome = "MD";
            cliente3.Idade = 30;
            cliente3.Email = "chamanacatraca@buss.com";

            string caminhoArquivo = "Clientes.txt";

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                sw.WriteLine("===Cliente 3===");
                sw.WriteLine("Nome: " + cliente3.Nome);
                sw.WriteLine("Idade: " + cliente3.Idade);
                sw.WriteLine("Email: " + cliente3.Email);

            }

            Console.WriteLine("=== Gravação em Arquivo===");
            Console.WriteLine($"Informações de {cliente3.Nome} gravadas em '{caminhoArquivo}'.");
            Console.WriteLine();

            //Leitura do arquivo gravado
            Console.WriteLine("=== Conteúdo do Arquivo===");
            string conteudo = File.ReadAllText(caminhoArquivo);
            Console.WriteLine(conteudo);

            Console.WriteLine("\n=== Fim da Execução===");

        }
    }
}

