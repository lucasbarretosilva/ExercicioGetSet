using System;

namespace ExercicioGetSet
{
    public class Data
    {
        private int mes;
        private bool mesvalido;
        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        { 
            if(mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesvalido = true;

            }
        
        }

        public void ApresentarMes()
        {
            if(this.mesvalido)
            {
                Console.WriteLine(this.mes);
            }
            else
            {
                Console.WriteLine("Mês inválido!");
            }
        }

    }
}



