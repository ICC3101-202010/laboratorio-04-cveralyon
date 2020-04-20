using System;
using System.Linq;
using System.Text;
namespace lab04
{
    public class Recepcionista : Maquina, IBasico
    {
        int countt = 0;

        public void Encendido()
        {
            On();
        }
        private static void On()
        {
            Console.WriteLine("||> Recepcionista: Encendido <||");
        }
        public void Apagado()
        {
            
            Off();
            est = false;
        }
        private static void Off()
        {  
            Console.WriteLine("||> Recepcionista: Apagado <||");
        }

        public bool Estado()
        {
            return sat;
        }

        public void Memoria()
        {
            countt += 1;
            if (countt >=9)
            {
                sat = true;
                Console.WriteLine("\n|||||>> RECEPCIONISTA:  Memoria Llena <<|||||");
            }   
        }
        public void Reinicio()
        {
            countt = 0;
            sat = false;
            Console.WriteLine("Recepcionista: Reiniciada, Memoria ok...\n");
            
        }
    }
}
