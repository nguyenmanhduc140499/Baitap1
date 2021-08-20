using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap1
{
    public partial class FrmNhapdaysovatinhtong : Form
    {
        public FrmNhapdaysovatinhtong()
        {
            InitializeComponent();
        }
        double TongChan, TongLe, Tongday;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtNhapSo.Text = "";
            txtNhapSo.Focus();
            txtDaySo.Text = "";
            txtTongChan.Text = "";
            txtTongLe.Text = "";
            txtTongDay.Text = "";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtNhapSo.Text.ToString());
            txtDaySo.Text += value.ToString() + " ";
            Tongday += value;
            txtTongDay.Text = Tongday.ToString();
            for (int i = 0; i < txtDaySo.Text.Length; i++)
            {
                if (value % 2 == 0)
                {
                    TongChan += value;
                    txtTongChan.Text = TongChan.ToString();
                }
                else
                {
                    TongLe += value;
                    txtTongLe.Text = TongLe.ToString();
                }
            }
            txtDaySo.Enabled = false;
            txtTongDay.Enabled = false;
            txtTongChan.Enabled = false;
            txtTongLe.Enabled = false;
            txtNhapSo.Text = "";
            txtNhapSo.Focus();
        }
    }
}
