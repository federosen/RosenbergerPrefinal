using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramacion2023.Entidades
{
    public class Cuadrilateros
    {
        public int ladoA { get; set; }
        public int ladoB { get; set; }

        public int Relleno { get; set; }

        public string Borde { get; set; }

  
        public int GetPerimetro()
        {
            return 2 * ladoA + ladoB;
        }

        public int GetArea()
        {
            return ladoA + ladoB;
        }
        public string GetRelleno(int relleno)
        {
            int valor = relleno;
            if (valor==0)
            {
                return "Rojo";
            }
            if (valor == 1)
            {
                return "Azul";
            }
            if (valor == 2)
            {
                return "Verde";
            }
            return "error";

        }


        public bool Validar()
        {
            return ladoA > 0 && ladoB > 0 && ladoA < ladoB;
        }


        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Cuadrilateros))
            {
                return false;
            }

            return this.ladoA == ((Cuadrilateros)obj).ladoA &&
                   this.ladoB == ((Cuadrilateros)obj).ladoB;
        }


        public override int GetHashCode()
        {
            return (ladoA + ladoB).GetHashCode();
        }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
