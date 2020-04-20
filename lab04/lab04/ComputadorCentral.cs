using System;
using System.Linq;
using System.Text;

namespace lab04
{
    public class ComputadorCentral
    {
        Recepcionista recep = new Recepcionista();
        Almacenador alm = new Almacenador();
        Ensamblador ens = new Ensamblador();
        Verificador ver = new Verificador();
        Empacador emp = new Empacador();

       
        public void Encender_cc()
        {
            On();
        }
        private static void On()
        {
            Console.WriteLine("\t\t>>>>> Computador Central Encendido <<<<<\n\n");
        }


        public void Encender_maquinas()
        {
            Console.WriteLine("|| ENCENDIENDO MAQUINAS ||\n");
            recep.Encendido();
            alm.Encendido();
            ens.Encendido();
            ver.Encendido();
            emp.Encendido();
            Console.WriteLine("\n|| MAQUINAS ENCENDIDAS ||\n");
        }

        public void Estado_memoria() {
            recep.Memoria();
            if (recep.Estado() == true)
            {
                recep.Reinicio();
            }
            alm.Memoria();
            if (alm.Estado() == true)
            {
                alm.Reinicio();
            }
            ens.Memoria();
            if (ens.Estado() == true)
            {
                ens.Reinicio();
            }
            ver.Memoria();
            if (ver.Estado() == true)
            {
                ver.Reinicio();
            }
            emp.Memoria();
            if (emp.Estado() == true)
            {
                emp.Reinicio();
            }
            if (recep.Estado() == false & alm.Estado() == false & ens.Estado() == false & ver.Estado() == false & emp.Estado() == false)
            {
                Console.WriteLine("Todo en orden");
            }   
        }

        public void Apagar_maquinas()
        {
            Console.WriteLine("|| APAGANDO MAQUINAS ||\n");
            recep.Apagado();
            alm.Apagado();
            ens.Apagado();
            ver.Apagado();
            emp.Apagado();
            Console.WriteLine("\n|| MAQUINAS APAGADAS ||");
        }

        public void Apagar_cc()
        {
            Off();
        }
        private static void Off()
        {
            Console.WriteLine("\t\t>>>>> Computador Central Apagado <<<<<\n\n");
        }
    }
}
