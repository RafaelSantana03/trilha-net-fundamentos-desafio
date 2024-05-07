namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        // Construtor que define o preço inicial e o preço por hora do estacionamento.
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Método para adicionar um veículo à lista de veículos estacionados.
        public void AdicionarVeiculo()
        {
            //Pedindo para o usuario informar a placa do carro e adcionando na lista "Veiculos".
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo);
        }

        // Método para remover um veículo da lista de veículos estacionados.
        public void RemoverVeiculo()
        {
            //Pede para o usuario informar a placa do veículo a ser removido
            Console.WriteLine("Digite a placa do veículo para remover:");
            string removerPlaca = Console.ReadLine();
            string placa = removerPlaca;

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = int.Parse(Console.ReadLine());

                //Calculo do valor a ser pago pelo uso do estacionamento: "precoInicial + precoPorHora * horas" = valor a ser pago
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;

                //Removendo a placa digitada da lista de veículos
                veiculos.Remove(placa);

                //
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        // Método para listar todos os veículos estacionados.
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //Exibe os veículos estacionados
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
