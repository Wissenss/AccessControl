using AccessControl.Models;
using Middleware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl.Generic
{
    public partial class FormularioDesechable : Form
    {
        public FormularioDesechable()
        {
            InitializeComponent();
        }

        private void TestSemanasTipo(object sender, EventArgs args)
        {
            List<SemanaTipo> semanas;
            ServiceProvider.Instance.ServiceSemanasTipo.GetSemanasTipo(out semanas);

        }
    }
}
