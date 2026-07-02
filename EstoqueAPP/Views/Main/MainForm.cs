using EstoqueAPP.Views.Main;

namespace EstoqueAPP
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler OpenDialogRegister;

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDialogRegister?.Invoke(this, EventArgs.Empty);
        }
    }
}
