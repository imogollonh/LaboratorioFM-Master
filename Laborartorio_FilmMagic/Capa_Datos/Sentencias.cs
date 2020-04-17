using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Datos
{
    public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;

        //--------------------------------------------------------------------OBTENER COD SIGUIENTE--------------------------------------------------------------------//
        public string obtenerfinal(string tabla, string campo)
        {
            String camporesultante = "";
            try
            {
                string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                OdbcCommand command = new OdbcCommand(sql, cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();

                if (String.IsNullOrEmpty(camporesultante))
                    camporesultante = "1";
            }
            catch (Exception)
            {
                Console.WriteLine(camporesultante);
            }
            return camporesultante;
        }

        //---------------------------------------------------------------UPDATE TIPO DE PRODUCTO-----------------------------------------------------------------------------------------//

        public OdbcDataReader modificarTipo(string sCodigo, string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE tipo_producto set nombre='" + sNombre + "' where pkidtipoproducto = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------INSERT TIPO DE PRODUCTO------------------------------------------------------------------------------------------//
        public OdbcDataReader insertarTipo(string sCodigo, string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into tipo_producto values(" + sCodigo + ", '" + sNombre + "' ," + "1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------ELIMINAR TIPO DE PRODUCTO-----------------------------------------------------------------------------------------//

        public OdbcDataReader eliminarTipo(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE tipo_producto set estado='0' where pkidtipoproducto ='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------CONSULTA TIPO CATEGORIA------------------------------------------------------------------------------------------//

        public OdbcDataReader consultaTipo()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM tipo_producto WHERE estado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        /*categoria*/

        //---------------------------------------------------------------UPDATE TIPO DE CATEGORIA----------------------------------------------------------------------------------------//

        public OdbcDataReader modificarCategoria(string sCodigo, string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE categoria set nombre='" + sNombre + "' where pkidcategoria = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------INSERT TIPO DE CATEGORIA------------------------------------------------------------------------------------------//
        public OdbcDataReader insertarCategoria(string sCodigo, string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into categoria values(" + sCodigo + ", '" + sNombre + "' ," + "1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------ELIMINAR TIPO DE CATEGORIA-----------------------------------------------------------------------------------------//

        public OdbcDataReader eliminarCategoria(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE categoria set estado='0' where pkidcategoria ='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------CONSULTA CATEGORIA------------------------------------------------------------------------------------------//

        public OdbcDataReader consultaCategoria()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM categoria WHERE estado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }


        /*AUTOR*/

        //---------------------------------------------------------------UPDATE TIPO DE AUTOR----------------------------------------------------------------------------------------//

        public OdbcDataReader modificarAutor(string sCodigo, string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE autor set nombre='" + sNombre + "' where pkidautor = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------INSERT TIPO DE AUTOR-----------------------------------------------------------------------------------------//
        public OdbcDataReader insertarAutor(string sCodigo, string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into autor values(" + sCodigo + ", '" + sNombre + "' ," + "1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------ELIMINAR TIPO DE AUTOR-----------------------------------------------------------------------------------------//

        public OdbcDataReader eliminarAutor(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE autor set estado='0' where pkidautor ='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------CONSULTA AUTOR------------------------------------------------------------------------------------------//

        public OdbcDataReader consultaAutor()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM autor WHERE estado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        /*conceptos*/

        //---------------------------------------------------------------INSERTAR CONCEPTO------------------------------------------------------------------------------------------//

        public OdbcDataReader InsertarConceptos(string sCodigo, string sNombre, string sDescripcion, string sValor, string sTipoOp)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into conceptos values(" + sCodigo + ", '" + sNombre + "' ,'" + sDescripcion + "'," + sValor + "," + sTipoOp + ",1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }


        //---------------------------------------------------------------MODIFICAR CONCEPTO------------------------------------------------------------------------------------------//

        public OdbcDataReader modificarConceptos(string sCodigo, string sNombre, string sDescripcion, string sValor, string sTipoOp)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE conceptos set nombre='" + sNombre + "', descripcion='" + sDescripcion + "'" + ", valor = " + sValor + ", tipo_operacion= " + sTipoOp + " where pkidconcepto = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------ELIMINAR CONCEPTO ------------------------------------------------------------------------------------------//

        public OdbcDataReader eliminarConceptos(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE conceptos set estado='0' where pkidconcepto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------CONSULTA CONCEPTO------------------------------------------------------------------------------------------//
        public OdbcDataReader consultaConcepto()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM conceptos WHERE estado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        /*MEMBRESIA*/
        //---------------------------------------------------------------INSERTAR MEMBRESIA------------------------------------------------------------------------------------------//
        public OdbcDataReader InsertarMembresia(string sCodigo, string sNombre, string sFechaE, string sFechaV)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into membresia values(" + sCodigo + ", '" + sNombre + "' ,'" + sFechaE + "','" + sFechaV + "',1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }


        //---------------------------------------------------------------MODIFICAR MEMBRESIA-----------------------------------------------------------------------------------------//

        public OdbcDataReader modificarMembresia(string sCodigo, string sNombre, string sFechaE, string sFechaV)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE membresia set nombre='" + sNombre + "', fecha_emision='" + sFechaE + "'" + ", fecha_caducicad = '" + sFechaV + "' where pkidmembresia = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------ELIMINAR MEMBRESIA------------------------------------------------------------------------------------------//

        public OdbcDataReader eliminarMembresia(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE membresia set estado='0' where pkidmembresia='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------CONSULTA MEMBRESIA------------------------------------------------------------------------------------------//

        public OdbcDataReader consultaMembresia()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM Membresia WHERE estado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }
        /*CLIENTES*/
        //---------------------------------------------------------------INSERTAR CLIENTES------------------------------------------------------------------------------------------//

        public OdbcDataReader InsertarCliente(string sCodigo, string sNombre, string sDireccion, string telefono, string sCMembresia, string Fecha)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into cliente values(" + sCodigo + ", '" + sNombre + "' ,'" + sDireccion + "','" + telefono + "',1," + sCMembresia + ",'" + Fecha + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }


        //--------------------------------------------------------------MODIFICAR CLIENTES------------------------------------------------------------------------------------------//

        public OdbcDataReader modificarCliente(string sCodigo, string sNombre, string sDireccion, string telefono, string sCMembresia)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE clientes set nombre='" + sNombre + "', direccion='" + sDireccion + "'" + ", telefono = '" + telefono + "', fkidmembresia= " + sCMembresia + " where pkidcliente = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------ELIMINAR CLIENTES------------------------------------------------------------------------------------------//

        public OdbcDataReader eliminarCliente(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE cliente set estado='0' where pkidcliente='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------CONSULTA CLIENTE-----------------------------------------------------------------------------------------//

        public OdbcDataReader consultaCliente()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM cliente WHERE estado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }


        public OdbcDataReader consultarproveedor()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM proveedor;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }
        //-------------------------------------------------------------------------Formulario de proveedores----------------------------------------------------------
        public OdbcDataReader insertarproveedor(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into proveedor values(" + sCodigo + ", '" + sNombre + "' ,'" + sdireccion + "','" + stelefono + "','" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modficarproveedor(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE proveedor set nombre='" + sNombre + "',direccion='" + sdireccion + "',telefono='" + stelefono + "',estado='" + sestado + "' where pkidproveedor='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminarproveedor(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE proveedor set estado='0' where pkidproveedor='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //-------------------------------------------------------------------------Formulario de sucursal----------------------------------------------------------
        public OdbcDataReader consultasucursal()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM sucursal;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        public OdbcDataReader insertarsucursal(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into sucursal values(" + sCodigo + ", '" + sNombre + "' ,'" + sdireccion + "','" + stelefono + "','" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificarsucursal(string sCodigo, string sNombre, string sdireccion, string stelefono, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE sucursal set nombre='" + sNombre + "',direccion='" + sdireccion + "',telefono='" + stelefono + "',estado='" + sestado + "' where pkidsucursal='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminarsucursal(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE sucursal set estado='0' where pkidsucursal='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }


        //-------------------------------------------------------------------------Formulario de producto----------------------------------------------------------
        public OdbcDataReader consultaproducto()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM productos;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        public OdbcDataReader insertarproducto(string sCodigo, string sNombre, string dprecio, string idcategoria, string sestado, string idtipoprod, string idautor, string idproveedor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into productos values(" + sCodigo + ", '" + sNombre + "' ,'" + dprecio + "' ,'" + idcategoria + "' ,'" + sestado + "','" + idtipoprod + "','" + idautor + "','" + idproveedor + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificarproducto(string sCodigo, string sNombre, string dprecio, string idcategoria, string sestado, string idtipoprod, string idautor, string idproveedor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE productos set nombre='" + sNombre + "',precio='" + dprecio + "',fkidcategoria='" + idcategoria + "',estado='" + sestado + "',fkidtipoproducto='" + idtipoprod + "',fkidautor='" + idautor + "',fkidproveedor='" + idproveedor + "' where pkidproducto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminarproducto(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE productos set estado='0' where pkidproducto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }



    }
}
