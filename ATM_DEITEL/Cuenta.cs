using System;


namespace ATM_DEITEL
{
    class Cuenta
    {
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public bool Activa { get; set; }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo disponible: RD$" + Saldo);
        }

        public void Depositar(decimal monto)
        {
            if (Activa && monto > 0)
            {
                Saldo = Saldo + monto;
                Console.WriteLine("Deposito realizado correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo realizar el deposito.");
            }
        }

        public void Retirar(decimal monto)
        {
            if (Activa && monto > 0 && monto <= Saldo)
            {
                Saldo = Saldo - monto;
                Console.WriteLine("Retiro realizado correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo realizar el retiro.");
            }
        }
    }
}
