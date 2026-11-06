using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_DEITEL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== SISTEMA ATM =====");

            // Crear objeto de la clase Cuenta
            Cuenta cuenta1 = new Cuenta();

            cuenta1.NumeroCuenta = "001245";
            cuenta1.Saldo = 15000;
            cuenta1.Activa = true;

            Console.WriteLine("\n--- INFORMACION DE LA CUENTA ---");

            Console.WriteLine("Numero de cuenta: " + cuenta1.NumeroCuenta);
            cuenta1.ConsultarSaldo();

            // Depositar
            Console.WriteLine("\n--- DEPOSITO ---");
            
            cuenta1.Depositar(2000);
            cuenta1.ConsultarSaldo();

            // Retirar
            Console.WriteLine("\n--- RETIRO ---");

            cuenta1.Retirar(3000);
            cuenta1.ConsultarSaldo();

            // Crear objeto de Transaccion
            Transaccion transaccion1 = new Transaccion();

            transaccion1.Tipo = "Retiro";
            transaccion1.Monto = 3000;
            transaccion1.Fecha = DateTime.Now;

            Console.WriteLine("\n--- DETALLE DE TRANSACCION ---");

            transaccion1.MostrarDetalle();
        }
    }
}
