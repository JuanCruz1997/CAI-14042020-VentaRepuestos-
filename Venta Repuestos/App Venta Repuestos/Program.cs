using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace App_Venta_Repuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarActivo = true;
            string menu= "1) Listar repuestos por categoría\n2) Agregar repuestos \n3) Quitar repuesto\n4) Modificar repuesto\n5) Agregar stock\n6) Quitar stock\n7) Limpiar Consola\nX) Salir";
            VentaRepuestos appVenta = new VentaRepuestos("Automotores Juancito", "Larroque 413");
            Console.WriteLine("Bienvenido a " + appVenta.NombreComercio);
            do
            {
                Console.WriteLine(menu);
                try
                {
                    string opcionSeleccionada = Console.ReadLine();
                    if (ConsolaHelper.EsOpcionValida(opcionSeleccionada, "1234567X"))
                    {
                        if (opcionSeleccionada.ToUpper() == "X")
                        {
                            continuarActivo = false;
                            continue;
                        }
                        switch (opcionSeleccionada)
                        {
                            case "1":
                                Program.ListarPorCategoria(appVenta);
                                break;
                            case "2":
                                Program.AgregarRepuesto(appVenta);
                                break;
                            case "3":
                                Program.QuitarRepuesto(appVenta);
                                break;
                            case "4":
                                Program.ModificarRepuesto(appVenta);
                                break;
                            case "5":
                                Program.AgregarStock(appVenta);
                                break;
                            case "6":
                                Program.QuitarStock(appVenta);
                                break;
                            case "7":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida.");
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine("Error durante la ejecución del comando. Por favor, intente nuevamente. Mensaje: " + ex.Message);
                }
                Console.WriteLine("Ingrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            } while (continuarActivo);
            Console.WriteLine("Gracias por utilizar nuestros servicios. Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
        #region
        private static void ListarPorCategoria(VentaRepuestos venta)
        {
            try
            {
                int categoria = ConsolaHelper.PedirInt("Código de categoría");
                List<Repuesto> lista = venta.TraerPorCategoria(categoria);
                foreach (Repuesto r in lista)
                {
                    Console.WriteLine(r.ToString());
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente.");
            }
        }
        private static void ListarRepuestos(VentaRepuestos venta)
        {
            List<Repuesto> lista = venta.ListaProductos;
            foreach (Repuesto r in lista)
            {
                Console.WriteLine(r.ToString());
            }
        }
        private static void AgregarRepuesto(VentaRepuestos venta)
        {
            try
            {
                int cod = ConsolaHelper.PedirInt("Código de repuesto.");
                string n = ConsolaHelper.PedirString("Nombre de repuesto.");
                double p = ConsolaHelper.PedirDouble("Precio.");
                int s = ConsolaHelper.PedirInt("Stock.");
                int codCat = ConsolaHelper.PedirInt("Elija categoría:\n" + venta.GetCategorias.ToString());
                Repuesto nuevoRepuesto = new Repuesto(cod, n, p, s);
                venta.AgregarRepuesto(nuevoRepuesto, codCat);
                Console.WriteLine("Se ha agregado el repuesto.");
            }catch(Exception ex)
            {
                Console.WriteLine("Error en uno de los datos ingresados: " + ex.Message + " Intente nuevamente.");
                AgregarRepuesto(venta);
            }
        }
        private static void QuitarRepuesto(VentaRepuestos venta)
        {
            Program.ListarRepuestos(venta);
            Console.WriteLine("Seleccione un código de repuesto para eliminar:");
            try
            {
                int c = ConsolaHelper.PedirInt("Código");
                venta.QuitarRepuesto(c);
                Console.WriteLine("El repuesto ha sido eliminado.");
            }catch(Exception ex)
            {
                Console.WriteLine("No es posible eliminar el repuesto seleccionado: " + ex.Message);
            }
        }
        private static void ModificarRepuesto(VentaRepuestos venta)
        {
            Program.ListarRepuestos(venta);
            Console.WriteLine("Seleccione el código de repuesto que va a modificar:");
            try
            {
                int c = ConsolaHelper.PedirInt("Código");
                double p = ConsolaHelper.PedirDouble("Precio nuevo");
                venta.ModificarRepuesto(c,p);
                Console.WriteLine("El repuesto ha sido modificado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No es posible modificar el repuesto seleccionado: " + ex.Message);
            }
        }
        private static void AgregarStock(VentaRepuestos venta)
        {
            Program.ListarRepuestos(venta);
            Console.WriteLine("Seleccione el código de repuesto que va a al que se le va a añadir stock:");
            try
            {
                int c = ConsolaHelper.PedirInt("Código");
                int p = ConsolaHelper.PedirInt("Stock a agregar");
                venta.AgregarStock(c, p);
                Console.WriteLine("Se ha agregado stock.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No es posible realizar la operación solicitada: " + ex.Message);
            }
        }
        private static void QuitarStock(VentaRepuestos venta)
        {
            Program.ListarRepuestos(venta);
            Console.WriteLine("Seleccione el código de repuesto que va a al que se le va a quitar stock:");
            try
            {
                int c = ConsolaHelper.PedirInt("Código");
                int p = ConsolaHelper.PedirInt("Stock a quitar");
                venta.QuitarStock(c, p);
                Console.WriteLine("Se ha quitado stock.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No es posible realizar la operación solicitada: " + ex.Message);
            }
        }
    }
        #endregion
}

