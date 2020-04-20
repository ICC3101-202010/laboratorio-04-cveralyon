using System;
using System.Linq;
using System.Text;

namespace lab04
{
    class MainClass : ComputadorCentral 
    {
        public static void Main(string[] args)
        {
            ComputadorCentral cc = new ComputadorCentral();

            int dia = 0;
            Console.WriteLine("\n\t\t>>>>>||| COMIENZA EL DIA |||<<<<<\n");
            cc.Encender_cc();
            cc.Encender_maquinas();



            while (dia < 25)
            {
                cc.Estado_memoria();
                dia += 1;
            }
            Console.WriteLine("\n\t\t>>>>>||| FINALIZANDO EL DIA |||<<<<<\n");
            cc.Apagar_maquinas();
            cc.Apagar_cc();

        }
    }
}
