using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class VentaRepuestos
    {
        private List<Repuesto> _listaProductos = new List<Repuesto>();
        private string _nombreComercio = "";
        private string _direccion = "";
        public VentaRepuestos(string nombre, string direccion)
        {
            this._nombreComercio = nombre;
            this._direccion = direccion;
        }
        public List<Repuesto> ListaProductos
        {
            get
            {
                return this._listaProductos;
            }
        }
        public string NombreComercio
        {
            set
            {
                this._nombreComercio = value.ToUpper();
            }
            get
            {
                return this._nombreComercio;
            }
        }
        public string Direccion
        {
            set
            {
                this._direccion = value.ToUpper();
            }
            get
            {
                return this._direccion;
            }
        }

        public void AgregarRepuesto(Repuesto rep)
        {
            foreach(Repuesto r in _listaProductos)
            {
                if (r.Codigo == rep.Codigo)
                {
                    throw new Exception("El repuesto ingresado ya existe.");
                }
            }
            _listaProductos.Add(rep);
        }
        public void QuitarRepuesto(int codigo)
        {
            bool existe = false;
            foreach (Repuesto r in _listaProductos)
            {
                if (r.Codigo == codigo)
                {
                    _listaProductos.Remove(r);
                    existe = true;
                }
            }
            if (!existe)
            {
                throw new Exception("El repuesto indicado no existe.");
            }
        }
        public void ModificarRepuesto(int codigo, double precioNuevo)
        {
            bool existe = false;
            foreach (Repuesto r in _listaProductos)
            {
                if (r.Codigo == codigo)
                {
                    r.Precio = precioNuevo;
                    existe = true;
                }
            }
            if (!existe)
            {
                throw new Exception("El repuesto indicado no existe.");
            }
        }
        public void AgregarStock(int codigo, int cantidadASumar)
        {
            foreach(Repuesto r in _listaProductos)
            {
                if (r.Codigo == codigo)
                {
                    r.Stock = r.Stock + cantidadASumar;
                }
            }
        }
        public void QuitarStock(int codigo, int cantidadAQuitar)
        {
            foreach (Repuesto r in _listaProductos)
            {
                if (r.Codigo == codigo)
                {
                    r.Stock = r.Stock - cantidadAQuitar;
                }
            }
        }
        public List<Repuesto> TraerPorCategoria(int codCategoria)
        {
            List<Repuesto> lista = new List<Repuesto>();
            foreach(Repuesto r in _listaProductos)
            {
                if (r.Categoria.Codigo == codCategoria)
                {
                    lista.Add(r);
                }
            }
            return lista;
        }
    }
}
