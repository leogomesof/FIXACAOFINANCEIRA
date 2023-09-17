namespace controleContas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Agencia agencia1 = new Agencia(0001, "27286550", "2433377325");
                Cliente cliente1 = new Cliente("Alfredo", 1999, "12345678910");
                Conta conta1 = new Conta(123456, cliente1); //criei minha instância (new cria um objeto)
                Conta conta2 = new Conta(654321, cliente1);

                conta1.SaldoInicial(200);
                conta1.Depositar(1000);
                Console.WriteLine("O saldo inicial da conta 1 é: {0} é R${1}", conta1.Numero, conta1.Saldo);
                Console.WriteLine("O saldo inicial da conta 2 é: {0} é R${1}", conta2.Numero, conta2.Saldo);

                conta1.Transferir(conta2, 1600m); //(conta destino que espera um construtor e valor
                Console.WriteLine("O saldo atual da conta 1 é: {0} é R${1}", conta1.Numero, conta1.Saldo);
                Console.WriteLine("O saldo atual da conta 2 é: {0} é R${1}", conta2.Numero, conta2.Saldo);

                Console.WriteLine("O Cliente da conta {0} é {1}", conta1.Numero, conta1.Titular.Nome);
            }

            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            /*Console.Write("\nDigite um valor para depósito: R$");
            conta1.Depositar(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("O saldo da conta após o depósito é: {0}", conta1.Saldo);

            Console.Write("\nDigite um valor para sacar: R$");
            conta1.Sacar(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("O saldo da conta após o saque é: {0}", conta1.Saldo);
            
             Console.Write("\nDigite um valor para transferir: R$");
            conta1.Transferir(conta2, decimal.Parse(Console.ReadLine()));
            Console.WriteLine("O saldo da conta após o saque é: {0}", conta1.Saldo);*/
        }
    }
}