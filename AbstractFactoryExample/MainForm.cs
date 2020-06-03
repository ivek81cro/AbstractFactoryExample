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
