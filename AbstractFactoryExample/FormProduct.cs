using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactoryExample
{
    public partial class FormProduct : Form, IAbstractProduct
    {
        public FormProduct(bool resizable)
        {
            InitializeComponent();
            if (!resizable)
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MinimizeBox = false;
                this.MaximizeBox = false;
            }
            this.Show();
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}
