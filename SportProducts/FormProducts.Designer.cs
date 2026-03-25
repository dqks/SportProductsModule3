namespace SportProducts
{
    partial class FormProducts
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
            panelTop = new Panel();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            labelName = new Label();
            buttonLogout = new Button();
            dataGridViewProducts = new DataGridView();
            flowLayoutPanelFilter = new FlowLayoutPanel();
            textBoxNameFilter = new TextBox();
            comboBoxSupplierFilter = new ComboBox();
            comboBoxAmountFilter = new ComboBox();
            panelTop.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            flowLayoutPanelFilter.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(233, 245, 255);
            panelTop.Controls.Add(flowLayoutPanelButtons);
            panelTop.Controls.Add(labelName);
            panelTop.Controls.Add(buttonLogout);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(964, 97);
            panelTop.TabIndex = 0;
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(buttonAdd);
            flowLayoutPanelButtons.Controls.Add(buttonEdit);
            flowLayoutPanelButtons.Controls.Add(buttonDelete);
            flowLayoutPanelButtons.Dock = DockStyle.Left;
            flowLayoutPanelButtons.Location = new Point(10, 10);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(581, 77);
            flowLayoutPanelButtons.TabIndex = 11;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(67, 97, 238);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(10, 10);
            buttonAdd.Margin = new Padding(10);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Padding = new Padding(10);
            buttonAdd.Size = new Size(135, 58);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(67, 97, 238);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(165, 10);
            buttonEdit.Margin = new Padding(10);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(10);
            buttonEdit.Size = new Size(162, 58);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += ButtonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(67, 97, 238);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(347, 10);
            buttonDelete.Margin = new Padding(10);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(10);
            buttonDelete.Size = new Size(135, 58);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Right;
            labelName.Location = new Point(774, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(45, 19);
            labelName.TabIndex = 7;
            labelName.Text = "label1";
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(67, 97, 238);
            buttonLogout.Dock = DockStyle.Right;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(819, 10);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(135, 77);
            buttonLogout.TabIndex = 6;
            buttonLogout.Text = "Выйти";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += ButtonLogout_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToOrderColumns = true;
            dataGridViewProducts.AllowUserToResizeColumns = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.ColumnHeadersVisible = false;
            dataGridViewProducts.Dock = DockStyle.Right;
            dataGridViewProducts.Location = new Point(320, 107);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(654, 444);
            dataGridViewProducts.TabIndex = 1;
            // 
            // flowLayoutPanelFilter
            // 
            flowLayoutPanelFilter.Controls.Add(textBoxNameFilter);
            flowLayoutPanelFilter.Controls.Add(comboBoxSupplierFilter);
            flowLayoutPanelFilter.Controls.Add(comboBoxAmountFilter);
            flowLayoutPanelFilter.Dock = DockStyle.Left;
            flowLayoutPanelFilter.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelFilter.Location = new Point(10, 107);
            flowLayoutPanelFilter.Name = "flowLayoutPanelFilter";
            flowLayoutPanelFilter.Padding = new Padding(10);
            flowLayoutPanelFilter.Size = new Size(304, 444);
            flowLayoutPanelFilter.TabIndex = 2;
            // 
            // textBoxNameFilter
            // 
            textBoxNameFilter.Location = new Point(13, 13);
            textBoxNameFilter.Name = "textBoxNameFilter";
            textBoxNameFilter.PlaceholderText = "Название продукта";
            textBoxNameFilter.Size = new Size(279, 26);
            textBoxNameFilter.TabIndex = 0;
            // 
            // comboBoxSupplierFilter
            // 
            comboBoxSupplierFilter.FormattingEnabled = true;
            comboBoxSupplierFilter.Location = new Point(13, 45);
            comboBoxSupplierFilter.Name = "comboBoxSupplierFilter";
            comboBoxSupplierFilter.Size = new Size(279, 27);
            comboBoxSupplierFilter.TabIndex = 1;
            // 
            // comboBoxAmountFilter
            // 
            comboBoxAmountFilter.FormattingEnabled = true;
            comboBoxAmountFilter.Location = new Point(13, 78);
            comboBoxAmountFilter.Name = "comboBoxAmountFilter";
            comboBoxAmountFilter.Size = new Size(279, 27);
            comboBoxAmountFilter.TabIndex = 2;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(flowLayoutPanelFilter);
            Controls.Add(dataGridViewProducts);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormProducts";
            Padding = new Padding(10);
            Text = "Товары";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            flowLayoutPanelFilter.ResumeLayout(false);
            flowLayoutPanelFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button buttonLogout;
        private Label labelName;
        private DataGridView dataGridViewProducts;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private FlowLayoutPanel flowLayoutPanelButtons;
        private FlowLayoutPanel flowLayoutPanelFilter;
        private TextBox textBoxNameFilter;
        private ComboBox comboBoxSupplierFilter;
        private ComboBox comboBoxAmountFilter;
    }
}