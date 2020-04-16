using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;
        public Repuesto(int codigo, string nombre, double precio, int stock, Categoria categoria)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._precio = precio;
            this._stock = stock;
            this._categoria = categoria;
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
        public double Precio
        {
            set
            {
                this._precio = value;
            }
            get
            {
                return this._precio;
            }
        }
        public int Stock
        {
            set
            {
                this._stock = value;
            }
            get
            {
                return this._stock;
            }
        }
        public Categoria Categoria
        {
            set
            {
                this._categoria = value;
            }
            get
            {
                return this._categoria;
            }
        }
        public override string ToString()
        {
            return "["+_codigo+"]" + _nombre;
        }
    }
}
