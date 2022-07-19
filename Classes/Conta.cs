using diobank.Enum;

namespace diobank.Classes
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double? Saldo { get; set; }
        private double? Credito { get; set; }

        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, string nome, double? credito, double? saldo)
        {
            this.TipoConta = tipoConta;
            this.Nome = nome;
            this.Credito = credito;
            this.Saldo = saldo;
        }

        /*
        * Todo
        * Criar os métodos: Sacar, Depositar, Transferir.
        * Override toString()
        */

        public bool Sacar(double? valor)
        {
            if (valor <= (this.Credito + this.Saldo))
            {
                return false;
            }
            this.Saldo += valor;
            return true;
        }
    }
}