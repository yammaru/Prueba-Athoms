namespace Entity
{
    public class Celular : Artículo
    {
        public int Almacenamiento { get; set; }
        public int RAM { get; set; }
        public int MegapixelesEnLaCámara { get; set; }
        public TipoDeCelular Tipo { get; set; }

        public Celular() { }
    }
}
