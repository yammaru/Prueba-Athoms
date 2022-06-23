using Entity;
using System;
using System.Data.SqlClient;

namespace DAL
{
    public class CompraRepository : Repository<Compra>
    {
        public CompraRepository() : base ("Compra", new string[]
        {
            "Id",
            "Fecha",
            "Total",
            "Id_cliente"
        }) { }

        protected override void BindParams(SqlCommand comm, Compra t)
        {
            comm.Parameters.AddWithValue(attributes[0], t.Id);
            comm.Parameters.AddWithValue(attributes[1], t.Fecha);
            comm.Parameters.AddWithValue(attributes[2], t.Total);
            comm.Parameters.AddWithValue(attributes[3], t.Cliente.Id);
        }

        public void AsociarAccesorios(int idCompra, int idAccesorio, int cantidad)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand comm = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "INSERT INTO Compra_accesorio (Id_compra, Id_accesorio, Cantidad) VALUES (@Id_compra, @Id_accesorio, @Cantidad)"
                };
                comm.Parameters.AddWithValue("@Id_compra", idCompra);
                comm.Parameters.AddWithValue("@Id_accesorio", idAccesorio);
                comm.Parameters.AddWithValue("@Cantidad", cantidad);
                int result = 0;

                try
                {
                    conn.Open();
                    result = comm.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void AsociarCelular(int idCompra, int idCelular, int cantidad)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand comm = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "INSERT INTO Compra_celular (Id_compra, Id_celular, Cantidad) VALUES (@Id_compra, @Id_celular, @Cantidad)"
                };
                comm.Parameters.AddWithValue("@Id_compra", idCompra);
                comm.Parameters.AddWithValue("@Id_celular", idCelular);
                comm.Parameters.AddWithValue("@Cantidad", cantidad);
                int result = 0;

                try
                {
                    conn.Open();
                    result = comm.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public override int Insert(Compra t)
        {
            int r = base.Insert(t);
            if (r != 0)
            {
                foreach (var a in t.Artículos)
                {
                    if (a.Key is Celular)
                    {
                        AsociarCelular(t.Id, a.Key.Id, a.Value);
                    }
                    else
                    {
                        Console.WriteLine(t.Id + " " + a.Key.Id + " " + a.Value);
                        AsociarAccesorios(t.Id, a.Key.Id, a.Value);
                    }
                }
                return r;
            } else
            {
                return 0;
            }
        }

        protected override Compra ToObject(SqlDataReader reader)
        {
            ClienteRepository cr = new ClienteRepository();

            Compra a = new Compra();

            a.Id = reader.GetInt32(0);
            a.Fecha = reader.GetDateTime(1);
            a.Total = (float)reader.GetDouble(2);
            a.Cliente = cr.Get(reader.GetInt32(3));
            
            return a;
        }
    }
}
