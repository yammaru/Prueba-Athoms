using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class ColorRepository : Repository<Color>
    {
        public ColorRepository() : base ("Color", new string[]
        {
            "Nombre"
        })
        { }

        protected override void BindParams(SqlCommand comm, Color t)
        {
            comm.Parameters.AddWithValue(attributes[0], t.Nombre);
        }

        protected override Color ToObject(SqlDataReader reader)
        {
            Color a = new Color();

            a.Id = reader.GetInt32(0);
            a.Nombre = reader.GetString(1);

            return a;
        }
    }
}
