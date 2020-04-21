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
                Console.WriteLine("Todo en orden, procesando Objetos");
            }   
        }

        public void Estado_memoria_Manual()
        {
            recep.Memoria();
            if (recep.Estado() == true)
            {
                Console.WriteLine("La memoria de la maquina RECEPCIONISTA esta llena, debe reiniciarla para poder continuar la linea de proceso");
                Console.WriteLine("Oprima enter para ir a las opciones de reinicio de maquinas...");
                Console.ReadLine();
                Console.WriteLine("Que maquina desea reniciar:\n" +
                    "1 ==> RECEPCIONISTA\n" +
                    "2 ==> ALMACENADOR\n" +
                    "3 ==> ENSAMBLADOR\n" +
                    "4 ==> VERIFICADOR\n" +
                    "5 ==> EMPACADOR\n");
                int ma;
                ma = int.Parse(Console.ReadLine());
                switch (ma)
                {
                    case 1:
                        recep.Reinicio();
                        break;
                    case 2:
                        alm.Reinicio();
                        break;
                    case 3:
                        ens.Reinicio();
                        break;
                    case 4:
                        ver.Reinicio();
                        break;
                    case 5:
                        emp.Reinicio();
                        break;
                    default:
                        Console.WriteLine("ERROR DE INGRESO, EL REINICIO SE HARA AUTOMATICAMENTE");
                        recep.Reinicio();
                        break;
                }
            }
            alm.Memoria();
            if (alm.Estado() == true)
            {
                Console.WriteLine("La memoria de la maquina ALMACENADORA esta llena, debe reiniciarla para poder continuar la linea de proceso");
                Console.WriteLine("Oprima enter para ir a las opciones de reinicio de maquinas...");
                Console.ReadLine();
                Console.WriteLine("Que maquina desea reniciar:\n" +
                    "1 ==> RECEPCIONISTA\n" +
                    "2 ==> ALMACENADOR\n" +
                    "3 ==> ENSAMBLADOR\n" +
                    "4 ==> VERIFICADOR\n" +
                    "5 ==> EMPACADOR\n");
                int ma;
                ma = int.Parse(Console.ReadLine());
                switch (ma)
                {
                    case 1:
                        recep.Reinicio();
                        break;
                    case 2:
                        alm.Reinicio();
                        break;
                    case 3:
                        ens.Reinicio();
                        break;
                    case 4:
                        ver.Reinicio();
                        break;
                    case 5:
                        emp.Reinicio();
                        break;
                    default:
                        Console.WriteLine("ERROR DE INGRESO, EL REINICIO SE HARA AUTOMATICAMENTE");
                        alm.Reinicio();
                        break;
                }
            }
            ens.Memoria();
            if (ens.Estado() == true)
            {
                Console.WriteLine("La memoria de la maquina ENSAMBLADORA esta llena, debe reiniciarla para poder continuar la linea de proceso");
                Console.WriteLine("Oprima enter para ir a las opciones de reinicio de maquinas...");
                Console.ReadLine();
                Console.WriteLine("Que maquina desea reniciar:\n" +
                    "1 ==> RECEPCIONISTA\n" +
                    "2 ==> ALMACENADOR\n" +
                    "3 ==> ENSAMBLADOR\n" +
                    "4 ==> VERIFICADOR\n" +
                    "5 ==> EMPACADOR\n");
                int ma;
                ma = int.Parse(Console.ReadLine());
                switch (ma)
                {
                    case 1:
                        recep.Reinicio();
                        break;
                    case 2:
                        alm.Reinicio();
                        break;
                    case 3:
                        ens.Reinicio();
                        break;
                    case 4:
                        ver.Reinicio();
                        break;
                    case 5:
                        emp.Reinicio();
                        break;
                    default:
                        Console.WriteLine("ERROR DE INGRESO, EL REINICIO SE HARA AUTOMATICAMENTE");
                        ens.Reinicio();
                        break;
                }
            }
            ver.Memoria();
            if (ver.Estado() == true)
            {
                Console.WriteLine("La memoria de la maquina recepcionista esta llena, debe reiniciarla para poder continuar la linea de proceso");
                Console.WriteLine("Oprima enter para ir a las opciones de reinicio de maquinas...");
                Console.ReadLine();
                Console.WriteLine("Que maquina desea reniciar:\n" +
                    "1 ==> RECEPCIONISTA\n" +
                    "2 ==> ALMACENADOR\n" +
                    "3 ==> ENSAMBLADOR\n" +
                    "4 ==> VERIFICADOR\n" +
                    "5 ==> EMPACADOR\n");
                int ma;
                ma = int.Parse(Console.ReadLine());
                switch (ma)
                {
                    case 1:
                        recep.Reinicio();
                        break;
                    case 2:
                        alm.Reinicio();
                        break;
                    case 3:
                        ens.Reinicio();
                        break;
                    case 4:
                        ver.Reinicio();
                        break;
                    case 5:
                        emp.Reinicio();
                        break;
                    default:
                        Console.WriteLine("ERROR DE INGRESO, EL REINICIO SE HARA AUTOMATICAMENTE");
                        ver.Reinicio();
                        break;
                }
            }
            emp.Memoria();
            if (emp.Estado() == true)
            {
                Console.WriteLine("La memoria de la maquina recepcionista esta llena, debe reiniciarla para poder continuar la linea de proceso");
                Console.WriteLine("Oprima enter para ir a las opciones de reinicio de maquinas...");
                Console.ReadLine();
                Console.WriteLine("Que maquina desea reniciar:\n" +
                    "1 ==> RECEPCIONISTA\n" +
                    "2 ==> ALMACENADOR\n" +
                    "3 ==> ENSAMBLADOR\n" +
                    "4 ==> VERIFICADOR\n" +
                    "5 ==> EMPACADOR\n");
                int ma;
                ma = int.Parse(Console.ReadLine());
                switch (ma)
                {
                    case 1:
                        recep.Reinicio();
                        break;
                    case 2:
                        alm.Reinicio();
                        break;
                    case 3:
                        ens.Reinicio();
                        break;
                    case 4:
                        ver.Reinicio();
                        break;
                    case 5:
                        emp.Reinicio();
                        break;
                    default:
                        Console.WriteLine("ERROR DE INGRESO, EL REINICIO SE HARA AUTOMATICAMENTE");
                        emp.Reinicio();
                        break;
                }
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
