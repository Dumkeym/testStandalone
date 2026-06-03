using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoAppStandalone;
using DemoAppStandalone.Forms;

namespace DemoAppStandalone
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBoxLogin.Text.Trim();
                string password = textBoxPassword.Text.Trim();

                DataTable dt = DatabaseHelpers.ExecuteQuery(
                    @"SELECT TOP 1 [Роль], CONCAT_WS(' ', [Фамилия], [Имя], [Отчество]) AS FIO
                    FROM [Пользователи]
                    WHERE [Логин] = @login AND [Пароль] = @password",
                    new SqlParameter("@login", login), new SqlParameter("@password", password));

                if(dt.Rows.Count > 0)
                {
                    AuthInfo.UserName = dt.Rows[0]["FIO"].ToString();
                    GetRole(dt.Rows[0]["Роль"].ToString());

                    ProductsForm prodForm = new ProductsForm(this);
                    Cleaner();
                    prodForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль.", "Ошибка авторизации!");
                    textBoxPassword.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка авторизации!");
            }
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            ProductsForm prodForm = new ProductsForm(this);
            AuthInfo.Role = AuthInfo.UserRole.Guest;
            AuthInfo.UserName = "Гость";

            Cleaner();
            prodForm.Show();
            this.Hide();
        }

        private void Cleaner()
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }

        private void GetRole(string role)
        {
            if (role.ToLower().Contains("администратор")) AuthInfo.Role = AuthInfo.UserRole.Administrator;
            else if (role.ToLower().Contains("менеджер")) AuthInfo.Role = AuthInfo.UserRole.Manager;
            else AuthInfo.Role = AuthInfo.UserRole.Client;
        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}
