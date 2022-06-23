using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Artículo
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set;  }
        public string Descripción { get; set; }
        public int Cantidad { get; set; }
        public Marca Marca { get; set; }
        private List<Compra> _compras;
        public Color Color { get; set; }

        public List<Compra> Compras
        {
            get
            {
                if (_compras == null)
                {
                    _compras = new List<Compra>();
                }
                return _compras;
            }
            set
            {
                _compras = value;
            }
        }

        public Artículo() {}

        public void SetAttributes(Artículo a)
        {
            Id = a.Id;
            Referencia = a.Referencia;
            Nombre = a.Nombre;
            Precio = a.Precio;
            Descripción = a.Descripción;
            Cantidad = a.Cantidad;
            Marca = a.Marca;
            Color = a.Color;
        }

    }
}
