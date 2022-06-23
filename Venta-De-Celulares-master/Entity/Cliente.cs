using System.Collections.Generic;

namespace Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Cédula { get; set; }
        public string CorreoElectrónico { get; set; }
        public string Dirección { get; set; }
        public string Teléfono { get; set; }
        public char Género { get; set; }
        public int Edad { get; set; }
        private List<Compra> _compras;

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

        public Cliente() { }
    }
}
