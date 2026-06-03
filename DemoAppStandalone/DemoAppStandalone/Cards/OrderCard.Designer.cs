namespace DemoAppStandalone.Cards
{
    partial class OrderCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tLPanelOrderInfo = new System.Windows.Forms.TableLayoutPanel();
            this.labelArticle = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.labelDeliveryDate = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tLPanelOrderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.tLPanelOrderInfo);
            this.panelLeft.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(222, 124);
            this.panelLeft.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.labelDeliveryDate);
            this.panelRight.Location = new System.Drawing.Point(226, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(91, 124);
            this.panelRight.TabIndex = 1;
            // 
            // tLPanelOrderInfo
            // 
            this.tLPanelOrderInfo.ColumnCount = 1;
            this.tLPanelOrderInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanelOrderInfo.Controls.Add(this.labelOrderDate, 0, 3);
            this.tLPanelOrderInfo.Controls.Add(this.labelAddress, 0, 2);
            this.tLPanelOrderInfo.Controls.Add(this.labelStatus, 0, 1);
            this.tLPanelOrderInfo.Controls.Add(this.labelArticle, 0, 0);
            this.tLPanelOrderInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tLPanelOrderInfo.Location = new System.Drawing.Point(3, 3);
            this.tLPanelOrderInfo.Name = "tLPanelOrderInfo";
            this.tLPanelOrderInfo.RowCount = 4;
            this.tLPanelOrderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.10204F));
            this.tLPanelOrderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.89796F));
            this.tLPanelOrderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tLPanelOrderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tLPanelOrderInfo.Size = new System.Drawing.Size(213, 116);
            this.tLPanelOrderInfo.TabIndex = 0;
            // 
            // labelArticle
            // 
            this.labelArticle.AutoSize = true;
            this.labelArticle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArticle.Location = new System.Drawing.Point(3, 0);
            this.labelArticle.Name = "labelArticle";
            this.labelArticle.Size = new System.Drawing.Size(55, 15);
            this.labelArticle.TabIndex = 0;
            this.labelArticle.Text = "Артикул";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(3, 27);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(81, 15);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Статус заказа";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(3, 49);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(69, 15);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Адрес ПВЗ";
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(3, 88);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(70, 15);
            this.labelOrderDate.TabIndex = 3;
            this.labelOrderDate.Text = "Дата заказа";
            // 
            // labelDeliveryDate
            // 
            this.labelDeliveryDate.AutoSize = true;
            this.labelDeliveryDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeliveryDate.Location = new System.Drawing.Point(14, 52);
            this.labelDeliveryDate.Name = "labelDeliveryDate";
            this.labelDeliveryDate.Size = new System.Drawing.Size(61, 15);
            this.labelDeliveryDate.TabIndex = 4;
            this.labelDeliveryDate.Text = "07.07.2007";
            // 
            // OrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "OrderCard";
            this.Size = new System.Drawing.Size(320, 130);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.tLPanelOrderInfo.ResumeLayout(false);
            this.tLPanelOrderInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tLPanelOrderInfo;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.Label labelDeliveryDate;
    }
}
