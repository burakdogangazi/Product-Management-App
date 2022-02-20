using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private static string username = "BurakDogan";
        private static string password = "Burak123@!";

        Thread thread;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenNewForm(object obj)
        {
            Application.Run(new Form2());
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            string userName = tbxUserName.Text;
            string passWord = tbxPassword.Text;

            if (userName == username && passWord == password)
            {
                MessageBox.Show("Giriş Başarılı.\nHoşgeldiniz!");
                this.Close();

                thread = new Thread(OpenNewForm);

                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

            }

            else
            {
                MessageBox.Show("Giriş Başarısız.\nŞifre veya Kullanıcı Adı Hatalı");
            }
        }
    }
}
