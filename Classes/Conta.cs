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

        public void Depositar(double? valor) => this.Saldo += valor;
        public bool Transferir(Conta conta, double? valor)
        {
            if (valor > (this.Saldo + this.Credito))
            {
                return false;
            }
            this.Sacar(valor);
            conta.Depositar(valor);
            return true;
        }

        public bool Sacar(double? valor)
        {
            if (valor > (this.Credito + this.Saldo))
            {
                return false;
            }
            this.Saldo -= valor;
            return true;
        }

        public override string ToString()
        {
            return $"{this.TipoConta},{this.Nome},{this.Credito},{this.Saldo}";
        }
    }
}