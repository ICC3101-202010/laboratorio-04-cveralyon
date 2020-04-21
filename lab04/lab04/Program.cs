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
            int modo;
            Console.WriteLine("\n\t\t>>>>>||| COMIENZA EL DIA |||<<<<<\n");

            Console.WriteLine("En que modo desea inicial el computadro central:\n" +
                "1 --> Automatico \n" +
                "2 --> Manual\n");
            modo = int.Parse(Console.ReadLine());
            if (modo == 1)
            {
                cc.Encender_cc();
                cc.Encender_maquinas();

                while (dia < 30)
                {
                    cc.Estado_memoria();
                    dia += 1;
                }
                Console.WriteLine("\n\t\t>>>>>||| FINALIZANDO EL DIA |||<<<<<\n");
                cc.Apagar_maquinas();
                cc.Apagar_cc();
            }
            else if (modo == 2)
            {
                cc.Encender_cc();
                cc.Encender_maquinas();
                while (dia < 25)
                {
                    cc.Estado_memoria_Manual();
                    dia += 1;
                }
                Console.WriteLine("\n\t\t>>>>>||| FINALIZANDO EL DIA |||<<<<<\n");
                cc.Apagar_maquinas();
                cc.Apagar_cc();

            }
            else
            {
                Console.WriteLine("Error de inicio, intente iniciar el Computador Central nuevamente\n" +
                    "pero con un comando valido");
            }

        }
    }
}
