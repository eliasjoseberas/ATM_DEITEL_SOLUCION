using System;


namespace ATM_DEITEL
{
    public class Transaccion
    {
        public string Tipo { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public void MostrarDetalle()
        {
            Console.WriteLine("Tipo de transaccion: " + Tipo);
            Console.WriteLine("Monto: RD$" + Monto);
            Console.WriteLine("Fecha: " + Fecha);
        }
    }
}
