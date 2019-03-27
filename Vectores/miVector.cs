using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class miVector
    {
        private int[] vec;

        public miVector(int tam)
        {
            vec = new int[tam];
        }


        public void Llenar(int inicio)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = inicio++;
                
            }
        }

        public string Mostrar()
        {
            string c = "";
            for (int i=0;i<vec.Length;i++)
            {
                c += "[" + i.ToString() + "] =" + vec[i] + Environment.NewLine;
            }
            return c;
        }

        public void GirarArriba()
        {
            int T;
            T = vec[vec.Length - 1];
            for (int i = vec.Length - 1; i >= 1; i--)
            {
                vec[i] = vec[i - 1];
            }
            vec[0] = T;
        }

        public void GirarAbajo()
        {
            int T;
            T = vec[0];
            for (int i = 0; i <= vec.Length - 2; i++)
            {
                vec[i] = vec[i + 1];
            }
            vec[vec.Length-1] = T;
        }

        /// <summary>
        /// Con el primer ciclo se crea un clon temporal del vector inicial, en el segundo ciclo al vector original le asignas el valor del vector clon en forma descendente (comenzando por el último índice)
        /// </summary>
        public void Invertir()
        {
            Array.Reverse(vec);
        }
    }
}
