using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class ClienteRepository : Repository<Cliente>
    {
        public ClienteRepository() : base("Cliente", new string[]
        {
            "Nombres",
            "Primer_apellido",
            "Segundo_apellido",
            "Teléfono",
            "Correo_electrónico",
            "Dirección",
            "Cédula",
            "Género",
            "Edad"
        })
        { }

        protected override void BindParams(SqlCommand comm, Cliente t)
        {
            comm.Parameters.AddWithValue(attributes[0], t.Nombres);
            comm.Parameters.AddWithValue(attributes[1], t.PrimerApellido);
            comm.Parameters.AddWithValue(attributes[2], t.SegundoApellido);
            comm.Parameters.AddWithValue(attributes[3], t.Teléfono);
            comm.Parameters.AddWithValue(attributes[4], t.CorreoElectrónico);
            comm.Parameters.AddWithValue(attributes[5], t.Dirección);
            comm.Parameters.AddWithValue(attributes[6], t.Cédula);
            comm.Parameters.AddWithValue(attributes[7], t.Género);
            comm.Parameters.AddWithValue(attributes[8], t.Edad);
        }

        protected override Cliente ToObject(SqlDataReader reader)
        {
            Cliente a = new Cliente();

            a.Id = reader.GetInt32(0);
            a.Nombres = reader.GetString(1);
            a.PrimerApellido = reader.GetString(2);
            a.SegundoApellido = reader.GetString(3);
            a.Teléfono = reader.GetString(4);
            a.CorreoElectrónico = reader.GetString(5);
            a.Dirección = reader.GetString(6);
            a.Cédula = reader.GetString(7);
            a.Género = char.Parse(reader.GetString(8));
            a.Edad = reader.GetInt32(9);

            return a;
        }
    }
}
