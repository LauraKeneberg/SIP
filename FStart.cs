using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIP
{
    public partial class FStart : Form
    {
        public FStart()
        {
            InitializeComponent();
        }

        private void bt_vhod_Click(object sender, EventArgs e)
        {
            FAutoriz f2 = new FAutoriz();
            f2.Show();
            this.Hide();
        }

        private void bt_registr_Click(object sender, EventArgs e)
        {
            FRegist f3 = new FRegist();
            f3.Show();
            this.Hide();
        }

        private void bt_autoriz_MouseMove(object sender, MouseEventArgs e)
        {
            bt_autoriz.ForeColor = Color.Blue;
        }

        private void bt_registr_MouseMove(object sender, MouseEventArgs e)
        {
            bt_registr.ForeColor = Color.Blue;
        }

        private void bt_autoriz_MouseLeave(object sender, EventArgs e)
        {
            bt_autoriz.ForeColor = Color.Black;
        }

        private void bt_registr_MouseLeave(object sender, EventArgs e)
        {
            bt_registr.ForeColor = Color.Black;
        }

        private void lb_SIP_MouseMove(object sender, MouseEventArgs e)
        {
            lb_SIP.ForeColor = Color.Orange;
        }

        private void lb_SIP_MouseLeave(object sender, EventArgs e)
        {
            lb_SIP.ForeColor = Color.Pink;
        }
    }
}
