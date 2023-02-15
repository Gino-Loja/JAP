using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1.repositorio
{
    
    public class Repositorio: Irepositorio
    {
        private string CadenaConexioSql;

        public Repositorio(string cadenaConexioSql)
        {
            this.CadenaConexioSql = cadenaConexioSql;
        }

        public IEnumerable<lecturaUsuario> GetlecturasUsuario(string id)
        {

            var listaL = new List<lecturaUsuario>();
            using (MySqlConnection conexion = new MySqlConnection(this.CadenaConexioSql))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                string query = String.Format("SELECT * FROM lectura WHERE id_l = {0}", id);
                cmd.CommandText = query;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var lec = new lecturaUsuario();
                        lec.Anio = reader[3].ToString();    
                        switch (reader[2].ToString())
                        {
                            case "enero":
                                lec.Enero = reader[1].ToString();
                                break;
                            case "febrero":
                                lec.Febrero = reader[1].ToString();
                                break;
                            case "marzo":
                                lec.Marzo = reader[1].ToString();
                                break;
                            case "abril":
                                lec.Abril = reader[1].ToString();
                                break;
                            case "mayo":
                                lec.Mayo = reader[1].ToString();
                                break;
                            case "junio":
                                lec.Junio = reader[1].ToString();
                                break;
                            case "julio":
                                lec.Julio = reader[1].ToString();
                                break;
                            case "agosto":
                                lec.Agosto = reader[1].ToString();
                                break;
                            case "septiembre":
                                lec.Septiembre = reader[1].ToString();
                                break;
                            case "octubre":
                                lec.Octubre = reader[1].ToString();
                                break;
                            case "noviembre":
                                lec.Noviembre = reader[1].ToString();
                                break;
                            case "diciembre":
                                lec.Diciembre = reader[1].ToString();
                                break;
                            default:
                                
                                break;

                            

                        }

                        listaL.Add(lec);


                    }
                }


            }
            return listaL;
        }

        public IEnumerable<ModeloUsuarios> GetPorId(string valor)
        {
            
            var listaU = new List<ModeloUsuarios>();
            using (MySqlConnection conexion = new MySqlConnection(this.CadenaConexioSql))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                string query = String.Format("SELECT * FROM usuarios WHERE id like \"{0}%\" OR nombre like \"{1}%\" ", valor,valor);
                cmd.CommandText = query;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ModUsu = new ModeloUsuarios();
                        Console.WriteLine(reader);
                        ModUsu.Id = reader[0].ToString();
                        ModUsu.Nombre = reader[1].ToString();
                        ModUsu.Comunidad = reader[2].ToString();
                        ModUsu.Edad = reader[3].ToString();
                        ModUsu.Discapacidad = reader[4].ToString();
                        listaU.Add(ModUsu);


                    }
                }


            }
            return listaU;
        }

        public IEnumerable<ModeloUsuarios> GetTodo()
        {
            var listaU = new List<ModeloUsuarios>();
            using (MySqlConnection conexion = new MySqlConnection(this.CadenaConexioSql))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                string query = "SELECT * FROM usuarios";
                cmd.CommandText = query;
                
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()){
                        var ModUsu = new ModeloUsuarios();
                        Console.WriteLine(reader);
                        ModUsu.Id = reader[0].ToString();
                        ModUsu.Nombre = reader[1].ToString();
                        ModUsu.Comunidad = reader[2].ToString();
                        ModUsu.Edad = reader[3].ToString();
                        ModUsu.Discapacidad = reader[4].ToString();
                        

                        listaU.Add(ModUsu);


                    }
                }

                    
            }
            return listaU;
        }
       
    }
}
