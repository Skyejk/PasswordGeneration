using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GuardPRO.Forms
{
    public partial class ApplicationMainForm : Form
    {
        public ApplicationMainForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomMessage("Программа Защитник ПРО разработана студентом группы ПР-49, " +
                "обучающемся на профиле 09.02.03 «Программирование в компьютерных системах», " +
                "Ремезовым Кириллом Андреевичем.",
                aboutMeToolStripMenuItem.Text,
                MessageBoxIcon.Asterisk);
        }
        public void CustomMessage(string txt, string head, MessageBoxIcon icon)
        {
            MessageBox.Show(txt, head, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void ApplicationMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                //
                //Тут нужна справка.
                //Button1Click(sender, e);
            }
        }

        private void ApplicationMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
