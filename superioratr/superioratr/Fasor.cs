using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superioratr
{
    class Fasor
    {
        public double amplitud;
        public double pulsacion;
        public string funcion;
        public double anguloFaseInicial;
        public Complejo complejoFinal = null;

        public Fasor(double amplitud, double pulsacion, string funcion, double anguloFaseInicial)
        {
            this.amplitud = amplitud;
            this.pulsacion = pulsacion;
            this.funcion = funcion;
            this.anguloFaseInicial = anguloFaseInicial;
        }

        public Complejo ComplejoFinal { get => complejoFinal; set => complejoFinal = value; }

        public void sumarFasores(Fasor fasor)
        {
            this.convertirACoseno(this);
            this.convertirACoseno(fasor);
            complejoFinal = new Complejo(this.sumarParteReal(fasor), this.sumarParteImaginaria(fasor), "Binomial");
            fasor.complejoFinal = this.complejoFinal;
        }

        private void convertirACoseno(Fasor fasor)
        {
            if(this.pulsacion == fasor.pulsacion)
            {
                if(fasor.funcion == "seno")
                {
                    fasor.anguloFaseInicial =- (Math.PI/2);
                    
                }

            }
        }

        private double sumarParteReal(Fasor fasor)
        {
            double primero = this.amplitud * Math.Cos(this.anguloFaseInicial);
            double segundo = fasor.amplitud * Math.Cos(this.anguloFaseInicial);
            return primero + segundo;
        }

        private double sumarParteImaginaria(Fasor fasor)
        {
            double primero = this.amplitud * Math.Sin(this.anguloFaseInicial);
            double segundo = fasor.amplitud * Math.Sin(this.anguloFaseInicial);
            return primero + segundo;
        }



    }
}
