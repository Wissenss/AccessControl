using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Middleware
{
    public partial class VScriptExecution : Form
    {
        public VScriptExecution()
        {
            InitializeComponent();
        }

        public void On_StatementExecuted(object sender, MySqlScriptEventArgs args)
        {
            rtbStatements.Text += "\n" + args.StatementText;
        }
    }
}
