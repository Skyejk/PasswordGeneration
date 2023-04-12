using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardPRO
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();

            PanelHeaderSettings();
            AuthorizationFormSettings();
        }

        /// <summary>
        /// 
        /// Configuring the UI
        /// 
        /// </summary>
        public void PanelHeaderSettings()//Настройка панели
        {
            headerText.Text = this.Text;
            BTExit.FlatAppearance.BorderSize = 0;
            BTExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 0, 75);
            BTExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(175, 0, 35);
            BTMinBox.FlatAppearance.BorderSize = 0;
            BTMinBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 150, 200);
            BTMinBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 100, 175);
        }
        public void AuthorizationFormSettings()//Настройка формы
        {
            Opacity = .90;
            PBView.Visible = false;
            TBPassword.MaxLength = 50;
            TBLogin.MaxLength = 50;
        }
}
}
