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
                }

                if (isGuest)
                {
                    flowLayoutPanelButtons.Visible = false;
                }
            }


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

            dataGridViewProducts.Columns.AddRange([colPhoto, colInfo, colDiscount]);

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

                    foreach (var product in products)
                    {
                        int rowIndex = dataGridViewProducts.Rows.Add();
                        var row = dataGridViewProducts.Rows[rowIndex];

                        //if (String.IsNullOrEmpty(product.photoUrl))
                        //{

                        //} else
                        //{

                        // В импортах не указано поле для фото, поэтому только заглушка
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
            catch (Exception ex) {
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
                priceText = "Цена: " + product.Price + " -> " + product.Price * (100  - product.Discount) / 100;
            } else
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
    }
}
