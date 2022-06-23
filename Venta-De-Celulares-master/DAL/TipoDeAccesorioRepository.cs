using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class TipoDeAccesorioRepository : Repository<TipoDeAccesorio>
    {
        public TipoDeAccesorioRepository() : base("Tipo_de_accesorio", new string[]
            {
                "Nombre",
                "Descripción"
            })
        { }

        protected override void BindParams(SqlCommand comm, TipoDeAccesorio t)
        {
            comm.Parameters.AddWithValue(attributes[0], t.Tipo);
            comm.Parameters.AddWithValue(attributes[1], t.Descripción);
        }

        protected override TipoDeAccesorio ToObject(SqlDataReader reader)
        {
            TipoDeAccesorio ta = new TipoDeAccesorio();

            ta.Id = reader.GetInt32(0);
            ta.Tipo = reader.GetString(1);
            ta.Descripción = reader.GetString(2);

            return ta;
        }
    }
}
