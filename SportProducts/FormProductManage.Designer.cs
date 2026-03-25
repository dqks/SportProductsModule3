namespace SportProducts
{
    partial class FormProductManage
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxPrice = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBoxStorageAmount = new TextBox();
            label8 = new Label();
            textBoxDiscount = new TextBox();
            label9 = new Label();
            comboBoxCategory = new ComboBox();
            comboBoxManufacturer = new ComboBox();
            comboBoxSupplier = new ComboBox();
            comboBoxUnitOfMeasurment = new ComboBox();
            labelArticle = new Label();
            textBoxArticle = new TextBox();
            richTextBoxDescription = new RichTextBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonSave);
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 392);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(838, 77);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(67, 97, 238);
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(13, 13);
            buttonSave.Margin = new Padding(13);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(13);
            buttonSave.Size = new Size(150, 50);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(67, 97, 238);
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(189, 13);
            buttonCancel.Margin = new Padding(13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Padding = new Padding(13);
            buttonCancel.Size = new Size(150, 50);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 1;
            label1.Text = "Наименование товара";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(189, 23);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(208, 26);
            textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 3;
            label2.Text = "Категория";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 53);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 19);
            label3.TabIndex = 5;
            label3.Text = "Описание товара";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 146);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 19);
            label4.TabIndex = 7;
            label4.Text = "Производитель";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 186);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 19);
            label5.TabIndex = 9;
            label5.Text = "Поставщик";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(189, 221);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(208, 26);
            textBoxPrice.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 226);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 19);
            label6.TabIndex = 11;
            label6.Text = "Цена";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 266);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(145, 19);
            label7.TabIndex = 13;
            label7.Text = "Единица измерения";
            // 
            // textBoxStorageAmount
            // 
            textBoxStorageAmount.Location = new Point(189, 299);
            textBoxStorageAmount.Name = "textBoxStorageAmount";
            textBoxStorageAmount.Size = new Size(208, 26);
            textBoxStorageAmount.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 306);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 19);
            label8.TabIndex = 15;
            label8.Text = "Количество на складе";
            // 
            // textBoxDiscount
            // 
            textBoxDiscount.Location = new Point(189, 338);
            textBoxDiscount.Name = "textBoxDiscount";
            textBoxDiscount.Size = new Size(208, 26);
            textBoxDiscount.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 346);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(150, 19);
            label9.TabIndex = 17;
            label9.Text = "Действующая скидка";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(189, 101);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 27);
            comboBoxCategory.TabIndex = 19;
            // 
            // comboBoxManufacturer
            // 
            comboBoxManufacturer.FormattingEnabled = true;
            comboBoxManufacturer.Location = new Point(189, 143);
            comboBoxManufacturer.Name = "comboBoxManufacturer";
            comboBoxManufacturer.Size = new Size(121, 27);
            comboBoxManufacturer.TabIndex = 20;
            // 
            // comboBoxSupplier
            // 
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Location = new Point(189, 183);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new Size(121, 27);
            comboBoxSupplier.TabIndex = 21;
            // 
            // comboBoxUnitOfMeasurment
            // 
            comboBoxUnitOfMeasurment.FormattingEnabled = true;
            comboBoxUnitOfMeasurment.Location = new Point(189, 263);
            comboBoxUnitOfMeasurment.Name = "comboBoxUnitOfMeasurment";
            comboBoxUnitOfMeasurment.Size = new Size(121, 27);
            comboBoxUnitOfMeasurment.TabIndex = 22;
            // 
            // labelArticle
            // 
            labelArticle.AutoSize = true;
            labelArticle.Location = new Point(13, 62);
            labelArticle.Margin = new Padding(4, 0, 4, 0);
            labelArticle.Name = "labelArticle";
            labelArticle.Size = new Size(65, 19);
            labelArticle.TabIndex = 23;
            labelArticle.Text = "Ариткул";
            // 
            // textBoxArticle
            // 
            textBoxArticle.Location = new Point(189, 62);
            textBoxArticle.Name = "textBoxArticle";
            textBoxArticle.Size = new Size(208, 26);
            textBoxArticle.TabIndex = 24;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(590, 20);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(225, 96);
            richTextBoxDescription.TabIndex = 25;
            richTextBoxDescription.Text = "";
            // 
            // FormProductManage
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(838, 469);
            Controls.Add(richTextBoxDescription);
            Controls.Add(textBoxArticle);
            Controls.Add(labelArticle);
            Controls.Add(comboBoxUnitOfMeasurment);
            Controls.Add(comboBoxSupplier);
            Controls.Add(comboBoxManufacturer);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxDiscount);
            Controls.Add(label9);
            Controls.Add(textBoxStorageAmount);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormProductManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление продукта";
            Load += FormProductManage_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        public TextBox textBoxName;
        public TextBox textBoxPrice;
        public TextBox textBoxStorageAmount;
        public TextBox textBoxDiscount;
        public ComboBox comboBoxCategory;
        public ComboBox comboBoxManufacturer;
        public ComboBox comboBoxSupplier;
        public ComboBox comboBoxUnitOfMeasurment;
        public TextBox textBoxArticle;
        public Label labelArticle;
        public RichTextBox richTextBoxDescription;
    }
}