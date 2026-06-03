using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAppStandalone.Cards
{
    public partial class OrderCard : UserControl
    {
        public OrderCard()
        {
            InitializeComponent();
            ApplyClickToAll(this);
            this.Cursor = Cursors.Hand;
        }

        public void SetData(OrderView order)
        {
            labelArticle.Text = order.Article;
            labelStatus.Text = order.Status;
            labelAddress.Text = order.FullAddress;
            labelOrderDate.Text = order.OrderDate.ToShortDateString();
            labelDeliveryDate.Text = order.DeliveryDate.ToShortDateString();
        }

        private void ApplyClickToAll(Control control)
        {
            foreach (Control c  in control.Controls)
            {
                c.Click += (s, e) => this.OnClick(e);
                if (c.HasChildren) ApplyClickToAll(c);
            }
        }
    }
}
