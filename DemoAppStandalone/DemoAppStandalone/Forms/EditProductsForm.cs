using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAppStandalone.Forms
{
    public partial class EditProductsForm : Form
    {
        private Product _p;
        private string _imgName;
        private string _imgToDelete;
        private bool _isEditMode;
        private string _folderPath = Path.Combine(Application.StartupPath, "ProductImages");

        public EditProductsForm(Product product = null)
        {
            InitializeComponent();

            _p = product;
        }

        private void EditProductsForm_Load(object sender, EventArgs e)
        {
            SetComboBoxes();
            LoadInfo();

            if (_p != null)
            {
                _isEditMode = true;
                labelID.Visible = true;
                textBoxID.Visible = true;
                labelTitle.Text = "Редактирование товара";
                this.Text = "Редактирование товара";
            }
            else
            {
                _isEditMode = false;
                buttonDelete.Visible = false;
                labelTitle.Text = "Добавление товара";
                this.Text = "Добавление товара";
            }

            labelUserInfo.Text = AuthInfo.UserName.ToString();
        }

        private void LoadInfo()
        {
            try
            {
                if (_p != null)
                {
                    textBoxID.Text = _p.Id.ToString();
                    textBoxName.Text = _p.Name;
                    textBoxDescription.Text = _p.Description;
                    textBoxSupplier.Text = _p.Supplier;
                    numericUpDownPrice.Value = _p.Price;
                    textBoxUnit.Text = _p.Unit;
                    numericUpDownStock.Value = _p.Stock;
                    numericUpDownDiscount.Value = _p.Discount;
                    comboBoxCategory.SelectedItem = _p.Category;
                    comboBoxManufacturer.SelectedItem = _p.Manufacturer;
                    _imgName = _p.Photo;

                    ShowImage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при получении данных.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowImage()
        {
            try
            {
                string imgFolder = Path.Combine(Application.StartupPath, "ProductImages");
                string imgPath = Path.Combine(imgFolder, _imgName != null ? _imgName : "picture.png");
                pictureBoxProductPhoto.ImageLocation = File.Exists(imgPath) ? imgPath : Path.Combine(imgFolder, "picture.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при получении изображения.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetComboBoxes()
        {
            try
            {
                var categories = DatabaseHelpers.ExecuteQuery(@"SELECT DISTINCT [Категория] FROM [Продукты]");
                foreach (DataRow r in categories.Rows) comboBoxCategory.Items.Add(r[0]);

                var manufacturers = DatabaseHelpers.ExecuteQuery(@"SELECT DISTINCT [Производитель] FROM [Продукты]");
                foreach (DataRow r in manufacturers.Rows) comboBoxManufacturer.Items.Add(r[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при получении списков.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validator()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Поле \"Название\" должно быть обязательно заполнено!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxSupplier.Text))
            {
                MessageBox.Show("Поле \"Поставщик\" должно быть обязательно заполнено!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxUnit.Text))
            {
                MessageBox.Show("Поле \"Единица измерения\" должно быть обязательно заполнено!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show("Поле \"Цена\" должно быть больше 0!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (numericUpDownStock.Value <= 0)
            {
                MessageBox.Show("Поле \"Количество на складе\" должно быть больше 0!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (numericUpDownStock.Value < 0)
            {
                MessageBox.Show("Поле \"Действущая скидка\" должно быть больше, либо равно 0!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validator()) return;

                if(_isEditMode)
                {
                    DatabaseHelpers.ExecuteNonQuery(@"
                        UPDATE [Продукты]
                        SET [Артикул] = @article, [Название] = @name, [Единица измерения] = @unit, [Цена] = @price,
                        [Поставщик] = @supplier, [Производитель] = @manufactirer, [Категория] = @category, [Скидка] = @disount,
                        [Количество] = @stock, [Описание] = @description, [Фото] = @photo
                        WHERE [ID продукта] = @id",
                        new SqlParameter("@article", _p.Article),
                        new SqlParameter("@name", textBoxName.Text),
                        new SqlParameter("@unit", textBoxUnit.Text),
                        new SqlParameter("@price", (decimal)numericUpDownPrice.Value),
                        new SqlParameter("@supplier", textBoxSupplier.Text),
                        new SqlParameter("@category", comboBoxCategory.Text.Trim()),
                        new SqlParameter("@manufactirer", comboBoxManufacturer.Text.Trim()),
                        new SqlParameter("@disount", (decimal)numericUpDownDiscount.Value),
                        new SqlParameter("@stock", (int)numericUpDownStock.Value),
                        new SqlParameter("@description", textBoxDescription.Text),
                        new SqlParameter("@photo", _imgName),
                        new SqlParameter("@id", _p.Id));

                    if(!string.IsNullOrEmpty(_imgToDelete)) File.Delete(Path.Combine(_folderPath, _imgToDelete));

                    MessageBox.Show("Данные успешно обновлены.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Random rnd = new Random();
                    string rndArticle = rnd.Next(1, 1000000).ToString() + (char)rnd.Next('A', 'Z') + (char)rnd.Next('A', 'Z');

                    DatabaseHelpers.ExecuteNonQuery(@"
                        INSERT INTO [Продукты]
                        ([Артикул], [Название], [Единица измерения], [Цена], [Поставщик],
                        [Производитель], [Категория], [Скидка], [Количество], [Описание], [Фото])
                        VALUES(@article, @name, @unit, @price, @supplier, @manufactirer, @category,
                        @disount, @stock, @description, @photo)",
                        new SqlParameter("@article", rndArticle),
                        new SqlParameter("@name", textBoxName.Text),
                        new SqlParameter("@unit", textBoxUnit.Text),
                        new SqlParameter("@price", (decimal)numericUpDownPrice.Value),
                        new SqlParameter("@supplier", textBoxSupplier.Text),
                        new SqlParameter("@manufactirer", comboBoxManufacturer.Text.Trim()),
                        new SqlParameter("@category", comboBoxCategory.Text.Trim()),
                        new SqlParameter("@disount", (decimal)numericUpDownDiscount.Value),
                        new SqlParameter("@stock", (int)numericUpDownStock.Value),
                        new SqlParameter("@description", textBoxDescription.Text),
                        new SqlParameter("@photo", (object)_imgName ?? DBNull.Value));

                    MessageBox.Show("Данные успешно обновлены.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при сохранении данных.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DatabaseHelpers.ExecuteQuery("SELECT TOP 1 [ID позиции] FROM [Позиции заказа] WHERE [ID заказа] = @id",
                new SqlParameter("@id", _p.Id));

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Данный товар находится в заказе. Удаление невозможно.", "Товар находится в заказе!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DatabaseHelpers.ExecuteNonQuery("DELETE FROM [Продукты] WHERE [ID продукта] = @id",
                    new SqlParameter("@id", _p.Id));

                _imgToDelete = _imgName;
                if (!string.IsNullOrEmpty(_imgToDelete)) File.Delete(Path.Combine(_folderPath, _imgToDelete));

                MessageBox.Show("Данные успешно удалены.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при удалении данных.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddPicture_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog {Filter = "Images | *.png;*.jpg;*.jpeg"};
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var img = Image.FromFile(ofd.FileName))
                        if (img.Height > 200 || img.Width > 300)
                        {
                            MessageBox.Show("Изображение должно быть размером не более 300х200 пикселей", "Ошибка при добавлении изображения.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                    string newFile = Path.GetFileName(ofd.FileName);
                    string destPath = Path.Combine(_folderPath, newFile);

                    if (!string.IsNullOrEmpty(_imgName) && _imgName != newFile)
                        _imgToDelete = _imgName;

                    File.Copy(ofd.FileName, destPath, true);

                    _imgName = newFile;
                    ShowImage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при добавлении фото.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e) => this.Close();
    }
}
