using Mayorista.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayorista.Datos
{
    internal class MayoristaDao
    {
        AccesoDatos db;
        public MayoristaDao()
        {
            db = new AccesoDatos();
        }

        internal bool CrearCliente(Cliente c)
        {
            string consulta = "insert into clientes (id_tipo_documento, nro_documento, nombre, apellido, email, telefono) values (@idTipoDocumento, @nroDocumento, @nombre, @apellido, @email, @telefono)";
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@idTipoDocumento", c.Id_tipo_documento.Id_tipo_documento));
            lista.Add(new Parametro("@nroDocumento", c.Nro_documento));
            lista.Add(new Parametro("@nombre", c.Nombre));
            lista.Add(new Parametro("@apellido", c.Apellido));
            lista.Add(new Parametro("@email", c.Email));
            lista.Add(new Parametro("@telefono", c.Telefono));

            return db.ActualizarBD(consulta, lista) > 0;
        }

        internal bool CrearDomicilio(DireccionCliente d)
        {
            string consulta = "insert into direcciones_clientes (id_cliente, id_barrio, direccion, codigo_postal) values (@idCliente, @idBarrio, @direccion, @codigoPostal)";
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@idCliente", d.Id_cliente));
            lista.Add(new Parametro("@idBarrio", d.Id_barrio.Id_barrio));
            lista.Add(new Parametro("@direccion", d.Direccion));
            lista.Add(new Parametro("@codigoPostal", d.Codigo_postal));

            return db.ActualizarBD(consulta, lista) > 0;
        }

        internal object RecuperarBarrios()
        {
            List<Barrio> listaBarrios = new List<Barrio>();

            DataTable dt = db.ConsultarTabla("barrios");
            foreach (DataRow dr in dt.Rows)
            {
                Barrio b = new Barrio();
                b.Id_barrio = (int)dr[0];
                b.Id_localidad = (int)dr[1];
                b.Nombre_barrio = (string)dr[2];

                listaBarrios.Add(b);
            }
            return listaBarrios;
        }

        internal List<Cliente> RecuperarClientes(string filtro)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            
            string consultaSQL = "select * from clientes c";

            if (!string.IsNullOrEmpty(filtro))
            {
                consultaSQL += " where c.nombre + ' ' + c.apellido like '%" + filtro + "%'";
            }
            DataTable tabla = db.ConsultarBD(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Cliente c = new Cliente();
                c.Id_cliente = (int)fila[0];
                c.Id_tipo_documento = new TipoDoc();
                c.Id_tipo_documento.Id_tipo_documento = (int)fila[1];
                c.Nro_documento = (string)fila[2];
                c.Nombre = (string)fila[3];
                c.Apellido = (string)fila[4];
                c.Email = (string)fila[5];
                c.Telefono = (string)fila[6];
                listaClientes.Add(c);
            }
            return listaClientes;
        }

        internal Cliente RecuperarClientePorId(int id)
        {
            Cliente c = null;

            string consultaSQL = "select * from clientes c where c.id_cliente = " + id;

            DataTable dt = db.ConsultarBD(consultaSQL);

            if(dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                c = new Cliente();
                c.Id_cliente = (int)dr[0];
                c.Id_tipo_documento = new TipoDoc();
                c.Id_tipo_documento.Id_tipo_documento = (int)dr[1];
                c.Nro_documento = (string)dr[2];
                c.Nombre = (string)dr[3];
                c.Apellido = (string)dr[4];
                c.Email = (string)dr[5];
                c.Telefono = (string)dr[6];
                
            }
            return c;
        }

        
        internal List<ClienteConsulta> RecuperarConsulta1()
        {
            List <ClienteConsulta> listaCliente1 = new List<ClienteConsulta>();
            string consultaSQL = "select nombre, apellido, sum(precio*cantidad), avg(precio*cantidad), sum(cantidad)" +
                "from clientes c join facturas f on c.id_cliente= f.id_cliente join detalles_facturas d on d.nro_factura = f.nro_factura " +
                "where apellido like '%ez' or nombre like '[d-m]%' " +
                "group by c.id_cliente, apellido, nombre " +
                "order by apellido, nombre";
            DataTable tabla = db.ConsultarBD(consultaSQL);
            foreach(DataRow fila in tabla.Rows)
            {
                ClienteConsulta oCliente1 = new ClienteConsulta();
                oCliente1.Nombre = (string)fila[0];
                oCliente1.Apellido = (string)fila[1];
                oCliente1.TotalCompras = (decimal)fila[2];
                oCliente1.PromedioCompras = (decimal)fila[3];
                oCliente1.CantidadCompras = (int)fila[4];
                listaCliente1.Add(oCliente1);
            }
            return listaCliente1;
        }

        internal List<FacturaConsulta> RecuperarConsulta2()
        {
            List <FacturaConsulta> listaFactura2 = new List<FacturaConsulta>();
            string cosultaSQL = "select top 10 f.nro_factura 'Factura', format(fecha_factura, 'dd/MM/yyyy') 'Fecha', sum(precio*cantidad) 'Importe', forma_pago 'Forma de pago'" +
                " from facturas f join detalles_facturas d on f.nro_factura = d.nro_factura join formas_pago fp on fp.id_forma_pago = f.id_forma_pago" +
                " where forma_pago in ('Efectivo', 'Transferencia') and fecha_factura >= '2019-02-03' and fecha_factura < '2019-10-09'" +
                " group by f.nro_factura, fecha_factura, forma_pago" +
                " order by 3 desc";
            DataTable tabla = db.ConsultarBD(cosultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                FacturaConsulta oFactura2 = new FacturaConsulta();
                oFactura2.NroFactura = (int)fila[0];
                oFactura2.FechaFactura = (string)fila[1];
                oFactura2.Importe = (decimal)fila[2];
                oFactura2.FormaPago = (string)fila[3];
                listaFactura2.Add(oFactura2);
            }
            return listaFactura2;
        }

        internal List<RubroConsulta> RecuperarConsulta3()
        {
            List<RubroConsulta> listaRubro3 = new List<RubroConsulta>();
            string consultaSQL = "select rubro 'Rubro', sum(cantidad) 'Cantidad de articulos vendidos', sum(d.precio*cantidad) 'Importe total facturado' " +
                "from rubros r join productos p on r.id_rubro = p.id_rubro join detalles_facturas d on p.id_producto = d.id_producto join facturas f on f.nro_factura = d.nro_factura " +
                "where year(fecha_factura) = 2023 and month(fecha_factura) between 1 and 6 " +
                "group by rubro " +
                "order by 3 desc";
            DataTable tabla = db.ConsultarBD(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                RubroConsulta oRubro3 = new RubroConsulta();
                oRubro3.Rubro = (string)fila[0];
                oRubro3.CantidadArticulosVendidos = (int)fila[1];
                oRubro3.ImporteTotalFacturado = (decimal)fila[2];
                listaRubro3.Add(oRubro3);
            }
            return listaRubro3;
        }

        internal List<ClienteConsulta> RecuperarConsulta4()
        {
            List<ClienteConsulta> listaCliente4 = new List<ClienteConsulta>();
            string consultaSQL = "select nombre + ' ' + apellido 'Cliente', barrio 'Barrio', count(distinct f.nro_factura) 'Cantidad de facturas', sum(precio*cantidad) 'Importe total facturado' " +
                "from clientes c join facturas f on c.id_cliente = f.id_cliente join detalles_facturas d on f.nro_factura = d.nro_factura join direcciones_clientes dc on f.id_direccion_cliente = dc.id_direccion_cliente join barrios b on dc.id_barrio = b.id_barrio join formas_entrega fe on f.id_forma_entrega = fe.id_forma_entrega " +
                "where forma_entrega = 'Envio a domicilio' and year(fecha_factura) not in (2019, 2020) " +
                "group by c.id_cliente, nombre, apellido, b.barrio " +
                "order by apellido, nombre";
            DataTable tabla = db.ConsultarBD(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                ClienteConsulta oCliente4 = new ClienteConsulta();
                oCliente4.Nombre = (string)fila[0];
                oCliente4.Barrio = (string)fila[1];
                oCliente4.CantidadCompras = (int)fila[2];
                oCliente4.TotalCompras = (decimal)fila[3];
                listaCliente4.Add(oCliente4);
            }
            return listaCliente4;
        }

        internal List<DireccionCliente> RecuperarDomicilios(int id)
        {
            List<DireccionCliente> listaDomicilios = new List<DireccionCliente>();
            string consultaSQL = "select * from direcciones_clientes where id_cliente = " + id;
            
            DataTable tabla = db.ConsultarBD(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                DireccionCliente oDomicilio = new DireccionCliente();
                oDomicilio.Id_direccion_cliente = (int)fila[0];
                oDomicilio.Id_cliente = (int)fila[1];
                oDomicilio.Id_barrio = new Barrio();
                oDomicilio.Id_barrio.Id_barrio = (int)fila[2];
                oDomicilio.Direccion = (string)fila[3];
                oDomicilio.Codigo_postal = (string)fila[4];
                listaDomicilios.Add(oDomicilio);
            }
            return listaDomicilios;
        }

        internal object RecuperarTiposDoc()
        {
            List<TipoDoc> listaTiposDoc = new List<TipoDoc>();

            DataTable dt = db.ConsultarTabla("tipos_documentos");
            foreach (DataRow dr in dt.Rows)
            {
                TipoDoc t = new TipoDoc();
                t.Id_tipo_documento = (int)dr[0];
                t.Tipo_documento = (string)dr[1];

                listaTiposDoc.Add(t);
            }
            return listaTiposDoc;
        }
    }
}
