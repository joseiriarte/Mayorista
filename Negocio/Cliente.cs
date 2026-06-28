using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Negocio
{
    public class Cliente
    {
        private int idCliente;
        private TipoDoc tipoDocumento;
        private string nroDocumento;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public TipoDoc TipoDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }

        public string NroDocumento
        {
            get { return nroDocumento; }
            set { nroDocumento = value; }
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
