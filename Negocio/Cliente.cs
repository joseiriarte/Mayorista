using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    public class Cliente
    {
        private int id_cliente;
        private TipoDoc id_tipo_documento;
        private string nro_documento;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        public TipoDoc Id_tipo_documento
        {
            get { return id_tipo_documento; }
            set { id_tipo_documento = value; }
        }

        public string Nro_documento
        {
            get { return nro_documento; }
            set { nro_documento = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return  apellido; }
            set { apellido = value;}
        }

        public string Email
        {
            get { return email;}
            set { email = value;}
        }
        
        public string Telefono
        {
            get { return telefono;}
            set { telefono = value;}
        }
    }
}
