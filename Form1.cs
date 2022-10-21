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
        const string DIRECCION_XML = @"C:\Users\Usuario\OneDrive\Escritorio\FACU\PROGRAMACIÓN\vs2022\ListadoContribuyentes\";
        const string ERROR_NCUENTA_EXISTE = "Número de cuenta existente";
        const string ERROR_COMAS = "No puede colocar más de una , (coma)";
        
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
            epvValidar.Clear();

            if (Validar())
            {
                
            }
            else
            {
                int fila = BuscarCodigo(txtNCuenta.Text);
                if (fila != -1)
                {
                    MessageBox.Show(ERROR_NCUENTA_EXISTE);
                }
                else
                {
                    if (ValidarComas(this.Controls))
                    {
                        MessageBox.Show(ERROR_COMAS);
                    }
                    else
                    {
                        contribuyente.NumeroDeCuenta = txtNCuenta.Text;
                        contribuyente.Nombre = txtNombre.Text;
                        contribuyente.Deuda = Convert.ToDecimal(txtDeuda.Text);
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
                        Negrear();
                    }
                }               
            }
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
            Negrear();
        }

        //Metodo para limpiar los TextBoxs y ComboBoxs.
        private void LimpiarPantalla()
        {
            txtNCuenta.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
            cmbMesPago.SelectedIndex = -1;
            cmbPlanDePago.SelectedIndex = -1;
        }
        //Método para limpiar el datagridview
        private void Negrear()
        {
            for (int i = 0; i < dtContribuyentes.Rows.Count; i++)
            {
                dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.FromArgb(64, 64, 64);
                dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.FromArgb(64, 64, 64);
                dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.FromArgb(64, 64, 64);
                dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.FromArgb(64, 64, 64);
                dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        //Guardamos los datos en un archivo xml.
        private void GuardarDatos()
        {
            dtContribuyentes.WriteXml(DIRECCION_XML + "DatosContribuyentes.xml");
        }

        //Lee los datos ya cargados en el xml.
        private void LeerDatos()
        {
            if (System.IO.File.Exists(DIRECCION_XML + "DatosContribuyentes.xml"))
            {
                dtContribuyentes.ReadXml(DIRECCION_XML + "DatosContribuyentes.xml");
            }
        }

        //Método validar
        private bool Validar()
        {
            bool validar = false;

            if (txtNCuenta.Text == "")
            {
                epvValidar.SetError(txtNCuenta, "llenar campo");
                validar = true;
            }
            if (txtNombre.Text == "")
            {
                epvValidar.SetError(txtNombre, "llenar campo");
                validar = true;
            }
            if (txtDeuda.Text == "")
            {
                epvValidar.SetError(txtDeuda, "llenar campo");
                validar = true;
            }
            if (cmbMesPago.SelectedIndex == -1)
            {
                epvValidar.SetError(cmbMesPago, "llenar campo");
                validar = true;
            }
            if (cmbPlanDePago.SelectedIndex == -1)
            {
                epvValidar.SetError(cmbPlanDePago, "llenar campo");
                validar = true;
            }
            return validar;
        }
        //metodo para buscar codigo
        public int BuscarCodigo(string code)
        {
            int fila = -1;

            for (int i = 0; i < dtContribuyentes.Rows.Count; i++)
            {
                if (dtContribuyentes.Rows[i]["Nº de Cuenta"].ToString() == code)
                {
                    fila = i;
                    break;
                }
            }

            return fila;
        }
        //Validacion para solo cargar numeros txtdeuda
        private void txtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar) && (e.KeyChar != ',')))
            {
                e.Handled = true;
            }
        }
        //Validacion para no colocar mas de una , (coma)
        private bool ValidarComas(Control.ControlCollection ctrlCollection)
        {
            char myChar = ',';
            int i = 0;
            bool comas = false;
            
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    if (!comas)
                    {
                        foreach (char c in ctrl.Text)
                        {
                            if (c == myChar)
                            {
                                i++;
                                if (i > 1)
                                {
                                    comas = true;
                                    break;
                                }

                            }
                        }
                        i = 0;
                    }
                }
            }
            return comas;
        }

        //Botones de reportes
        private void btnReporte1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtContribuyentes.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dtContribuyentes.Rows[i]["Deuda"]) == 0)
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Green;
                }
                else
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
            }
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtContribuyentes.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dtContribuyentes.Rows[i]["Deuda"]) != 0)
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Green;
                }
                else
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
            }
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            bool primerTrimestre;

            for (int i = 0; i < dtContribuyentes.Rows.Count; i++)
            {
                string mesPago = dtContribuyentes.Rows[i]["Mes Pago"].ToString().Trim();

                if (mesPago == "Enero" || mesPago == "Febrero" || mesPago == "Marzo")
                {
                    primerTrimestre = true;
                }
                else
                {
                    primerTrimestre = false;
                }
                if (primerTrimestre)
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Green;
                }
                else
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
            }
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtContribuyentes.Rows.Count; i++)
            {
                bool deuda = false;
                bool planDePago = false;

                if (Convert.ToDecimal(dtContribuyentes.Rows[i]["Deuda"]) != 0)
                {
                    deuda = true;
                }
                if (dtContribuyentes.Rows[i]["Plan de pago"].ToString().Trim() == "SI")
                {
                    planDePago = true;
                }
                if (deuda && planDePago)
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Green;
                }
                else
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
            }
        }

        private void btnReporte5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtContribuyentes.Rows.Count; i++)
            {
                bool deuda = false;
                bool planDePago = false;

                if (Convert.ToDecimal(dtContribuyentes.Rows[i]["Deuda"]) != 0)
                {
                    deuda = true;
                }
                if (dtContribuyentes.Rows[i]["Plan de pago"].ToString().Trim() == "NO")
                {
                    planDePago = true;
                }
                if (deuda && planDePago)
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Green;
                }
                else
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
            }
        }

        private void btnReporte6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtContribuyentes.Rows.Count; i++)
            {
                bool planDePago = false;
                bool deuda = false;
                bool primerTrimestre = true;
                string mesPago = dtContribuyentes.Rows[i]["Mes Pago"].ToString().Trim();
                if (dtContribuyentes.Rows[i]["Plan de pago"].ToString().Trim() == "SI")
                {
                    planDePago = true;
                }
                if (Convert.ToDecimal(dtContribuyentes.Rows[i]["Deuda"]) == 0)
                {
                    deuda = true;
                }
                if (mesPago == "Enero" || mesPago == "Febrero" || mesPago == "Marzo")
                {
                    primerTrimestre = false;
                }
                if (planDePago && deuda && primerTrimestre)
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Green;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Green;
                }
                else
                {
                    dgvContribuyentes.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dgvContribuyentes.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
            }
        }
    }
}
