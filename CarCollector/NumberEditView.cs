using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCollector
{
    public partial class NumberEditView : Form
    {
        public object EditResult => numberEditor.DataSource;
        public NumberEditView(object dataSource)
        {
            InitializeComponent();
            numberEditor.NumberValidated += OnNumberValidated;
            numberEditor.DataSource = dataSource;
        }

        private void OnNumberValidated(object sender, EventArgs<bool> e)
        {
            btOk.Enabled = e.Value;
        }

        private void OnOk(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
