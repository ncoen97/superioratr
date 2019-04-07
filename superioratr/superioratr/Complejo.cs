using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace superioratr
{
    class Complejo
    {
        public double parteReal;
        public double parteImaginaria;
        public double modulo;
        public double angulo;
        public string tipoOriginal;

        public Complejo(string texto)
        {
            if (TextoBinomico(texto))
            {
                parteReal = ObtenerParteReal(texto);
                parteImaginaria = ObtenerParteImaginaria(texto);
                modulo = ModuloBinomico();
                angulo = AnguloBinomico();
                tipoOriginal = "Binomial";
            }
            else if (TextoPolar(texto))
            {
                modulo = ObtenerModulo(texto);
                angulo = ObtenerAngulo(texto);
                parteReal = ParteRealPolar();
                parteImaginaria = ParteImaginariaPolar();
                tipoOriginal = "Polar";
            }
            else
            {
                tipoOriginal = "No es un complejo";
            }

            CorregirAngulo();

        }

        public bool TextoBinomico(string texto)
        {
            if (texto.Substring(0, 1) == "(" && texto.Substring(texto.Length - 1, 1) == ")")
            {

                string[] partes = LimpiarEntrada(texto);

                if (texto.Contains(','))
                {
                
                    bool isNum1 = Double.TryParse(Convert.ToString(partes[0]), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out double e);
                    bool isNum2 = Double.TryParse(Convert.ToString(partes[1]), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out double e2);
                    if (partes.Length == 2 && isNum1 && isNum2) { 
                        return true;
                    }
                }
            }
            return false;
        }
        public bool TextoPolar(string texto)
        {
            if (texto.Substring(0, 1) == "[" && texto.Substring(texto.Length - 1, 1) == "]")
            {
                string[] partes = LimpiarEntrada(texto);

                if (texto.Contains(';'))
                {

                    bool isNum1 = Double.TryParse(Convert.ToString(partes[0]), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out double e);
                    bool isNum2 = Double.TryParse(Convert.ToString(partes[1]), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out double e2);
                    if (partes.Length == 2 && isNum1 && isNum2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        void CorregirAngulo( )
        {
            if (parteImaginaria > 0 && parteReal > 0) //Primer cuadrante
            {
                return;

            }
            else if (parteImaginaria < 0 && parteReal > 0 && angulo <0)  //Cuarto cuadrante
            {
                angulo += Math.PI/2;

            }

            else if (parteImaginaria > 0 && parteReal < 0 || parteImaginaria < 0 && parteReal < 0)  //Segundo o tercer cuadrante 
            {
                angulo += Math.PI;



            }
        }

            public string MostrarTransformado(Complejo complejo)
        {
            string s = "0";

            if (complejo.tipoOriginal == "Binomial")
            {
              
                s = ("["+complejo.modulo.ToString()+";"+complejo.angulo.ToString() + "]");
                return s;

            } else if (complejo.tipoOriginal == "Polar")
            {
               
                s = ("(" + complejo.parteReal.ToString() + "," + complejo.parteImaginaria.ToString() + ")");
                return s;

            }

            return s;


        }


        public bool SonTodosNumeros(char[] texto)
        {
            foreach (char c in texto)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;

        }

        public string[] LimpiarEntrada(string entrada)
        {
            string[] partes;
            entrada = entrada.Replace("(", "");
            entrada = entrada.Replace(")", "");

            entrada = entrada.Replace("[", "");
            entrada = entrada.Replace("]", "");

            if (entrada.Contains(';'))
            {
                partes = entrada.Split(';');
            }
            else
            //if (entrada.Contains(','))
            {
                partes = entrada.Split(',');
            }
                 //else default error     
          
            return partes;
        }
        public double ObtenerParteReal(string texto)
        {
            string[] partes = LimpiarEntrada(texto);

            return Convert.ToDouble(partes[0]);
        }
        public double ObtenerParteImaginaria(string texto)
        {
            string[] partes = LimpiarEntrada(texto);

            return Convert.ToDouble(partes[1]);
        }
        public double ModuloBinomico()
        {
            return Math.Sqrt(Math.Pow(parteReal, 2) + Math.Pow(parteImaginaria, 2));
        }
        public double AnguloBinomico()
        {
            if (parteReal != 0)
            {
                return Math.Atan(parteImaginaria / parteReal);
            }
            else
            {
                if (parteImaginaria > 0)
                {
                    return Math.PI / 2;
                }
                else return Math.PI * 3 / 2;
            }
        }
        public double ObtenerModulo(string texto)
        {
            string[] partes = LimpiarEntrada(texto);


            return Convert.ToDouble(partes[0]);
        }
        public double ObtenerAngulo(string texto)
        {
            string[] partes = LimpiarEntrada(texto);

            return Convert.ToDouble(partes[1]);
        }
        public double ParteRealPolar()
        {
            return Math.Abs(modulo) * Math.Cos(angulo);
        }
        public double ParteImaginariaPolar()
        {
            return Math.Abs(modulo) * Math.Sin(angulo);
        }
    }
}
