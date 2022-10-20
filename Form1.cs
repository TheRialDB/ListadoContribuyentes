using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListadoContribuyentes
{
    public partial class Form1 : Form
    {
        Contribuyente contribuyente = new Contribuyente();
        DataTable dtContribuyentes = new DataTable() { TableName = "Contribuyentes" };

        const string REPORTE_1 = "Listado detallado de los contribuyentes que pagaron (deuda igual a cero)";
        const string REPORTE_2 = "Listado de los contribuyentes que no pagaron (deuda no igual a cero)";
        const string REPORTE_3 = "Listado detallado de los contribuyentes que pagaron en el primer trimestre del año";
        const string REPORTE_4 = "Listado detallado de los contribuyentes que no pagaron pero realizaron un plan de pago";
        const string REPORTE_5 = "Listado detallado de los contribuyentes que no pagaron ni realizaron un plan de pago";
        const string REPORTE_6 = "Informe de los contribuyentes que realizaron un plan de pago y pagaron la deuda, pero no lo hicieron en el primer trimestre";
        const string ERROR_FILA = "Elija que fila quiere borrar.";

        public Form1()
        {
            InitializeComponent();

            ToolTip toolTipReportes = new ToolTip();
            dgvContribuyentes.DataSource = dtContribuyentes;

            toolTipReportes.SetToolTip(btnReporte1, REPORTE_1);
            toolTipReportes.SetToolTip(btnReporte2, REPORTE_2);
            toolTipReportes.SetToolTip(btnReporte3, REPORTE_3);
            toolTipReportes.SetToolTip(btnReporte4, REPORTE_4);
            toolTipReportes.SetToolTip(btnReporte5, REPORTE_5);
            toolTipReportes.SetToolTip(btnReporte6, REPORTE_6);

            //Se crean las columnas del Data Grid View.
            dtContribuyentes.Columns.Add("Nº de Cuenta");
            dtContribuyentes.Columns.Add("Nombre");
            dtContribuyentes.Columns.Add("Deuda");
            dtContribuyentes.Columns.Add("Mes Pago");
            dtContribuyentes.Columns.Add("Plan de pago");

            LeerDatos();

        }

        //Boton para cargar contribuyentes en el Data Grid View.
        private void btnCargar_Click(object sender, EventArgs e)
        {
            contribuyente.NumeroDeCuenta = txtNCuenta.Text;
            contribuyente.Nombre = txtNombre.Text;
            contribuyente.Deuda = txtDeuda.Text;
            contribuyente.MesPago = cmbMesPago.Text;
            contribuyente.PlanDePago = cmbPlanDePago.Text;

            //Se cargan los contribuyentes en el Data Grid View.
            dtContribuyentes.Rows.Add();
            int i = dtContribuyentes.Rows.Count - 1;

            dtContribuyentes.Rows[i]["Nº de Cuenta"] = contribuyente.NumeroDeCuenta;
            dtContribuyentes.Rows[i]["Nombre"] = contribuyente.Nombre;
            dtContribuyentes.Rows[i]["Deuda"] = contribuyente.Deuda;
            dtContribuyentes.Rows[i]["Mes Pago"] = contribuyente.MesPago;
            dtContribuyentes.Rows[i]["Plan de pago"] = contribuyente.PlanDePago;

            GuardarDatos();            
            LimpiarPantalla();
        }

        //Boton para borrar contribuyentes en el Data Grid View.
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvContribuyentes.CurrentRow == null)
            {
                MessageBox.Show(this, ERROR_FILA, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvContribuyentes.Rows.Remove(dgvContribuyentes.CurrentRow);
                GuardarDatos();
            }
            
        }

        //Metodo para limpiar los TextBoxs y ComboBoxs.
        private void LimpiarPantalla() 
        {
            txtNCuenta.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
            cmbMesPago.SelectedIndex = -1;
            cmbPlanDePago.SelectedIndex= -1;
        }

        //Guardamos los datos en un archivo xml.
        private void GuardarDatos() 
        {
            dtContribuyentes.WriteXml(@"C:\Users\Usuario\source\repos\ListadoContribuyentes\DatosContribuyentes.xml");
        }

        //Lee los datos ya cargados en el xml.
        private void LeerDatos()
        {
            if (System.IO.File.Exists(@"C:\Users\Usuario\source\repos\ListadoContribuyentes\DatosContribuyentes.xml"))
            {
                dtContribuyentes.ReadXml(@"C:\Users\Usuario\source\repos\ListadoContribuyentes\DatosContribuyentes.xml");
            }
        }
    }


}
