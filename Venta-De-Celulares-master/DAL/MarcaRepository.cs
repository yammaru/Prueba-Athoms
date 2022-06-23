using Entity;
using System;
using System.Data.SqlClient;

namespace DAL
{
    public class MarcaRepository : Repository<Marca>
    {
        public MarcaRepository() : base("Marca", new string[]
        {
            "Nombre"
        })
        { }

        protected override void BindParams(SqlCommand comm, Marca t)
        {
            comm.Parameters.AddWithValue(attributes[0], t.Nombre);
        }

        protected override Marca ToObject(SqlDataReader reader)
        {
            Marca a = new Marca();

            a.Id = reader.GetInt32(0);
            a.Nombre = reader.GetString(1);

            return a;
        }
    }
}
