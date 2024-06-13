using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad1.Models
{
    public class Controlador
    {
        public int[] VecEnt = new int[1000];
        public int ContNum=0;

        public void IngresarValor(int valor)
        {
            VecEnt[ContNum] = valor;
            ContNum++;
        }
        public float CalcularPromedio ()
        {
            int suma = 0;
            if(ContNum !=0)
            {
                for (int i = 0; i < ContNum; i++) 
                {
                    suma += VecEnt[i];
                }
                return suma/ContNum;
            }
            else
            {
                return 0;
            }
            
        }
        // Vistas
        public int [] PromedioMayor( ref int contador)
        {
            int[] vector = new int[ContNum+1];
            float promedio = CalcularPromedio();


            for(int i = 0;i < ContNum; i++)
            {
                if (VecEnt[i] > promedio)
                {
                    vector[contador] = VecEnt[i];
                    contador++;
                }
            }
            return vector;

        }

    }
}
