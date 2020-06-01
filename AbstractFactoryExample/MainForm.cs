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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFixed_Click(object sender, EventArgs e)
        {
            Form f = FormCreateMethod(new FixedSizeWindowFactory());
            f.Show();
        }

        private void btnResizable_Click(object sender, EventArgs e)
        {
            Form f = FormCreateMethod(new ResizableWindowFactory());
            f.Show();
        }

        Form FormCreateMethod(IAbstractFactory factory)
        {
            var FormA = factory.CreateProduct();
            return FormA.CreateFormFunction();
        }
    }
}
