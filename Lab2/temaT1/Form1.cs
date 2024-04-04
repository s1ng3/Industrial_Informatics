using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace temaT1
{
    public partial class Form1 : Form
    {
        private ComboBox txtProdus;
        private Button btnAdauga;
        private ListBox lstCumparaturi;
        private CheckBox chkCumparat;
        private Button btnSterge;
        private ComboBox cmbCategorie;
        private NumericUpDown numCantitate;
        private Label lblTotalCost;
        private decimal totalCost = 0;

        private ProductData productData;

        public Form1()
        {
            InitializeComponent();

            productData = new ProductData();

            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Text = "Lista de Cumpărături";

            this.cmbCategorie = new ComboBox();
            this.cmbCategorie.Location = new System.Drawing.Point(20, 20);
            this.cmbCategorie.Size = new System.Drawing.Size(100, 20);
            this.cmbCategorie.Items.AddRange(productData.ProductPrices.Keys.ToArray());
            this.cmbCategorie.SelectedIndex = 0;
            this.cmbCategorie.SelectedIndexChanged += new EventHandler(cmbCategorie_SelectedIndexChanged);
            this.Controls.Add(this.cmbCategorie);

            this.txtProdus = new ComboBox();
            this.txtProdus.Location = new System.Drawing.Point(180, 20);
            this.txtProdus.Size = new System.Drawing.Size(150, 20);
            this.txtProdus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(this.txtProdus);

            this.numCantitate = new NumericUpDown();
            this.numCantitate.Location = new System.Drawing.Point(300, 20);
            this.numCantitate.Size = new System.Drawing.Size(50, 20);
            this.numCantitate.Minimum = 1;
            this.Controls.Add(this.numCantitate);

            this.btnAdauga = new Button();
            this.btnAdauga.Location = new System.Drawing.Point(360, 20);
            this.btnAdauga.Size = new System.Drawing.Size(80, 20);
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.Click += new EventHandler(btnAdauga_Click);
            this.Controls.Add(this.btnAdauga);

            this.lstCumparaturi = new ListBox();
            this.lstCumparaturi.Location = new System.Drawing.Point(20, 60);
            this.lstCumparaturi.Size = new System.Drawing.Size(420, 120);
            this.Controls.Add(this.lstCumparaturi);

            this.chkCumparat = new CheckBox();
            this.chkCumparat.Location = new System.Drawing.Point(20, 190);
            this.chkCumparat.Text = "Produs cumpărat";
            this.Controls.Add(this.chkCumparat);

            this.btnSterge = new Button();
            this.btnSterge.Location = new System.Drawing.Point(180, 190);
            this.btnSterge.Size = new System.Drawing.Size(80, 20);
            this.btnSterge.Text = "Șterge";
            this.btnSterge.Click += new EventHandler(btnSterge_Click);
            this.Controls.Add(this.btnSterge);

            this.lblTotalCost = new Label();
            this.lblTotalCost.Location = new System.Drawing.Point(300, 190);
            this.lblTotalCost.Size = new System.Drawing.Size(140, 20);
            this.lblTotalCost.Text = "Cost total: $0.00";
            this.Controls.Add(this.lblTotalCost);

            Button btnExit = new Button();
            btnExit.Location = new System.Drawing.Point(350, 245);
            btnExit.Size = new System.Drawing.Size(70, 30);
            btnExit.Text = "Exit";
            btnExit.Click += new EventHandler(btnExit_Click);
            this.Controls.Add(btnExit);

            this.ResumeLayout(false);
        }

        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategorie.SelectedItem.ToString();
            if (productData.ProductPrices.ContainsKey(selectedCategory))
            {
                txtProdus.Items.Clear();
                foreach (var product in productData.ProductPrices[selectedCategory].Keys)
                {
                    txtProdus.Items.Add(product);
                }
            }
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (txtProdus.SelectedItem == null || cmbCategorie.SelectedItem == null || 
                string.IsNullOrWhiteSpace(txtProdus.SelectedItem.ToString()) || 
                string.IsNullOrWhiteSpace(cmbCategorie.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select a product and a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                decimal costPerItem = CalculateCostPerItem();
                totalCost += costPerItem;

                string itemInfo = $"{txtProdus.SelectedItem} ({cmbCategorie.SelectedItem}, Cantitate: {numCantitate.Value}, Cost: ${costPerItem:F2})";
                lstCumparaturi.Items.Add(itemInfo);

                lblTotalCost.Text = $"Cost total: ${totalCost:F2}";

                ClearInputFields();
            }
            catch (Exception ex)
            {
                //catch
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = lstCumparaturi.Items.Count - 1; i >= 0; i--)
                {
                    if (lstCumparaturi.GetSelected(i) && chkCumparat.Checked)
                    {
                        string itemInfo = lstCumparaturi.Items[i].ToString();
                        decimal costPerItem = ExtractCostFromItemInfo(itemInfo);
                        totalCost -= costPerItem;

                        lstCumparaturi.Items.RemoveAt(i);
                    }
                }

                lblTotalCost.Text = $"Cost total: ${totalCost:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalculateCostPerItem()
        {
            string selectedCategory = cmbCategorie.SelectedItem.ToString();
            string selectedProduct = txtProdus.SelectedItem.ToString();

            return productData.GetProductPrice(selectedCategory, selectedProduct) * numCantitate.Value;
        }

        private decimal ExtractCostFromItemInfo(string itemInfo)
        {
            var match = Regex.Match(itemInfo, @"\$(\d+(\.\d{1,2})?)");
            if (match.Success)
            {
                return decimal.Parse(match.Groups[1].Value);
            }
            else
            {
                throw new ApplicationException("Error extracting cost from item information");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInputFields()
        {
            txtProdus.Items.Clear();
            cmbCategorie.SelectedIndex = -1;
            numCantitate.Value = 1;
            chkCumparat.Checked = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}