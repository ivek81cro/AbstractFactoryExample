using System;
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
            var form = new FixedSizeWindowFactory();
            form.CreateProduct();
        }

        private void btnResizable_Click(object sender, EventArgs e)
        {
            var form = new ResizableWindowFactory();
            form.CreateProduct();
        }
    }
}
