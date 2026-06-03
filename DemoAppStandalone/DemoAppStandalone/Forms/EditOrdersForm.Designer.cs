namespace DemoAppStandalone.Forms
{
    partial class EditOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrdersForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.labelDeliveryDate = new System.Windows.Forms.Label();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelArticle = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelAddress = new System.Windows.Forms.Panel();
            this.panelStatus.SuspendLayout();
            this.panelAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(12, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(163, 19);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Редактирование заказа";
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserInfo.Location = new System.Drawing.Point(281, 3);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(188, 41);
            this.labelUserInfo.TabIndex = 8;
            this.labelUserInfo.Text = "Юрченко Иван Андреевич";
            this.labelUserInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDeliveryDate
            // 
            this.labelDeliveryDate.AutoSize = true;
            this.labelDeliveryDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeliveryDate.Location = new System.Drawing.Point(13, 193);
            this.labelDeliveryDate.Name = "labelDeliveryDate";
            this.labelDeliveryDate.Size = new System.Drawing.Size(100, 17);
            this.labelDeliveryDate.TabIndex = 17;
            this.labelDeliveryDate.Text = "Дата доставки";
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderDate.Location = new System.Drawing.Point(13, 162);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(83, 17);
            this.labelOrderDate.TabIndex = 16;
            this.labelOrderDate.Text = "Дата заказа";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(13, 131);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(144, 17);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Адрес пункта выдачи";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(13, 99);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(53, 17);
            this.labelStatus.TabIndex = 14;
            this.labelStatus.Text = "Статус";
            // 
            // labelArticle
            // 
            this.labelArticle.AutoSize = true;
            this.labelArticle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArticle.Location = new System.Drawing.Point(13, 67);
            this.labelArticle.Name = "labelArticle";
            this.labelArticle.Size = new System.Drawing.Size(60, 17);
            this.labelArticle.TabIndex = 13;
            this.labelArticle.Text = "Артикул";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.White;
            this.comboBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(158, 23);
            this.comboBoxStatus.TabIndex = 22;
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.BackColor = System.Drawing.Color.White;
            this.textBoxArticle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArticle.Location = new System.Drawing.Point(159, 65);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(160, 22);
            this.textBoxArticle.TabIndex = 21;
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(158, 158);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(161, 22);
            this.dateTimePickerOrderDate.TabIndex = 24;
            // 
            // dateTimePickerDeliveryDate
            // 
            this.dateTimePickerDeliveryDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDeliveryDate.Location = new System.Drawing.Point(158, 189);
            this.dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            this.dateTimePickerDeliveryDate.Size = new System.Drawing.Size(161, 22);
            this.dateTimePickerDeliveryDate.TabIndex = 25;
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.BackColor = System.Drawing.Color.White;
            this.comboBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(0, 0);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(294, 23);
            this.comboBoxAddress.TabIndex = 26;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(17, 270);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(158, 34);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(16, 230);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(158, 34);
            this.buttonSave.TabIndex = 33;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(344, 230);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(116, 74);
            this.buttonExit.TabIndex = 32;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.comboBoxStatus);
            this.panelStatus.Location = new System.Drawing.Point(158, 99);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(160, 24);
            this.panelStatus.TabIndex = 35;
            // 
            // panelAddress
            // 
            this.panelAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddress.Controls.Add(this.comboBoxAddress);
            this.panelAddress.Location = new System.Drawing.Point(159, 129);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(296, 21);
            this.panelAddress.TabIndex = 36;
            // 
            // EditOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 311);
            this.Controls.Add(this.panelAddress);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dateTimePickerDeliveryDate);
            this.Controls.Add(this.dateTimePickerOrderDate);
            this.Controls.Add(this.textBoxArticle);
            this.Controls.Add(this.labelDeliveryDate);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelArticle);
            this.Controls.Add(this.labelUserInfo);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EditOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление/редактирование заказа";
            this.Load += new System.EventHandler(this.EditOrdersForm_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelAddress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.Label labelDeliveryDate;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeliveryDate;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelAddress;
    }
}