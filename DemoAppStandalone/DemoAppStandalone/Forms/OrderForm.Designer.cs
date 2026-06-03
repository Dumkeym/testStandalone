namespace DemoAppStandalone.Forms
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.labelFormName = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.labelDummy = new System.Windows.Forms.Label();
            this.fLPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            this.fLPanelProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserInfo.Location = new System.Drawing.Point(507, 1);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(171, 41);
            this.labelUserInfo.TabIndex = 1;
            this.labelUserInfo.Text = "Юрченко Иван Андреевич";
            this.labelUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFormName
            // 
            this.labelFormName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormName.Location = new System.Drawing.Point(3, 6);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(120, 40);
            this.labelFormName.TabIndex = 2;
            this.labelFormName.Text = "Список заказов";
            this.labelFormName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Controls.Add(this.labelFormName);
            this.panelTop.Controls.Add(this.buttonAddOrder);
            this.panelTop.Controls.Add(this.buttonProducts);
            this.panelTop.Controls.Add(this.labelUserInfo);
            this.panelTop.Location = new System.Drawing.Point(3, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(679, 52);
            this.panelTop.TabIndex = 7;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(232, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(97, 23);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddOrder.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddOrder.Location = new System.Drawing.Point(129, 3);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(97, 23);
            this.buttonAddOrder.TabIndex = 11;
            this.buttonAddOrder.Text = "Добавить заказ";
            this.buttonAddOrder.UseVisualStyleBackColor = false;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProducts.Location = new System.Drawing.Point(129, 26);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(97, 23);
            this.buttonProducts.TabIndex = 10;
            this.buttonProducts.Text = "Товары";
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // labelDummy
            // 
            this.labelDummy.AutoSize = true;
            this.labelDummy.Location = new System.Drawing.Point(3, 0);
            this.labelDummy.Name = "labelDummy";
            this.labelDummy.Size = new System.Drawing.Size(51, 14);
            this.labelDummy.TabIndex = 0;
            this.labelDummy.Text = "Заглушка";
            this.labelDummy.Visible = false;
            // 
            // fLPanelProducts
            // 
            this.fLPanelProducts.AutoScroll = true;
            this.fLPanelProducts.Controls.Add(this.labelDummy);
            this.fLPanelProducts.Location = new System.Drawing.Point(3, 55);
            this.fLPanelProducts.Name = "fLPanelProducts";
            this.fLPanelProducts.Size = new System.Drawing.Size(679, 325);
            this.fLPanelProducts.TabIndex = 9;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.fLPanelProducts);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список заказов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panelTop.ResumeLayout(false);
            this.fLPanelProducts.ResumeLayout(false);
            this.fLPanelProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelDummy;
        private System.Windows.Forms.FlowLayoutPanel fLPanelProducts;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonExit;
    }
}