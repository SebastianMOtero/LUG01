using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUG01
{
    public partial class Form1 : Form
    {
        //SqlConnection oCn;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        public void AbrirConexion()
        {
            //Clase que representa una conexion a una base de datos
            SqlConnection oCn = new SqlConnection(@"Data Source=.\SQLEXPRESS;
                                                Initial Catalog=LUG01; 
                                                Integrated Security=True");
            oCn.Open();

            //Crea un comando. Clase que representa un comando SQL
            SqlCommand oCmd = new SqlCommand();
            //Establece la conexion que va a utilizar
            oCmd.Connection = oCn;
            //Establece como se interpretara el CommandText
            oCmd.CommandType = CommandType.Text;
            //Establece la instruccion SQL
            oCmd.CommandText = "select * from Pais";
            //Clase que representa una tabla de datos
            DataTable data = new DataTable();
            //Clase adaptadora entre un objeto DataSet y sus operaciones (select, insert, etc)
            SqlDataAdapter adapter = new SqlDataAdapter(oCmd);
            //Rellena un DataTable
            adapter.Fill(data);
            //Carga el DataTable en el DataGridView
            dataGridView1.DataSource = data;


            //DataSet es una superclase que contiene todas las tablas, vistas, relaciones
            //integridad, etc. Copia la BD la extrae como XML y la guarda en un memoria
            //para usar offline

            //DataSet contiene DataTable, DataRelation, DataColumn, DataRow, Constraint

            oCn.Close();
            oCn.Dispose();
            oCn = null;
            GC.Collect();
        }

        private void CerrarConexion()
        {
            
        }

        private void Agregar()
        {
            //Clase que representa una conexion a una base de datos
            SqlConnection oCn = new SqlConnection(@"Data Source=.\SQLEXPRESS;
                                                Initial Catalog=LUG01; 
                                                Integrated Security=True");
            oCn.Open();
            //Crea un comando. Clase que representa un comando SQL
            SqlCommand oCmd = new SqlCommand();
            //Establece la conexion que va a utilizar
            oCmd.Connection = oCn;
            //Establece como se interpretara el CommandText
            oCmd.CommandType = CommandType.Text;
            //Establece la instruccion SQL
            oCmd.CommandText = "INSERT INTO Pais VALUES(@Id_Pais, @Nombre)";
            //Clase que representa un parametro SQL
            SqlParameter pId_Pais = new SqlParameter();
            pId_Pais.ParameterName = "@Id_Pais";
            pId_Pais.Value = Convert.ToInt32(txtIDPais.Text);
            oCmd.Parameters.Add(pId_Pais);
            //Clase que representa un parametro SQL
            SqlParameter pNombre = new SqlParameter();
            pNombre.ParameterName = "@Nombre";
            pNombre.Value = txtNombre.Text.ToString();
            oCmd.Parameters.Add(pNombre);
            oCmd.ExecuteNonQuery();

            txtIDPais.Clear();
            txtNombre.Clear();

            oCn.Close();
            oCn.Dispose();
            oCn = null;
            GC.Collect();
        }

        private void btnAbrirBD_Click(object sender, EventArgs e)
        {
            AbrirConexion();
        }

        private void btnCerrarBD_Click(object sender, EventArgs e)
        {
            CerrarConexion();
        }

        private void txtIDPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        ///SqlConnection
        ///Representa una conexion a un origen de datos SQL
        ///Puede estar activa o cerrada.
        ///SqlCommand
        ///Representa un comando de SQL que puedde ejecutarse en una BD
        ///DataTable
        ///Clase que representa a una tabla de datos, contiene DataRow, DataColumn
        ///DataSet
        ///Clase que representa un conjunto de tablas, y sus relaciones. Representa
        ///a una cache de una BD. Los datos se almacenan de forma temporal en la memoria
        ///Puede usarse para trabajar sin conexion persistente
        ///SqlDataAdapter
        ///Se conecta a una BD y ejecuta instrucciones SQL, tanto para poblar un DataSet
        ///como para actualizar el origen de datos del DataSet
    }
}
