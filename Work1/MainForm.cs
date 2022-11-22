using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
             //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            AuthTo authto = new AuthTo();
            //Вызов формы в режиме диалога
            authto.ShowDialog();
            //Если авторизации была успешна и в поле класса хранится истина, то делаем движуху:
            if(Auth.auth)
            {
                //Отображаем рабочую форму
                this.Show();
            }
            //иначе
            else
            {
                //Закрываем форму
                this.Close();
            }
            //PanelBus.Visible = false;
            //PanelTram.Visible = false;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
