using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12Ejercicio02Interfaces
{
    public class Empresa
    {
        public List<IPagable> Empleados {  get; set; }

        private List<IDeuda> Clientes = new List<IDeuda>();

        public void CalcularPagosEmpleados()
        {
            double total = 0;
            
            foreach (var empleado in Empleados)
            {    
                total = total + empleado.CalcularPago();
            }
            Console.WriteLine($"El total de sueldos es: {total}");
        }

        
        //public void CrearListaClientes()
        //{
        //    Clientes  = new List<IDeuda>();
        //}
        public void AgregarCliente(IDeuda cliente)
        {
            Clientes.Add(cliente);
        }

        public void CalcularDeudaTotal()
        {
            double deudaTotal = 0;
            foreach (var cliente in Clientes)
            {
                deudaTotal = deudaTotal + cliente.CalcularDeuda();
            }
            Console.WriteLine($"La deuda total es: {deudaTotal}");
        }
    }
}
