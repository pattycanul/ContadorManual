using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorManual.Desktop.Model
{
    public class Contador
    {
        private int _Conteo;
        public int conteoInicial;
        public int Contar;
        public int Reiniciar;

        //private int myVar;

        public int Conteo
        {
            get => _Conteo;
            set 
            {
                if (_Conteo.Equals(value) == false)
                {
                    _Conteo = value;
                }
            }
        }

        public Contador()
        {
            conteoInicial = 0;
            Contar = _Conteo;
            Reiniciar = 0;
        }
    }
}
