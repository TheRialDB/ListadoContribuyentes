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
        public Form1()
        {
            InitializeComponent();


            const string REPORTE_1 = "Listado detallado de los contribuyentes que pagaron (deuda igual a cero)";
            const string REPORTE_2 = "Listado de los contribuyentes que no pagaron(deuda no igual a cero)";
            const string REPORTE_3 = "Listado detallado de los contribuyentes que pagaron en el primer trimestre del año";
            const string REPORTE_4 = "Listado detallado de los contribuiyentes que no pagaron pero realizaron un plan de pago";
            const string REPORTE_5 = "Listado detallado de los contribuiyentes que no pagaron ni realizaron un plan de pago";
            const string REPORTE_6 = "Informe de los contribuiyentes que realizaron un plan de pago y pagaron la deuda, pero no lo hicieron en el primer trimestre";


            ToolTip toolTipReportes = new ToolTip();

            toolTipReportes.SetToolTip(btnReporte1, REPORTE_1);
            toolTipReportes.SetToolTip(btnReporte2, REPORTE_2);
            toolTipReportes.SetToolTip(btnReporte3, REPORTE_3);
            toolTipReportes.SetToolTip(btnReporte4, REPORTE_4);
            toolTipReportes.SetToolTip(btnReporte5, REPORTE_5);
            toolTipReportes.SetToolTip(btnReporte6, REPORTE_6);




        }
    }


}
