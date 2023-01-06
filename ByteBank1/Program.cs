namespace ByteBank1
{
    public class Program
    {

        //Menu Principal
        private static void menuPrincipal()
        {
            Console.WriteLine("Inserir novo usuario -----------------------(1)");
            Console.WriteLine("Deletar um usuario -------------------------(2)");
            Console.WriteLine("Listar todas as contas registradas ---------(3)");
            Console.WriteLine("Detalhes de um usuario ---------------------(4)");
            Console.WriteLine("Quantia armazenado no banco digite ---------(5)");
            Console.WriteLine("Manipular conta ----------------------------(6)");
            Console.WriteLine("Quantidade de usuarios no banco ------------(7)");
            Console.WriteLine("Sair do sistema ----------------------------(9)");
            Console.Write("Digite a opcao desejada : ");
        }

        // Registrar Novo Usuario

        private static void RegistrarNovoUsusario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Write("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());
            Console.Write("Digite o titular: ");
            titulares.Add(Console.ReadLine());
            Console.Write("Digite a senha: ");
            senhas.Add(Console.ReadLine());
            Console.WriteLine();
            saldos.Add(0);
        }

        // Listar Todas as contas.
        private static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            for (int i = 0; i < cpfs.Count; i++)
            {
                Console.WriteLine($"CPF = {cpfs[i]} | Titular = {titulares[i]} | Saldo = R${saldos[i]:F2}");
            }
        }



        private static void Main(string[] args)
        {

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();
     
            double totalDeSaldos = 0;
            int opcaoPrincipal = 0;
            int quantidade = 0;

            do
            {
                menuPrincipal();
                opcaoPrincipal = int.Parse(Console.ReadLine());

                Console.WriteLine("-----------------");

                if (opcaoPrincipal == 1)
                {
                    RegistrarNovoUsusario(cpfs, titulares, senhas, saldos);
                }
                if (opcaoPrincipal == 2)
                {
                    Console.WriteLine("Qual o cpf do usuario que sera deletado ?");
                    string remove = Console.ReadLine();
                    int cpfARemover = cpfs.FindIndex(x => x == remove);

                    if (cpfARemover == -1)
                    {
                        Console.WriteLine("CPF nao encontrado na base de dados\n");
                    }
                    else
                    {

                        Console.WriteLine("CPF removido com sucesso\n");

                    }
                }
                if (opcaoPrincipal == 3)
                {
                    ListarTodasAsContas(cpfs, titulares, saldos);
                    Console.WriteLine();
                }
                if (opcaoPrincipal == 4)
                {
                    Console.Write("Qual o CPF do usuario : ");
                    int cpf = cpfs.IndexOf(Console.ReadLine());

                    if (cpf == -1)
                    {
                        Console.WriteLine("CPF nao encontrado na base de dados\n");
                    }
                    else
                    {
                        Console.WriteLine($"CPF = {cpfs[cpf]} | Titular = {titulares[cpf]} | Saldo = R${saldos[cpf]:F2}");
                    }
                }
                if (opcaoPrincipal == 5)
                {
                    for (int i = 0; i < cpfs.Count; i++)
                    {
                        totalDeSaldos = totalDeSaldos + saldos[i];
                    }
                    Console.WriteLine($"Quantia Armazenada no banco é R${totalDeSaldos}");
                    totalDeSaldos = 0;
                }
                if (opcaoPrincipal == 7)
                {
                    for (int i = 0; i < cpfs.Count; i++)
                    {
                        quantidade++;
                    }
                    Console.WriteLine($"A quantidade armazenada no banco é de {quantidade} usuarios");
                    quantidade = 0;
                }

                if (opcaoPrincipal == 9)
                { 
                    Console.WriteLine("Encerrando sistema ....");
                }
                
            } while (opcaoPrincipal != 6 && opcaoPrincipal != 9);

          


        } 


    }

}




















