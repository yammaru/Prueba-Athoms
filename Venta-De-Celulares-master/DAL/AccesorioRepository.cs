using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class AccesorioRepository : Repository<Accesorio>
    {
        public AccesorioRepository() : base("Accesorio", new string[]
            {
                "Referencia",
                "Nombre",
                "Precio",
                "Descripción",
                "Cantidad",
                "Id_marca",
                "Id_color",
                "Id_tipo_de_accesorio"
            })
        { }

        protected override void BindParams(SqlCommand comm, Accesorio t)
        {
            comm.Parameters.AddWithValue(attributes[0], t.Referencia);
            comm.Parameters.AddWithValue(attributes[1], t.Nombre);
            comm.Parameters.AddWithValue(attributes[2], t.Precio);
            comm.Parameters.AddWithValue(attributes[3], t.Descripción);
            comm.Parameters.AddWithValue(attributes[4], t.Cantidad);
            comm.Parameters.AddWithValue(attributes[5], t.Marca.Id);
            comm.Parameters.AddWithValue(attributes[6], t.Color.Id);
            comm.Parameters.AddWithValue(attributes[7], t.Tipo.Id);
        }

        protected override Accesorio ToObject(SqlDataReader reader)
        {
            Accesorio a = new Accesorio();

            a.Id = reader.GetInt32(0);
            a.Referencia = reader.GetString(1);
            a.Nombre = reader.GetString(2);
            a.Precio = (float)reader.GetDouble(3);
            a.Descripción = reader.GetString(4);
            a.Cantidad = reader.GetInt32(5);
            a.Marca = new MarcaRepository().Get(reader.GetInt32(6));
            a.Color = new ColorRepository().Get(reader.GetInt32(7));
            a.Tipo = new TipoDeAccesorioRepository().Get(reader.GetInt32(8));

            return a;
        }
    }
}
