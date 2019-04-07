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

        public Complejo(double parametro1, double parametro2, string _tipoOriginal)
        {
            tipoOriginal = _tipoOriginal;
            if (tipoOriginal == "Binomial")
            {
                parteReal = parametro1;
                parteImaginaria = parametro2;
                modulo = ModuloBinomico();
                angulo = AnguloBinomico();
            }
            else
            {
                modulo = parametro1;
                angulo = parametro2;
                parteReal = ParteRealPolar();
                parteImaginaria = ParteImaginariaPolar();
            }
        }
        public Complejo(string texto)
        {
            if (TextoBinomico(texto))
            {
                parteReal = ObtenerParteReal(texto);
                parteImaginaria = ObtenerParteImaginaria(texto);
                modulo = ModuloBinomico();
                angulo = AnguloBinomico();
                tipoOriginal = "Binomial";
                CorregirAngulo();
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
                angulo += Math.Round(Math.PI * 2, 4);
            }

            else if (parteReal < 0)  //Segundo o tercer cuadrante 
            {
                angulo += Math.Round(Math.PI, 4);
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


        public bool SonTodosNumeros(char[] texto) //chequea que los valores sean numeros
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

        public string[] LimpiarEntrada(string entrada) //saca (), [], y separa las dos partes
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
            {
                partes = entrada.Split(',');
            }
          
            return partes;
        }
        public double ObtenerParteReal(string texto)
        {
            string[] partes = LimpiarEntrada(texto);

            return Convert.ToDouble(partes[0], new CultureInfo("en-US"));
        }
        public double ObtenerParteImaginaria(string texto)
        {
            string[] partes = LimpiarEntrada(texto);

            return Convert.ToDouble(partes[1], new CultureInfo("en-US"));
        }
        public double ModuloBinomico()
        {
            return Math.Round(Math.Sqrt(Math.Pow(parteReal, 2) + Math.Pow(parteImaginaria, 2)), 4);
        }
        public double AnguloBinomico()
        {
            if (parteReal != 0)
            {
                return Math.Round(Math.Atan(parteImaginaria / parteReal) , 4);
            }
            else
            {
                if (parteImaginaria > 0)
                {
                    return Math.Round(Math.PI / 2, 4);
                }
                else return Math.Round(Math.PI * 3 / 2, 4);
            }
        }
        public double ObtenerModulo(string texto)
        {
            string[] partes = LimpiarEntrada(texto);

            return Convert.ToDouble(partes[0], new CultureInfo("en-US"));
        }
        public double ObtenerAngulo(string texto)
        {
            string[] partes = LimpiarEntrada(texto);

            return Convert.ToDouble(partes[1], new CultureInfo("en-US"));
        }
        public double ParteRealPolar()
        {
            return Math.Round(Math.Abs(modulo) * Math.Cos(angulo), 4);
        }
        public double ParteImaginariaPolar()
        {
            return Math.Round(Math.Abs(modulo) * Math.Sin(angulo), 4);
        }
        public Complejo Suma(Complejo sumado)
        {
           return new Complejo(parteReal + sumado.parteReal, parteImaginaria + sumado.parteImaginaria, "Binomial");
        }
        public Complejo Resta(Complejo restado)
        {
            return new Complejo(parteReal - restado.parteReal, parteImaginaria + restado.parteImaginaria, "Binomial");
        }
        public Complejo Multiplicacion(Complejo multiplicado)
        {
            return new Complejo(Math.Round(modulo * multiplicado.modulo, 4), Math.Round((((angulo + multiplicado.angulo) / (2 * Math.PI)) -Math.Truncate((angulo + multiplicado.angulo) / (2 * Math.PI)))*2*Math.PI,4) , "Polar");//angulo perteneciente a {0,2pi}
        }
        public Complejo Cociente(Complejo divisor)
        {
            return new Complejo(Math.Round(modulo / divisor.modulo,4), Math.Round((((angulo - divisor.angulo + 2 * Math.PI)/ (2 * Math.PI))-Math.Truncate((angulo - divisor.angulo + 2 * Math.PI) / (2 * Math.PI))) * 2 * Math.PI,4), "Polar");//angulo perteneciente a {0,2pi}
        }
    }
}
