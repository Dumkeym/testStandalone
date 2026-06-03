using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAppStandalone.Cards
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
            ApplyClickToAll(this);
        }

       public void SetData(Product p)
        {
            labelNameValue.Text = p.Name;
            labelUnitValue.Text = p.Unit;
            labelPriceValue.Text = p.Price.ToString("F2");
            labelSupplierValue.Text = p.Supplier;
            labelManufacturerValue.Text = p.Manufacturer;
            labelCategoryValue.Text = p.Category;
            labelDiscountValue.Text = p.Discount.ToString("F2") + "%";
            labelStockValue.Text = p.Stock.ToString();
            labelDescriptionValue.Text = p.Description;

            string imgPath = Path.Combine(Application.StartupPath, "ProductImages");
            string path = Path.Combine(imgPath, p.Photo != null ? p.Photo : "picture.png");
            pictureBoxLeft.ImageLocation = File.Exists(path) ? path : Path.Combine(imgPath, "picture.png");

            if (p.Discount > 0)
            {
                decimal newPrice = p.Price - (p.Price / 100 * p.Discount);
                labelDiscountPriceValue.Visible = true;
                labelDiscountPriceValue.Text = newPrice.ToString("F2");
                labelPriceValue.ForeColor = Color.Red;
                labelPriceValue.Font = new Font(labelPrice.Font, FontStyle.Strikeout);
            }

            if (p.Stock <= 0)
            {
                SetColorRecursive(this, Color.SkyBlue);
            }

            if(p.Discount > 15)
            {
                SetColorRecursive(panelRight, Color.SeaGreen);
            }

            //panelRight.BackColor = p.Discount > 15 ? Color.SeaGreen : Color.White;
        }

        private void ApplyClickToAll(Control control)
        {
            foreach(Control c in control.Controls)
            {
                c.Click += (s, e) => this.OnClick(e);
                if (c.HasChildren) ApplyClickToAll(c);
            }
        }

        private void SetColorRecursive(Control parent, Color color)
        {
            parent.BackColor = color;
            foreach (Control child in parent.Controls) SetColorRecursive(child, color);
        }
    }
}
