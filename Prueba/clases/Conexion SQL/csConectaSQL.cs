using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGym
{
    internal class csConectaSQL
    {
        public SqlConnection oCon;
        public SqlCommand oCom;
        public SqlDataReader oDR;
        public SqlDataAdapter oDA;
        public DataTable oDT;

        string Server;
        string Database;
        string Usuario;
        string Clave;
        string Cadena;
        public csConectaSQL()
        {
            Server = @"DESKTOP-N57DUB0\SQLEXPRESS";
            Database = "GymJRS";
            Usuario = "sa";
            Clave = "1234";
        }

        public csConectaSQL(string Server, string Database, string Usuario, string Clave)
        {
            this.Server = Server;
            this.Database = Database;
            this.Usuario = Usuario;
            this.Clave = Clave;
        }

        public bool abrirConexion()
        {
            oCon = new SqlConnection();
            try
            {
                oCon.ConnectionString = Cadena = "Server=" + Server + "; Database=" + Database + "; User id=" + Usuario.Trim() + "; Password=" + Clave;
                oCon.Open();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool cerrarConexion()
        {
            oCon.Close();
            return true;
        }

        public bool eliminarDatos(string Tabla, string Condicion)
        {
            try
            {
                abrirConexion();
                Cadena = "Delete " + Tabla + " where " + Condicion;
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool ModificarDatos(string cadena)
        {
            try
            {
                abrirConexion();
                oCom = new SqlCommand(cadena, oCon);
                oCom.ExecuteNonQuery();
                cerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }



        public bool insertarDatos(string Tabla, string Campos, string Datos)
        {
            abrirConexion();
            Cadena = "Insert into " + Tabla + " (" + Campos + ") values( " + Datos + ")";
            oCom = new SqlCommand(Cadena, oCon);
            oCom.ExecuteNonQuery();
            cerrarConexion();
            return true;
        }

        public bool ejecutarSQL(string Sentencia)
        {
            abrirConexion();
            oCom = new SqlCommand(Sentencia, oCon);
            oCom.ExecuteNonQuery();
            cerrarConexion();
            return true;
        }


        public int retornaValor(string Seleccion, string Tabla, string Condicion)
        {
            int temporal;
            abrirConexion();
            Cadena = "Select isnull(cast(" + Seleccion + " as int),0) from " + Tabla + " where " + Condicion;
            oCom = new SqlCommand(Cadena, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (int)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public String retornaCadena(string Seleccion, string Tabla, string Condicion)
        {
            string temporal;
            abrirConexion();
            Cadena = "Select isnull(cast(" + Seleccion + " as varchar(200)),'') from " + Tabla + " where " + Condicion;
            oCom = new SqlCommand(Cadena, oCon);
            oDR = oCom.ExecuteReader();

            if (oDR.Read())
            {
                temporal = (String)oDR[0];
            }
            else
            {
                temporal = "";
            }
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public string retornaCadenaConsulta(string Consulta)
        {
            string temporal;
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (string)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public decimal retornaValorConsulta(string Consulta)
        {
            decimal temporal;
            abrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (decimal)oDR[0];
            oDR.Close();
            cerrarConexion();
            return temporal;
        }

        public DataTable retornaRegistros(string Sentencia)
        {
            if (Sentencia.Length > 0)
            {
                abrirConexion();
                oCom = new SqlCommand(Sentencia, oCon);
                oDA = new SqlDataAdapter(oCom);
                oDT = new DataTable();
                oDA.Fill(oDT);
                cerrarConexion();
            }
            return oDT;
        }
    }
}

