using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public abstract class Repository<T> where T : new()
    {
        protected string tableName = "";
        protected string[] attributes;
        protected readonly string connectionString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int Count()
        {
            return GetAll().Count;
        }

        public Repository(string tableName, string[] attributes)
        {
            this.tableName = tableName;
            this.attributes = attributes;
        }

        public virtual T GetBy(string nombre, object value)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "SELECT * FROM " + tableName + " WHERE " + nombre + "=@nombre"
                };
                comm.Parameters.AddWithValue("nombre", value);
                SqlDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleResult);
                T result = new T();

                bool found = false;
                try
                {
                    while (reader.Read())
                    {
                        found = true;
                        result = ToObject(reader);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    result = default(T);
                }
                finally
                {
                    if (!reader.IsClosed) reader.Close();
                    conn.Close();
                }

                return found ? result : default(T);
            }
        }
        
        protected abstract T ToObject(SqlDataReader reader);

        public T Get(int key)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "SELECT * FROM " + tableName + " WHERE Id=@Id"
                };
                comm.Parameters.AddWithValue("Id", key);
                SqlDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleResult);
                T result = new T();

                bool found = false;
                try
                {
                    while (reader.Read())
                    {
                        found = true;
                        result = ToObject(reader);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    result = default(T);
                }
                finally
                {
                    if (!reader.IsClosed) reader.Close();
                    conn.Close();
                }

                return found ? result : default(T);
            }
        }
        public T GetCedula(string key)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "SELECT * FROM " + tableName + " WHERE Cédula=@Id"
                };
                comm.Parameters.AddWithValue("Id", key);
                SqlDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleResult);
                T result = new T();

                bool found = false;
                try
                {
                    while (reader.Read())
                    {
                        found = true;
                        result = ToObject(reader);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    result = default(T);
                }
                finally
                {
                    if (!reader.IsClosed) reader.Close();
                    conn.Close();
                }

                return found ? result : default(T);
            }
        }

        public List<T> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "SELECT * FROM " + tableName
                };
                SqlDataReader reader = comm.ExecuteReader();
                List<T> result = new List<T>();

                try
                {
                    while (reader.Read())
                    {
                        result.Add(ToObject(reader));
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    if (!reader.IsClosed) reader.Close();
                    conn.Close();
                }

                return result;
            }
        }

        protected string AttributesNames()
        {
            string r = "";
            string sep = "";
            for (int i = 0; i < attributes.Length; i++)
            {
                if (i > 0) sep = ",";
                r += sep + attributes[i];
            }
            return r;
        }

        private string NamesValuesAttributes()
        {
            string r = "";
            string sep = "";

            for (int i = 0; i < attributes.Length; i++)
            {
                if (i > 0) sep = ",";
                r += ( sep + attributes[i] + "=@" + attributes[i] );
            }
            return r;
        }

        protected string AnnotatedAttributesNames()
        {
            return ("@" + AttributesNames().Replace(",", ",@"));
        }

        protected abstract void BindParams(SqlCommand comm, T t);

        public virtual int Insert(T t)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand comm = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "INSERT INTO " + tableName + " ( " + AttributesNames() + " ) VALUES ( " + AnnotatedAttributesNames() + " )"
                };
                BindParams(comm, t);
                int result = 0;

                try
                {
                    conn.Open();
                    result = comm.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }

                return result;
            }
        }

        public int Delete(int key)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand comm = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "DELETE FROM " + tableName + " WHERE Id=@Id"
                };
                comm.Parameters.AddWithValue("Id", key);
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

                return result;
            }
        }

        public int Update(int key, T t)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand comm = new SqlCommand
                {
                    Connection = conn,
                    CommandText = "UPDATE " + tableName + " SET " + NamesValuesAttributes() + " WHERE Id=@Id"
                };
                comm.Parameters.AddWithValue("Id", key);
                BindParams(comm, t); 
                int result = 0;

                try
                {
                    conn.Open();
                    result = comm.ExecuteNonQuery();
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    conn.Close();
                }

                return result;
            }
        }

    }
}
