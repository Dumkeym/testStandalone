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
using System.Xml.Linq;
using DemoAppStandalone.Cards;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoAppStandalone.Forms
{
    public partial class EditOrdersForm : Form
    {
        private bool _isEdit;
        OrderView _ov = new OrderView();
        List<Orders> _o = new List<Orders>();
        public EditOrdersForm(OrderView orderView = null)
        {
            InitializeComponent();

            _isEdit = (orderView != null);
            _ov = orderView;

            LoadPickUpPoints();
            LoadStatuses();
            LoadData();
        }

        private void EditOrdersForm_Load(object sender, EventArgs e)
        {
            labelTitle.Text = (_isEdit) ? "Редактирование заказа" : "Добавление заказа";
            buttonDelete.Visible = _isEdit;  

            labelUserInfo.Text = AuthInfo.UserName;
        }

        private void LoadData()
        {
            try
            {
                if (_isEdit)
                {
                    textBoxArticle.Text = _ov.Article;
                    comboBoxStatus.Text = _ov.Status;
                    comboBoxAddress.SelectedValue = _ov.PUPId;
                    dateTimePickerOrderDate.Value = _ov.DeliveryDate;
                    dateTimePickerDeliveryDate.Value = _ov.DeliveryDate;

                    //GetOrderInfo();
                }
                else
                {
                    dateTimePickerOrderDate.Value = DateTime.Now;
                    dateTimePickerDeliveryDate.Value = DateTime.Now.AddDays(3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при данных.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPickUpPoints()
        {
            try
            {
                DataTable dt = DatabaseHelpers.ExecuteQuery(@"SELECT [ID ПВЗ],
                CONCAT([Индекс], ', ', [Город], ', ', [Адрес], ', ', [Дом]) AS Address
                FROM [ПВЗ]");
                comboBoxAddress.DataSource = dt;
                comboBoxAddress.DisplayMember = "Address";
                comboBoxAddress.ValueMember = "ID ПВЗ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при загрузке списка \"Адреса\".", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatuses()
        {
            try
            {
                DataTable dt = DatabaseHelpers.ExecuteQuery(@"
                SELECT DISTINCT [Статус] FROM [Заказы]");
                foreach (DataRow row in dt.Rows) comboBoxStatus.Items.Add(row[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при загрузке списка \"Статусы\".", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetOrderInfo()
        {
            try
            {
                DataTable dt = DatabaseHelpers.ExecuteQuery(@"SELECT * FROM [Заказы] WHERE [ID заказа] = @id",
                    new SqlParameter("@id", _ov.OrderId));
                _o = dt.AsEnumerable().Select(r => new Orders
                {
                    OrderId = (int)r["ID заказа"],
                    Article = r["Артикул"].ToString(),
                    OrderDate = (DateTime)r["Дата заказа"],
                    DeliveryDate = (DateTime)r["Дата доставки"],
                    PUPId = (int)r["ID ПВЗ"],
                    Surname = r["Фамилия клиента"].ToString(),
                    Name = r["Имя клиента"].ToString(),
                    Patronymic = r["Отчество клиента"].ToString(),
                    DeliveryCode = (int)r["Код получения"],
                    Status = r["Статус"].ToString(),
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при получении данных о заказе.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckProductsInOrder()
        {
            try
            {
                DataTable dt = DatabaseHelpers.ExecuteQuery(@"SELECT TOP 1 p.[ID позиции]
                    FROM [Позиции заказа] p
                    INNER JOIN [Заказы] o ON p.[ID заказа] = o.[ID заказа]
                    WHERE o.[ID заказа] = @orderId",
                    new SqlParameter("@orderId", _ov.OrderId));

                return (dt.Rows.Count > 0) ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка проверки удаления заказа.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        private bool ValidateOrderInfo()
        {
            if (string.IsNullOrWhiteSpace(textBoxArticle.Text))
            {
                MessageBox.Show("Поле \"Артикул\" не должно быть пустым.", "Отказ в изменении данных!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (dateTimePickerDeliveryDate.Value < dateTimePickerOrderDate.Value)
            {
                MessageBox.Show("Дата доставки не может быть раньше даты заказа.", "Отказ в изменении данных!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void SaveOrderChanges()
        {
            try
            {
                DatabaseHelpers.ExecuteNonQuery(@"UPDATE [Заказы]
                    SET [Артикул] = @article, [Дата заказа] = @orderDate, [Дата доставки] = @orderDelivery, [ID ПВЗ] = @PUPId, [Статус] = @status
                    WHERE [ID заказа] = @orderId",
                    new SqlParameter("@article", textBoxArticle.Text),
                    new SqlParameter("@orderDate", dateTimePickerOrderDate.Value),
                    new SqlParameter("@orderDelivery", dateTimePickerDeliveryDate.Value),
                    new SqlParameter("@PUPId", (int)comboBoxAddress.SelectedValue),
                    new SqlParameter("@status", comboBoxStatus.Text),
                    new SqlParameter("@orderId", _ov.OrderId));

                MessageBox.Show("Изменения успешно сохранены.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка изменения заказа.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveNewOrder()
        {
            try
            {
                Random rnd = new Random();
                int deliveryCode = rnd.Next(1, 999);
                string[] FIO = AuthInfo.UserName.Split(' ');

                DatabaseHelpers.ExecuteNonQuery(@"INSERT INTO [Заказы]
                    ([Артикул], [Дата заказа], [Дата доставки], [ID ПВЗ], [Фамилия клиента], [Имя клиента], [Отчество клиента], [Код получения], [Статус])
                    VALUES (@article, @orderDate, @orderDelivery, @PUPId, @surname, @name, @patronymic, @deliveryCode, @status)",
                    new SqlParameter("@article", textBoxArticle.Text),
                    new SqlParameter("@orderDate", dateTimePickerOrderDate.Value),
                    new SqlParameter("@orderDelivery", dateTimePickerDeliveryDate.Value),
                    new SqlParameter("@PUPId", (int)comboBoxAddress.SelectedValue),
                    new SqlParameter("@surname", FIO[0]),
                    new SqlParameter("@name", FIO[1]),
                    new SqlParameter("@patronymic", FIO.Length > 2 ? FIO[2] : ""),
                    new SqlParameter("@deliveryCode", deliveryCode),
                    new SqlParameter("@status", comboBoxStatus.Text));

                MessageBox.Show("Заказ успешно создан.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка создания заказа.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateOrderInfo()) return;

            if(_isEdit) SaveOrderChanges();
            else SaveNewOrder();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CheckProductsInOrder())
            {
                MessageBox.Show("В заказе присутствуют продукты.", "Отказ в удалении заказа!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                DatabaseHelpers.ExecuteNonQuery(@"
                DELETE FROM [Заказы]
                WHERE [ID заказа] = @orderId",
                new SqlParameter("@orderId", _ov.OrderId));

                MessageBox.Show("Заказ успешно удалён.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка удаления заказа.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e) => this.Close();
    }
}
