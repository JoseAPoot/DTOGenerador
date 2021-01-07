using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DTOGenerador
{
    public class DTOConexion
    {
        private SqlConnection sqlConnection;
        private MySqlConnection mySqlConnection;

        private bool ConexionValida = false;
        
        private int Type { get; set; }
        private string Servidor { get; set; }
        private string BaseDatos { get; set; }
        private string Usuario { get; set; }
        private string Password { get; set; }

        public string MensajeError { get; set; }

        public DTOConexion(int type, string server, string user, string pass, string bd = "")
        {
            this.Type      = type;
            this.Servidor  = server;
            this.Usuario   = user;
            this.Password  = pass;
            this.BaseDatos = bd;

            if (BaseDatos.Length <= 0)
            {
                if (Type.Equals(0))
                {
                    this.BaseDatos = "master";
                } else
                {
                    this.BaseDatos = "mysql";
                }
            }

            EstablecerConexion();
        }

        private void EstablecerConexion()
        {
            ConexionValida = Valida();
        }

        private bool Valida()
        {
            if (Servidor == null || BaseDatos == null || Usuario == null || Password == null)
            {
                MensajeError = "Error SQL: Faltan datos de conexión";
                return false;
            }
            else
            {
                return EsAccesible();
            }
        }

        public bool EsAccesible()
        {
            try
            {
                if (Type.Equals(0))
                {
                    SqlConnection conexTest = new SqlConnection
                    {
                        ConnectionString = CadenaConexion()
                    };
                    conexTest.Open();
                    conexTest.Close();
                } 
                else if (Type.Equals(1)) 
                {
                    MySqlConnection conexTest = new MySqlConnection
                    {
                        ConnectionString = CadenaConexion()
                    };
                    conexTest.Open();
                    conexTest.Close();
                }

                return true;
            }
            catch (Exception error)
            {
                MensajeError = "Error SQL: " + error.Message;
                return false;
            }
        }

        private int Conectar()
        {
            if (ConexionValida)
            {
                try
                {
                    if (Type.Equals(0))
                    {
                        sqlConnection = new SqlConnection
                        {
                            ConnectionString = CadenaConexion()
                        };
                        sqlConnection.Open();
                    }
                    else if (Type.Equals(1))
                    {
                        mySqlConnection = new MySqlConnection
                        {
                            ConnectionString = CadenaConexion()
                        };
                        mySqlConnection.Open();
                    }

                    return 0;
                }
                catch (Exception error)
                {
                    MensajeError = "Error SQL: " + error.Message;
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        private void Desconectar()
        {
            if (Type.Equals(0))
            {
                sqlConnection.Close();
            }
            else if (Type.Equals(1))
            {
                mySqlConnection.Close();
            }
        }

        private string CadenaConexion()
        {
            if (Type.Equals(0))
            {
                return "Data Source=" + Servidor + ";Initial Catalog=" + BaseDatos + ";Persist Security Info=False;User ID=" + Usuario + "; Password=" + Password + ";Connection Timeout=0;";
            }
            else
            {
                return "Server=" + Servidor + ";Database=" + BaseDatos + ";Uid=" + Usuario + ";Pwd=" + Password + ";";
            }
        }

        public int CargaTabla(string query, ref DataTable dtDatos)
        {
            if (Conectar() != 0)
            {
                return -1;
            }

            dtDatos = new DataTable();
            
            try
            {
                if (Type.Equals(0))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            sqlDataAdapter.Fill(dtDatos);
                        }
                    }
                } else
                {
                    using (MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection))
                    {
                        using (MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand))
                        {
                            sqlDataAdapter.Fill(dtDatos);
                        }
                    }
                }

                Desconectar();

                return 0;
            }
            catch (Exception error)
            {
                Desconectar();
                MensajeError = "Error SQL: " + error.Message;
                return -1;
            }
        }
    }
}
