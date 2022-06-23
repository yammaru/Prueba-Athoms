using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        private Dictionary<Artículo, int> artículos = null;
        public double Total { get; set; }
        private Cliente cliente = null;

        public Dictionary<Artículo, int> Artículos
        {
            get
            {
                if (artículos == null)
                {
                    artículos = new Dictionary<Artículo, int>();
                }
                return artículos;
            }
            set
            {
                artículos = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                if (cliente == null)
                {
                    cliente = new Cliente();
                }
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }

        public Compra() { }
    }
}
