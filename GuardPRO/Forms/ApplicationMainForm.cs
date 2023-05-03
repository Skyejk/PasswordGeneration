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
            CustomMessage("Я студент 4 курса, обучающийся на специальности " +
                "'Программирование в компьютерных системах' " +
                "меня зовут Ремезов Кирилл. ",
                aboutMeToolStripMenuItem.Text,
                MessageBoxIcon.Asterisk);
        }

        private void referenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomMessage("Это модуль приложения, " +
                "генерации пароля доступа к данным " +
                "программы на основе ID оборудования",
                referenceToolStripMenuItem.Text,
                MessageBoxIcon.Asterisk);
        }
        public void CustomMessage(string txt, string head, MessageBoxIcon icon)
        {
            MessageBox.Show(txt, head, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
