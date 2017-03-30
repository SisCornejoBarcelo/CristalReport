using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CrystalReport1.Modelo;


namespace CrystalReport1.controladores
{
    public class ControladorProductos
    {


        /// <summary>
        /// agrega datos al combo ordenandolos alfabeticamente ( te lo muestra al final de la lista)
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static List<String> ListaDepart(Boolean status)
        {
            List<String> deptos = new List<string>();

            try
            {
                using (var ctx = new DataModel())
                {
                    var lista = ctx.Productos.GroupBy(r => r.sDepartamento).ToList();
                        foreach(var item in lista)
                    {
                        deptos.Add(item.Key.ToString().ToUpper());
                    }
                    deptos.Add("TODOS");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return deptos;
        }

        public static List<Productos> getListado()
        {
           // List<String> lis = new List<string>();

            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Productos.Where(r => r.bStatus == true).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
          //  return lis;
        }
    }
}
