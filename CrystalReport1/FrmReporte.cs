using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalReport1.Modelo;
using CrystalReport1.controladores;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystalReport1
{
    public partial class FrmReporte : Form
    {
        private void CargarCombo()
        {
            this.cmbDepartamento.DataSource = ControladorProductos.ListaDepart(true);
            this.cmbDepartamento.SelectedIndex = this.cmbDepartamento.Items.Count - 1;
        }
        
        public FrmReporte()
        {
            InitializeComponent();
           
        }

        ReportDocument crpDocument;
        public void GenerarReporte()
        {
            crpDocument = new ReportDocument();
            crpDocument.Load(@"Reportes\rptProductos.rpt");
            crpDocument.SetDataSource(ControladorProductos.getListado());
            //crpDocument.SetParameterValue("parUsuario", "Mario");
            this.crystalReportViewer1.ReportSource = crpDocument;

        }

        // int indexrol;
        private void FrmReporte_Load(object sender, EventArgs e)
        {
            this.CargarCombo();

            //// llenar combo
            
            //cmbDepartamento.DataSource = ControladorProductos.ListaDepart(true);
            
            //cmbDepartamento.DisplayMember = "sDepartamento";
            ////cmbDepartamento.ValueMember = "pkProducto";
            //cmbDepartamento.SelectedIndex = indexrol;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }
    }
}
 ;