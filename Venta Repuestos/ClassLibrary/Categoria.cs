using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;
        private List<Categoria> _categorias;
        public Categoria(int codigo, string nombre)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._categorias = new List<Categoria>();
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
        public List<Categoria> GetCategorias
        {
            get
            {
                return this._categorias;
            }
        }
    }
}
