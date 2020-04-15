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

        public void AgregarRepuesto(Repuesto r)
        {

        }
        public void QuitarRepuesto(int codigo)
        {

        }
        public void ModificarRepuesto(int codigo, double precioNuevo)
        {

        }
        public void AgregarStock(int codigo, int cantidadASumar)
        {

        }
        public void QuitarStock(int codigo, int cantidadAQuitar)
        {

        }
        public List<Repuesto> TraerPorCategoria(int codCategoria)
        {
            throw new NotImplementedException();
        }
    }
}
