using LibraryProject.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class FormTopDocGia : Form
    {
        public FormTopDocGia()
        {
            InitializeComponent();
        }

        private void FormTopDocGia_Load(object sender, EventArgs e)
        {
            ThongKeBUS.Instance.TopDocGia(dtgvDocGia);
        }
    }
}
