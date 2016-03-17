using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPromedio
{
    class Promedio
    {
        //Definicion de los metodos get and set
        public String alumno { get; set; }
        public String curso { get; set; }
        public int LC1 { get; set; }
        public int LC2 { get; set; }
        public int LC3 { get; set; }
        public int LC4 { get; set; }
        public int LP { get; set; }
        public int EF { get; set; }
        public int NA { get; set; }

        //Definicion de los metodos propios
        public double calculaPromedio()
        {
            //Determinamos la nota menor
            int menor = calculaMenor(LC1, LC2, LC3, LC4);

           //Calculamos el promedio de las notas
           double promedio = ((LC1 + LC2 + LC3 + LC4 - menor) / 3) * 0.3 + 0.1 * NA + 0.2 * LP + 0.4 * EF;
            return promedio;
        }

        private int calculaMenor(int lC1, int lC2, int lC3, int lC4)
        {
            int menor = LC1;
            if (LC2 < menor) menor = LC2;
            if (LC3 < menor) menor = LC3;
            if (LC4 < menor) menor = LC4;

            return menor;
        }

        //Metodo que determina la condicion segun el promedio
        public String determinarCondicion()
        {
            if (calculaPromedio() > 12.5)
            {
                return "Aprobado";
            }
            else
            {
                return "Desaprobado";
            }
                
        }
    }
}
