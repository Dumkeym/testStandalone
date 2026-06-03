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
    public partial class ProductsForm : Form
    {
        private AuthForm _authForm;
        private List<Product> _products = new List<Product>();
        private bool isLogout = false;
        public bool isSwtitchToOrders = false;

        public ProductsForm(AuthForm authForm)
        {
            InitializeComponent();

            LoadDataFromDB();
            RenderCards(_products);
            SetComboBoxes();

            comboBoxStock.TextChanged += (s, e) => ApplySearchAndSort();
            comboBoxSuppliers.TextChanged += (s, e) => ApplySearchAndSort();
            textBoxSearch.TextChanged += (s, e) => ApplySearchAndSort();

            ApplySearchAndSort();

            _authForm = authForm;
        }

        private void LoadDataFromDB()
        {
            try
            {
                DataTable dt = DatabaseHelpers.ExecuteQuery("SELECT * FROM [Продукты]");

                _products = dt.AsEnumerable().Select(row => new Product
                {
                    Id = (int)row["ID продукта"],
                    Article = row["Артикул"].ToString(),
                    Name = row["Название"].ToString(),
                    Unit = row["Единица измерения"].ToString(),
                    Price = (decimal)row["Цена"],
                    Supplier = row["Поставщик"].ToString(),
                    Manufacturer = row["Производитель"].ToString(),
                    Category = row["Категория"].ToString(),
                    Discount = (decimal)row["Скидка"],
                    Stock = (int)row["Количество"],
                    Description = row["Описание"].ToString(),
                    Photo = row["Фото"].ToString(),
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при получении данных.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderCards(List<Product> products)
        {
            try
            {
                fLPanelProducts.SuspendLayout();
                fLPanelProducts.Controls.Clear();

                foreach(Product product in products)
                {
                    ProductCard card = new ProductCard();
                    card.SetData(product);

                    if (AuthInfo.Role == AuthInfo.UserRole.Administrator)
                    {
                        card.Cursor = Cursors.Hand;

                        card.Click += (s, e) =>
                        {
                            EditProductsForm editProductsForm = new EditProductsForm(product);
                            if (editProductsForm.ShowDialog() == DialogResult.OK)
                            {
                                LoadDataFromDB();
                                ApplySearchAndSort();
                            };
                        };
                    }

                    fLPanelProducts.Controls.Add(card);
                }
                fLPanelProducts.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при отображении товаров.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetComboBoxes()
        {
            try
            {
                var suppliers = _products.Select(p => p.Supplier).Distinct().OrderBy(s => s).ToList();
                comboBoxSuppliers.Items.Clear();
                comboBoxSuppliers.Items.Add("Все поставщики");
                comboBoxSuppliers.Items.AddRange(suppliers.ToArray());
                comboBoxSuppliers.SelectedIndex = 0;
                comboBoxStock.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при подготовке сортировки.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySearchAndSort()
        {
            try
            {
                IEnumerable<Product> query = _products;

                //поиск по товарам
                string search = textBoxSearch.Text.ToLower().Trim();
                if (!string.IsNullOrWhiteSpace(search))
                {
                    var token = search.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    query = query.Where(p => token.All(t => (
                        p.Manufacturer + p.Name + p.Description + p.Unit + p.Category + p.Article + p.Supplier).ToString().ToLower().Contains(t)));
                }

                //сортировка по поставщику
                if(comboBoxSuppliers.SelectedIndex != 0)
                {
                    string supplier = comboBoxSuppliers.SelectedItem.ToString();
                    query = query.Where(p => p.Supplier == supplier);
                }

                if(comboBoxStock.SelectedIndex != 0)
                {
                    if (comboBoxStock.SelectedIndex == 1) query = query.OrderBy(p => p.Stock);
                    if (comboBoxStock.SelectedIndex == 2) query = query.OrderByDescending(p => p.Stock);
                }

                var resultList = query.ToList();

                if (resultList.Count > 0)
                {
                    fLPanelProducts.Visible = true;
                    labelNotFound.Visible = false;
                }
                else
                {
                    fLPanelProducts.Visible = false;
                    labelNotFound.Visible = true;
                }

                RenderCards(resultList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при сортировке.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вернуться на окно авторизации?", "Выход из аккаунта.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isLogout = true;
                _authForm.Show();
                this.Close();
            }
            else
            {
                isLogout = false;
                return;
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            if (AuthInfo.Role != AuthInfo.UserRole.Administrator)
                panelMain.Visible = false;
            if (AuthInfo.Role == AuthInfo.UserRole.Manager)
                buttonAddProduct.Visible = false;

            labelUserInfo.Text = AuthInfo.UserName.ToString();
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogout || isSwtitchToOrders) return;

            if(MessageBox.Show("Вы хотите закрыть приложение?", "Выход из приложения",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
            else
            {
                FormClosing -= ProductsForm_FormClosing;
                Application.Exit();
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            EditProductsForm editProductsForm = new EditProductsForm();
            if (editProductsForm.ShowDialog() == DialogResult.OK)
            {
                LoadDataFromDB();
                ApplySearchAndSort();
            };
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(_authForm, this);
            isSwtitchToOrders = true;
            this.Hide();
            orderForm.Show();
        }
    }
}
