using Microsoft.EntityFrameworkCore;
using SportProducts.Models;
using SportProducts.Properties;

namespace SportProducts
{
    public partial class FormProducts : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormProducts(User user, bool isGuest)
        {
            InitializeComponent();

            CurrentUser = user;
            IsGuest = isGuest;
            if (!isGuest)
            {
                labelName.Text = user.LastName + " " + user.FirstName + " " + user.Patronymic;
            }
            else
            {
                labelName.Text = "Гость";
            }

            using (var db = new SportProductsContext())
            {
                if (user != null)
                {
                    string roleName = db.Roles.Where(w => w.Id == user.IdRole).First().RoleName;
                    if (roleName != "Администратор")
                    {
                        flowLayoutPanelButtons.Visible = false;
                    }

                    if (roleName == "Авторизованный пользователь")
                    {
                        flowLayoutPanelFilter.Visible = false;
                    }
                }

                if (isGuest)
                {
                    flowLayoutPanelFilter.Visible = false;
                    flowLayoutPanelButtons.Visible = false;
                }
            }


            var colId = new DataGridViewTextBoxColumn();
            colId.Visible = false;
            colId.Name = "colId";

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.Width = 200;
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.FillWeight = 30;


            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            colInfo.FillWeight = 50;

            var colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "colDiscount";
            colDiscount.FillWeight = 20;

            dataGridViewProducts.Columns.AddRange([colId, colPhoto, colInfo, colDiscount]);

            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                using (var db = new SportProductsContext())
                {

                    var products = db.Products
                        .Include(i => i.IdManufacturerNavigation)
                        .Include(i => i.IdCategoryNavigation)
                        .Include(i => i.IdSupplierNavigation)
                        .Include(i => i.IdUnitOfMeasurmentNavigation);

                    dataGridViewProducts.SuspendLayout();
                    dataGridViewProducts.Rows.Clear();

                    foreach (var product in products)
                    {
                        int rowIndex = dataGridViewProducts.Rows.Add();
                        var row = dataGridViewProducts.Rows[rowIndex];

                        //if (String.IsNullOrEmpty(product.photoUrl))
                        //{

                        //} else
                        //{

                        // В импортах не указано поле для фото, поэтому только заглушка

                        row.Cells["colId"].Value = product.Id;

                        row.Cells["colPhoto"].Value = Resources.Picture;
                        //}

                        row.Cells["colInfo"].Value = LoadInfo(product);

                        row.Cells["colDiscount"].Value = product.Discount + "%";

                        if (product.Discount > 15)
                        {
                            row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2EC4B6");
                        }

                        if (product.StorageAmount <= 0)
                        {
                            row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E9F5FF");
                        }

                    }

                    dataGridViewProducts.ResumeLayout();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private object LoadInfo(Product product)
        {
            string priceText;

            if (product.Discount > 0)
            {
                priceText = "Цена: " + product.Price + " -> " + product.Price * (100 - product.Discount) / 100;
            }
            else
            {
                priceText = "Цена: " + product.Price;
            }

            return product.Name + " | " + product.IdCategoryNavigation.CategoryName + Environment.NewLine +
                "Описание: " + product.Description + Environment.NewLine +
                "Производитель: " + product.IdManufacturerNavigation.ManufacturerName + Environment.NewLine +
                "Поставщик: " + product.IdSupplierNavigation.SupplierName + Environment.NewLine +
                priceText + Environment.NewLine +
                "Единица измерения: " + product.IdUnitOfMeasurmentNavigation.UnitName + Environment.NewLine +
                "Количество на складе: " + product.StorageAmount + Environment.NewLine;
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            this.Hide();

            form.FormClosed += (s, args) =>
            {
                this.Close();
            };

            form.Show();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormProductManage form = new FormProductManage();

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (result == DialogResult.OK)
            {

                using (var db = new SportProductsContext())
                {
                    try
                    {
                        if (
                            form.comboBoxCategory.SelectedValue == null ||
                            form.comboBoxManufacturer.SelectedValue == null ||
                            form.comboBoxSupplier.SelectedValue == null ||
                            form.comboBoxUnitOfMeasurment.SelectedValue == null ||
                            String.IsNullOrEmpty(form.textBoxArticle.Text) ||
                            String.IsNullOrEmpty(form.textBoxDiscount.Text) ||
                            String.IsNullOrEmpty(form.textBoxName.Text) ||
                            String.IsNullOrEmpty(form.textBoxPrice.Text) ||
                            String.IsNullOrEmpty(form.textBoxStorageAmount.Text) ||
                            String.IsNullOrEmpty(form.richTextBoxDescription.Text)
                        )
                        {
                            throw new Exception("Введены неправильные данные или поля пустые");
                        }


                        Product checkArticleProduct = db.Products.FirstOrDefault(x => x.Article == form.textBoxArticle.Text);

                        if (checkArticleProduct != null)
                        {
                            throw new Exception("Продукт с таким артикулем уже есть");
                        }

                        Product product = new Product
                        {
                            Article = form.textBoxArticle.Text,
                            Description = form.richTextBoxDescription.Text,
                            Discount = Int32.Parse(form.textBoxDiscount.Text),
                            Name = form.textBoxName.Text,
                            Price = Int32.Parse(form.textBoxPrice.Text),
                            StorageAmount = Int32.Parse(form.textBoxStorageAmount.Text),
                            IdCategory = (int)form.comboBoxCategory.SelectedValue,
                            IdSupplier = (int)form.comboBoxSupplier.SelectedValue,
                            IdManufacturer = (int)form.comboBoxManufacturer.SelectedValue,
                            IdUnitOfMeasurment = (int)form.comboBoxUnitOfMeasurment.SelectedValue
                        };


                        db.Add(product);
                        db.SaveChanges();
                        LoadProducts();

                        MessageBox.Show("Продукт создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message,
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }


                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new SportProductsContext())
            {
                int id = (int)dataGridViewProducts.SelectedRows[0].Cells["colId"].Value;

                Product product = db.Products.FirstOrDefault(x => x.Id == id);

                FormProductManage form = new FormProductManage(product);

                DialogResult result = form.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    return;
                }

                if (result == DialogResult.OK)
                {

                    try
                    {
                        if (
                            form.comboBoxCategory.SelectedValue == null ||
                            form.comboBoxManufacturer.SelectedValue == null ||
                            form.comboBoxSupplier.SelectedValue == null ||
                            form.comboBoxUnitOfMeasurment.SelectedValue == null ||
                            String.IsNullOrEmpty(form.textBoxArticle.Text) ||
                            String.IsNullOrEmpty(form.textBoxDiscount.Text) ||
                            String.IsNullOrEmpty(form.textBoxName.Text) ||
                            String.IsNullOrEmpty(form.textBoxPrice.Text) ||
                            String.IsNullOrEmpty(form.textBoxStorageAmount.Text) ||
                            String.IsNullOrEmpty(form.richTextBoxDescription.Text)
                        )
                        {
                            throw new Exception("Введены неправильные данные или поля пустые");
                        }

                        Product checkArticleProduct = db.Products.FirstOrDefault(x => x.Article == form.textBoxArticle.Text);

                        if (checkArticleProduct != null && checkArticleProduct.Id != id)
                        {
                            throw new Exception("Продукт с таким артикулем уже есть");
                        }

                        product.IdManufacturer = (int)form.comboBoxManufacturer.SelectedValue;
                        product.IdSupplier = (int)form.comboBoxSupplier.SelectedValue;
                        product.IdCategory = (int)form.comboBoxCategory.SelectedValue;
                        product.IdUnitOfMeasurment = (int)form.comboBoxUnitOfMeasurment.SelectedValue;
                        product.Article = form.textBoxArticle.Text;
                        product.Discount = Int32.Parse(form.textBoxDiscount.Text);
                        product.Name = form.textBoxName.Text;
                        product.Price = Decimal.Parse(form.textBoxPrice.Text);
                        product.StorageAmount = Int32.Parse(form.textBoxStorageAmount.Text);
                        product.Description = form.richTextBoxDescription.Text;

                        db.SaveChanges();
                        LoadProducts();
                        MessageBox.Show("Продукт изменен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message,
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show(
                "Вы действительно хотите удалить продукт",
                "Подтверждение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Cancel)
            {
                return;
            }

            using (var db = new SportProductsContext())
            {
                int id = (int)dataGridViewProducts.SelectedRows[0].Cells["colId"].Value;

                Product product = db.Products.FirstOrDefault(x => x.Id == id);

                int ordersCount = db.ProductOrders.Where(w => w.IdProduct == product.Id).Count();

                if (ordersCount > 0)
                {
                    MessageBox.Show(
                        "Данный товар находится в заказе",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                db.Products.Remove(product);
                db.SaveChanges();
                LoadProducts();

                MessageBox.Show(
                    "Товар удален",
                    "Успех",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
