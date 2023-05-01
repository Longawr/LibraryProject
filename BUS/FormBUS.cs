using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.BUS
{
    class FormBUS
    {
        private static FormBUS instance;

        public static FormBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new FormBUS();
                return instance;
            }
            //set => instance = value; 
        }

        private FormBUS() { }
        public void loadForm(Panel panelMain, object Form)
        {
            Form f = Form as Form;

            if (panelMain.Controls.Count > 0)
                panelMain.Controls.RemoveAt(0);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelMain.Controls.Add(f);
            panelMain.Tag = f;
            f.Show();
        }
    }
}
