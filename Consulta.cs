using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControlador;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Consulta : Form
    {

        controlador con = new controlador();

        //Mostrar los datos CAPA VISTA


        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(tabla);
            /*nombre del datagrid*/.DataSource = dt;

        }



        public Consulta()
        {



            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

        }
    }
}
