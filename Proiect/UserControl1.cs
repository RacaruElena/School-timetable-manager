using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Blue")
            {
                // Proiect.Properties.Settings.Default.Theme=
                this.BackColor = SystemColors.HotTrack;
            }
            if (comboBox1.SelectedItem == "Light")
            {
                // Proiect.Properties.Settings.Default.Theme=
                this.BackColor = SystemColors.Window;
            }
            if (comboBox1.SelectedItem == "Dark")
            {
                // Proiect.Properties.Settings.Default.Theme=
                this.BackColor = SystemColors.ControlDarkDark;
            }
        }
    }
}
