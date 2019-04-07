using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superioratr
{
    class Complejo
    {
        public double parteReal;
        public double parteImaginaria;
        public double modulo;
        public double angulo;

        public Complejo(string texto)
        {
            if (TextoBonomico(texto))
            {
                parteReal = ObtenerParteReal(texto);
                parteImaginaria = ObtenerParteImaginaria(texto);
                modulo = ModuloBinomico();
                angulo = AnguloBinomico();
            }
            else if (TextoPolar(texto))
            {
                modulo = ObtenerModulo(texto);
                angulo = ObtenerAngulo(texto);
                parteReal = ParteRealPolar();
                parteImaginaria = ParteImaginariaPolar();
            }
            else
            {
                //error
            }
        }

        public bool TextoBonomico(string texto)
        {
            if (texto.Substring(0, 1) == "(" && texto.Substring(texto.Length - 2, 1) == ")")
            {
                string[] partes;
                texto.Remove(0, 1);
                texto.Remove(texto.Length - 2, 1);
                if (texto.Contains(','))
                {
                    partes = texto.Split(',');

                    if (partes.Length == 2 && double.TryParse(partes[0], out double d) && double.TryParse(partes[1], out double e))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool TextoPolar(string texto)
        {
            if (texto.Substring(0, 1) == "[" && texto.Substring(texto.Length - 2, 1) == "]")
            {
                string[] partes;
                texto.Remove(0, 1);
                texto.Remove(texto.Length - 2, 1);
                if (texto.Contains(';'))
                {
                    partes = texto.Split(';');

                    if (partes.Length == 2 && double.TryParse(partes[0], out double d) && double.TryParse(partes[1], out double e))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public double ObtenerParteReal(string texto)
        {
            string[] partes;
            texto.Remove(0, 1);
            texto.Remove(texto.Length - 2, 1);
            partes = texto.Split(',');
            return Convert.ToDouble(partes[0]);
        }
        public double ObtenerParteImaginaria(string texto)
        {
            string[] partes;
            texto.Remove(0, 1);
            texto.Remove(texto.Length - 2, 1);
            partes = texto.Split(';');
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
            string[] partes;
            texto.Remove(0, 1);
            texto.Remove(texto.Length - 2, 1);
            partes = texto.Split(';');
            return Convert.ToDouble(partes[0]);
        }
        public double ObtenerAngulo(string texto)
        {
            string[] partes;
            texto.Remove(0, 1);
            texto.Remove(texto.Length - 2, 1);
            partes = texto.Split(';');
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
