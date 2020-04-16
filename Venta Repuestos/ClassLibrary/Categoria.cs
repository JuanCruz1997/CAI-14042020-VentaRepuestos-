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
        public Categoria(int codigo, string nombre)
        {
            this._codigo = codigo;
            this._nombre = nombre;
        }
        public int Codigo
        {
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
