using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class EnlaceCassandra
    {
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;

        private static void conectar()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();

            _cluster = Cluster.Builder()
                .AddContactPoint(_dbServer)
                .Build();

            _session = _cluster.Connect(_dbKeySpace);
        }

        private static void desconectar()
        {
            _cluster.Dispose();
        }

        public void InsertaDatos(int id, string nombre, int precio, int stock, string sucursal)
        {
            try
            {
                conectar();

                string qry = "insert into producto(id, nombre,precio,stock,sucursal,fecha) values(";
                qry = qry + id.ToString();
                qry = qry + ",'";
                qry = qry + nombre;
                qry = qry + ",'";
                qry = qry + precio.ToString();
                qry = qry + ",'";
                qry = qry + stock.ToString();
                qry = qry + ",'";
                qry = qry + sucursal;
                qry = qry + "');";


                string query = "insert into producto(id,nombre,precio,stock,sucursal) values({0}, '{1}',{2},{3},'{4}');";
                 qry = string.Format(query, id, nombre, precio, stock, sucursal);

                _session.Execute(qry);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public IEnumerable<Producto> Get_One(int dato)
        {
            string query = "SELECT id,nombre,precio,stock,sucursal FROM producto WHERE id = ?;";
            conectar();
            IMapper mapper = new Mapper(_session);
            IEnumerable<Producto> users = mapper.Fetch<Producto>(query, dato);

            desconectar();
            return users.ToList();
        }

        public List<Producto> Get_All()
        {
            string query = "SELECT id,nombre,precio,stock,sucursal FROM producto;";
            conectar();

            IMapper mapper = new Mapper(_session);
            IEnumerable<Producto> users = mapper.Fetch<Producto>(query);

            desconectar();
            return users.ToList();

        }

        public void EliminarDato(int id)
        {
            try
            {
                conectar();
                string query = "delete nombre,precio,stock,sucursal from producto where id={0};";
                string qry = string.Format(query, id);

                _session.Execute(qry);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public void EliminarNombre(int id)
        {
            try
            {
                conectar();
                string query = "delete nombre from producto where id={0};";
                string qry = string.Format(query, id);

                _session.Execute(qry);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public void EliminarPrecio(int id)
        {
            try
            {
                conectar();
                string query = "delete Precio from producto where id={0};";
                string qry = string.Format(query, id);

                _session.Execute(qry);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public void EliminarStock(int id)
        {
            try
            {
                conectar();
                string query = "delete stock from producto where id={0};";
                string qry = string.Format(query, id);

                _session.Execute(qry);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public void EliminarSucursal(int id)
        {
            try
            {
                conectar();
                string query = "delete sucursal from producto where id={0};";
                string qry = string.Format(query, id);

                _session.Execute(qry);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }


        public void EliminarTodo()
        {
            try
            {
                conectar();
                string query = "truncate producto";
                string qry = string.Format(query);

                _session.Execute(qry);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public void EditarNombre(int id,string nombre)
        {
            try
            {
                conectar();
                string query = "update producto set nombre ='{0}' where id={1} if exists;";
                string qry = string.Format(query, nombre,id);

                _session.Execute(qry);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public void EditarPrecio(int id, int precio)
        {
            try
            {
                conectar();
                string query = "update producto set precio ={0} where id={1} if exists;";
                string qry = string.Format(query, precio, id);

                _session.Execute(qry);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public void EditarStock(int id, int stock)
        {
            try
            {
                conectar();
                string query = "update producto set stock ={0} where id={1} if exists;";
                string qry = string.Format(query,stock, id);

                _session.Execute(qry);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar();
            }
        }

        public void EditarSucursal(int id, string sucursal)
        {
            try
            {
                conectar();
                string query = "update producto set sucursal ='{0}' where id={1} if exists;";
                string qry = string.Format(query, sucursal, id);

                _session.Execute(qry);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                desconectar(); 
            }
        }
    }
    
}
    
