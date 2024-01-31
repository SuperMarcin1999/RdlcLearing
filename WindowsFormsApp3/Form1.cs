using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = Enumerable.Range(0, 50).Select(x => new RowModel(
                $"{1}:{x}",
                $"{2}:{x}",
                $"{3}:{x}",
                $"{4}:{x}",
                $"{5}:{x}"));


            var reportDS = new ReportDataSource("DataSet1", list);
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportDS);

            this.reportViewer1.RefreshReport();
        }
    }
}
