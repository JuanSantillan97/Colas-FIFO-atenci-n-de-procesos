using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO_Atencion_de_procesos
{
    class Procesador
    {
        private Proceso inicio;

        public Procesador()
        {
            inicio = null;
        }
        
        //Agregar (PUSH).
        public void agregarPush(Proceso nuevoPro)
        {
            if(inicio == null)
            {
                inicio = nuevoPro;
            }
            else
            {
                Proceso temp = inicio;
                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevoPro;
            }
        }
        //Eliminar (POP).
        public Proceso eliminarPop()
        {
            Proceso temp = inicio;
            if(inicio == null)
            {
                return null;
            }
            else
            {
                inicio = inicio.siguiente;
                return temp;
            }
        }
        //Método para regresar el total de ciclos 
        //de los procesos en la cola.
        public int regresarTotalCiclos()
        {
            Proceso temp = inicio;
            int totalCiclos = 0;
            while(temp.siguiente != null)
            {
                totalCiclos += temp.ciclos;
                temp = temp.siguiente;
            }
            totalCiclos += temp.ciclos;
            return totalCiclos;
        }
        //Método que regresa el inicio o null.
        public Proceso regresarInicio()
        {
            return inicio;
        }

        public override string ToString()
        {
            Proceso temp = inicio;
            string cadena = "";
            while (temp.siguiente != null)
            {
                cadena += temp.ToString();
                temp = temp.siguiente;
            }
            cadena += temp.ToString();
            return cadena;
        }
    }
}
