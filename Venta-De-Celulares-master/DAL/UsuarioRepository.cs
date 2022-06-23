using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository() : base("Usuario", new string[] {
            "Nombre",
            "Contraseña",
            "Rol"
        }) { }

        protected override void BindParams(SqlCommand comm, Usuario t)
        {
            comm.Parameters.AddWithValue(attributes[0], t.Nombre);
            comm.Parameters.AddWithValue(attributes[1], t.Contraseña);
            comm.Parameters.AddWithValue(attributes[2], t.Rol);
        }

        protected override Usuario ToObject(SqlDataReader reader)
        {
            Usuario u = new Usuario();
            u.Id = reader.GetInt32(0);
            u.Nombre = reader.GetString(1);
            u.Contraseña = reader.GetString(2);
            u.Rol = char.Parse(reader.GetString(3));

            return u;
        }
    }
}
