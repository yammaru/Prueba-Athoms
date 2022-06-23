using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class CelularRepository : Repository<Celular>
    {
        public CelularRepository() : base("Celular", new string[]
            {
                "Ram",
                "Almacenamiento",
                "Resolución",
                "Tipo",
                "Referencia",
                "Nombre",
                "Precio",
                "Descripción",
                "Cantidad",
                "Id_marca",
                "Id_color"
            })
        { }

        protected override void BindParams(SqlCommand comm, Celular t)
        {
            // comm.Parameters.AddWithValue(attributes[0], t.Id);
            comm.Parameters.AddWithValue(attributes[0], t.RAM);
            comm.Parameters.AddWithValue(attributes[1], t.Almacenamiento);
            comm.Parameters.AddWithValue(attributes[2], t.MegapixelesEnLaCámara);
            comm.Parameters.AddWithValue(attributes[3], t.Tipo);
            comm.Parameters.AddWithValue(attributes[4], t.Referencia);
            comm.Parameters.AddWithValue(attributes[5], t.Nombre);
            comm.Parameters.AddWithValue(attributes[6], t.Precio);
            comm.Parameters.AddWithValue(attributes[7], t.Descripción);
            comm.Parameters.AddWithValue(attributes[8], t.Cantidad);
            comm.Parameters.AddWithValue(attributes[9], t.Marca.Id);
            comm.Parameters.AddWithValue(attributes[10], t.Color.Id);
        }

        protected override Celular ToObject(SqlDataReader reader)
        {
            Celular a = new Celular();

            a.Id = reader.GetInt32(0);
            a.Referencia = reader.GetString(1);
            a.Nombre = reader.GetString(2);
            a.Precio = (float)reader.GetDouble(3);
            a.Descripción = reader.GetString(4);
            a.Cantidad = reader.GetInt32(5);
            a.Marca = new MarcaRepository().Get(reader.GetInt32(6));
            a.Color = new ColorRepository().Get(reader.GetInt32(7));
            a.Almacenamiento = reader.GetInt32(8);
            a.RAM = reader.GetInt32(9);
            a.MegapixelesEnLaCámara = reader.GetInt32(10);
            a.Tipo = TipoDeCelular.INTELIGENTE;

            return a;
        }
    }
}
