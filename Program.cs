//Nomeação do projeto de Censo
namespace Censo
{
    //Criação da classe principal da aplicação:
    class App
    {
        //Criação do código principal da classe:
        static void Main(string[] args)
        {

            //Executa o método para receber a quantidade de pessoas totais:
            Dictionary<string, int> dados = PedirDados();

            //Limpa a tela:
            Console.Clear();

            //Exibe os dados obtidos:
            Console.WriteLine($"{new String('=', 20)}DADOS DO CENSO 2022{new String('=', 20)}" +
                $"\nFamílias: {dados["familias"]}" +
                $"\nPessoas biologicamentes masculinas: {dados["masculinoTotal"]}" +
                $"\nPessoas biologicamentes femininas: {dados["femininoTotal"]}" +
                $"\nPessoas por família: {dados["pessoasTotal"]/dados["familias"]}" +
                $"\n\nFIM DOS DADOS");
        }

        //Método para realizar os Dados de cada família:
        private static Dictionary<string, int> PedirDados()
        {
            //Cria objetos que vão compor informações essenciais ao Censo:
            int pessoasTotal = 0, masculinoTotal = 0, femininoTotal = 0, familias = 0;

            //Cria objetos auxiliares:
            int masculino, feminino;
            char continuar;

            //Faz a primeira execução do Censo, fora do While:
            Console.WriteLine($"{new String('=', 20)}CENSO{new String('=', 20)}");

            Console.Write("\nQuantas pessoas do sexo biológico masculino moram em sua casa? ");
            masculino = int.Parse(Console.ReadLine());

            Console.Write("Quantas pessoas do sexo biológico feminino moram em sua casa? ");
            feminino = int.Parse(Console.ReadLine());

            masculinoTotal += masculino;
            femininoTotal += feminino;
            pessoasTotal += (masculino + feminino);
            familias++;

            Console.Write("\nDeseja continuar? ");
            continuar = char.ToLower(char.Parse(Console.ReadLine()));

            //Faz a execução do censo enquanto tiver familias para se pesquisar:
            while (continuar == 's')
            {
                Console.Clear();

                Console.WriteLine($"{new String('=', 20)}Censo{new String('=', 20)}");

                Console.Write("\nQuantas pessoas do sexo biológico masculino moram em sua casa? ");
                masculino = int.Parse(Console.ReadLine());

                Console.Write("Quantas pessoas do sexo biológico feminino moram em sua casa? ");
                feminino = int.Parse(Console.ReadLine());

                masculinoTotal += masculino;
                femininoTotal += feminino;
                pessoasTotal += (masculino + feminino);
                familias++;

                Console.Write("\nDeseja continuar? ");
                continuar = char.ToLower(char.Parse(Console.ReadLine()));
            }

            //Faz a criação do Dicionario, seu povoamento e realiza o seu retorno:
            var censo = new Dictionary<string, int>();

            censo.Add("familias", familias);
            censo.Add("pessoasTotal", pessoasTotal);
            censo.Add("masculinoTotal", masculinoTotal);
            censo.Add("femininoTotal", femininoTotal);

            return censo;
        }
    }
}