using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Categoria
    {
        private int _codigo = 0;
        private string _nombre = "";
        public int Codigo
        {
            set
            {
                this._codigo = value;
            }
            get
            {
                return this._codigo;
            }
        }
        public string Nombre
        {
            set
            {
                this._nombre = value.ToUpper();
            }
            get
            {
                return this._nombre;
            }
        }
    }
}
