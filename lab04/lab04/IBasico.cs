using System;
using System.Linq;
using System.Text;

namespace lab04
{
    public interface IBasico
    {
        void Encendido();
        void Apagado();
        bool Estado();
        void Memoria();
        void Reinicio();
    }
}
