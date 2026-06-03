using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoAppStandalone.Cards;

namespace DemoAppStandalone.Forms
{
    public partial class OrderForm : Form
    {
        private static AuthForm _authForm;
        private static ProductsForm _prodForm;
        List<OrderView> _orderView = new List<OrderView>();
        private bool _isLogout = false;
        public bool _isSwitchToProducts = false;

        public OrderForm(AuthForm authForm, ProductsForm prodForm)
        {
            InitializeComponent();
            LoadData();
            RenderCards(_orderView);

            _authForm = authForm;
            _prodForm = prodForm;
        }

        private void OrderForm_Load(object sender, EventArgs e) => labelUserInfo.Text = AuthInfo.UserName;

        private void LoadData()
        {
            try
            {
                DataTable dt = DatabaseHelpers.ExecuteQuery(@"
                SELECT CONCAT(p.[Индекс], ', ', p.[Город], ', ', p.[Адрес], ', ', p.[Дом]) AS FullAddress, p.[ID ПВЗ], z.*
                FROM [Заказы] z
                INNER JOIN [ПВЗ] p ON z.[ID ПВЗ] = p.[ID ПВЗ]");

                _orderView = dt.AsEnumerable().Select(r => new OrderView
                {
                    OrderId = (int)r["ID заказа"],
                    Article = r["Артикул"].ToString(),
                    Status = r["Статус"].ToString(),
                    FullAddress = r["FullAddress"].ToString(),
                    OrderDate = (DateTime)r["Дата заказа"],
                    DeliveryDate = (DateTime)r["Дата доставки"],
                    PUPId = (int)r["ID ПВЗ"]
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка загрузки данных.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderCards(List<OrderView> orderViews)
        {
            try
            {
                fLPanelProducts.SuspendLayout();
                fLPanelProducts.Controls.Clear();

                foreach (OrderView ov in orderViews)
                {
                    OrderCard card = new OrderCard();
                    card.SetData(ov);

                    card.Click += (s, e) =>
                    {
                        EditOrdersForm editOrdersForm = new EditOrdersForm(ov);
                        if (editOrdersForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadData();
                            RenderCards(_orderView);
                        }
                    };

                    fLPanelProducts.Controls.Add(card);
                }
                fLPanelProducts.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка отображения данных.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти на экран авторизации?", "Выход из профиля.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            else
            {
                FormClosing -= OrderForm_FormClosing;
                Application.Exit();
            }
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            _isSwitchToProducts = true;
            _prodForm.isSwtitchToOrders = false;
            _prodForm.Show();
            this.Close();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            EditOrdersForm editOrdersForm = new EditOrdersForm();
            if(editOrdersForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                RenderCards(_orderView);
            }
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isLogout || _isSwitchToProducts) return;

            if(MessageBox.Show("Закрыть приложение?", "Закрытие приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
            else
            {
                FormClosing -= OrderForm_FormClosing;
                Application.Exit();
            }
        }
    }
}
