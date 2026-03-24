using SportProducts.Models;

namespace SportProducts
{
    public partial class FormProductManage : Form
    {
        Product product;

        public FormProductManage()
        {
            InitializeComponent();
        }

        public FormProductManage(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void FormProductManage_Load(object sender, EventArgs e)
        {

            using (var db = new SportProductsContext())
            {
                var categories = db.ProductCategories.ToList();

                comboBoxCategory.DataSource = categories;
                comboBoxCategory.DisplayMember = "CategoryName";
                comboBoxCategory.ValueMember = "Id";


                var manufacturers = db.Manufacturers.ToList();
                comboBoxManufacturer.DataSource = manufacturers;
                comboBoxManufacturer.DisplayMember = "ManufacturerName";
                comboBoxManufacturer.ValueMember = "Id";

                var suppliers = db.Suppliers.ToList();
                comboBoxSupplier.DataSource = suppliers;
                comboBoxSupplier.DisplayMember = "SupplierName";
                comboBoxSupplier.ValueMember = "Id";

                var unitOfMeasurments = db.UnitOfMeasurments.ToList();
                comboBoxUnitOfMeasurment.DataSource = unitOfMeasurments;
                comboBoxUnitOfMeasurment.DisplayMember = "UnitName";
                comboBoxUnitOfMeasurment.ValueMember = "Id";
            }

        }
    }
}
