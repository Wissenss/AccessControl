using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl
{
    public partial class CatalogoAcceso : Form
    {
        public DataSet dataSet {get; set;}

        public CatalogoAcceso(DataSet dataSet)
        {
            InitializeComponent();

            this.dataSet = dataSet;
            DgvUsuarios.DataSource = this.dataSet;
            DgvUsuarios.DataMember = "Usuarios";

            DgvUsuarios.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns[1].Width = 150;
        }
    }
}
