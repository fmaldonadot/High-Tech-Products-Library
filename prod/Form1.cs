using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using High_Tech_Products_Library.bus;

namespace High_Tech_Products_Library
{
    public partial class HighTechForm : Form
    {
        DataCollection product_list = new DataCollection();
        int update_index = -1;
        bool save_flag = false;
        string tempsn = ""; // Temporal SN to mofidy option
        int temp_id;

        public HighTechForm()
        {
            InitializeComponent();

            // Loading Categories into combobox
            foreach (EnumProdType temp in Enum.GetValues(typeof(EnumProdType)))
            {
                cmbTypeProd.Items.Add(temp);
            }

            cmbTypeProd.SelectedItem = "Undefined";
            cmbTypeProd.Text = "Undefined";

            foreach (EnumBookGenre temp in Enum.GetValues(typeof(EnumBookGenre)))
            {
                cmbBGenre.Items.Add(temp);
            }

            cmbBGenre.SelectedItem = "Undefined";
            cmbBGenre.Text = "Undefined";

            foreach (EnumSoftType temp in Enum.GetValues(typeof(EnumSoftType)))
            {
                cmbSoftType.Items.Add(temp);
            }

            cmbSoftType.SelectedItem = "Undefined";
            cmbSoftType.Text = "Undefined";
        }

        private void HighTechForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbPTContractType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FTPOSlabel_Click(object sender, EventArgs e)
        {

        }

        private void cmbFTPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PTContractMlabel_Click(object sender, EventArgs e)
        {

        }

        private void PTCTHourlySallabel_Click(object sender, EventArgs e)
        {

        }

        private void PTCTWeekHlabel_Click(object sender, EventArgs e)
        {

        }

        private void PTContTypelabel_Click(object sender, EventArgs e)
        {

        }

        private void txtPTCTWeekHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPTTCHourlySal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPTContractMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product prod = null;
            int temp_seq = 0;

            if (!product_list.isUnique(txtSN.Text))
            {
                MessageBox.Show("There is another product with this SN...",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbTypeProd.Text == "Book")
            {
                if (!DataValidator.verifyData(txtBPages.Text, new Regex(DataValidator.patternNumber)))
                {
                    MessageBox.Show("Pages has to be a numeric value", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                prod = new Book(Convert.ToInt16(txtBPages.Text),
                          (EnumBookGenre)cmbBGenre.SelectedItem );
                temp_seq = prod.Item; //Store last sequence

            }
            else if (cmbTypeProd.Text == "Software")
            {
                if (!DataValidator.verifyData(txtSCapacity.Text, new Regex(DataValidator.patternNumber)))
                {
                    MessageBox.Show("Software Capacity has to be a numeric value", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                prod = new Software(txtSCapacity.Text , (EnumSoftType) cmbSoftType.SelectedItem);
                temp_seq = prod.Item; //Store last sequence

            }
            else
                MessageBox.Show("Must be select a Type of Product...", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

            try
            {
                prod.SerialNumber = txtSN.Text;
                prod.Type = (EnumProdType)cmbTypeProd.SelectedItem;
                prod.Titname = txtTitle.Text;
                prod.Author = txtAuthor.Text;

                // Validating Price
                if (!DataValidator.verifyData(txtPrice.Text, new Regex(DataValidator.patternMoney)))
                {
                    MessageBox.Show("Price has to be a numeric value", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                prod.Price = Convert.ToDouble(txtPrice.Text);

                //Validating Date
                if (!DataValidator.verifyData(txtHDay.Text, new Regex(DataValidator.patternDay)))
                {
                    MessageBox.Show("Wrong day...Must be between 1 and 31", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SequenceID.setProd_id(temp_seq); // Decrease the sequence
                    return;

                }
                if (!DataValidator.verifyData(txtHMonth.Text, new Regex(DataValidator.patternMonth)))
                {
                    MessageBox.Show("Wrong month...Must be between 1 and 12", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SequenceID.setProd_id(temp_seq); // Decrease the sequence
                    return;

                }
                if (!DataValidator.verifyData(txtHYear.Text, new Regex(DataValidator.patternYear)))
                {
                    MessageBox.Show("Wrong year...Must be between 1900 and 2099", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SequenceID.setProd_id(temp_seq); // Decrease the sequence
                    return;

                }
                prod.Ed_pubDate  = new Date(txtHDay.Text, txtHMonth.Text, txtHYear.Text);

                // Validating Stock
                if (!DataValidator.verifyData(txtStock.Text, new Regex(DataValidator.patternNumber)))
                {
                    MessageBox.Show("Stock has to be a numeric value", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                prod.Stock = Convert.ToInt16(txtStock.Text);

                // Adding to list
                product_list.add(prod);

                this.listBoxProducts.Items.Add(product_list.ShowListInBox(prod));
                btnReset.PerformClick();

                MessageBox.Show("Product Added", "Confirmation",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                save_flag = true;
            }
            catch
            {
                MessageBox.Show("Missing or incorrects values to enter...Check and Try again",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string resp;
            resp = MessageBox.Show("Do you want to Exit?",
                                   "Close App", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question).ToString();

            if (resp == "Yes")
            {
                if (save_flag == true)
                {
                    resp = MessageBox.Show("There are unsaved data. Do you want to save it?",
                                    "Warning", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning).ToString();
                    if (resp == "Yes")
                    {
                        btnWriteFile.PerformClick();
                    }
                }
                this.Close();
            }
        }

        private void cmbTypeProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeProd.Text == "Book")
            {
                // Show Corresponding Book Options
                BookGenrelabel.Show();
                cmbBGenre.Show();
                BPageslabel.Show();
                txtBPages.Show();

                // Hide Others
                SoftTypelabel.Hide();
                cmbSoftType.Hide();
                SCapacitylabel.Hide();
                txtSCapacity.Hide();
            }
            else if (cmbTypeProd.Text == "Software")
            {
                // Hide Corresponding Book Options
                BookGenrelabel.Hide();
                cmbBGenre.Hide();
                BPageslabel.Hide();
                txtBPages.Hide();

                // Show Software Options
                SoftTypelabel.Show();
                cmbSoftType.Show();
                SCapacitylabel.Show();
                txtSCapacity.Show();
            }

            else if (cmbTypeProd.Text == "Undefined")
            {
                // Hide Corresponding Book Options
                BookGenrelabel.Hide();
                cmbBGenre.Hide();
                BPageslabel.Hide();
                txtBPages.Hide();

                // Hide Software Options
                SoftTypelabel.Hide();
                cmbSoftType.Hide();
                SCapacitylabel.Hide();
                txtSCapacity.Hide();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSN.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtHDay.Text = "";
            txtHMonth.Text = "";
            txtHYear.Text = "";
            txtStock.Text = "";

            cmbTypeProd.Text = EnumProdType.Undefined.ToString();
            cmbSoftType.Text = EnumSoftType.Undefined.ToString();
            cmbBGenre.Text = EnumBookGenre.Undefined.ToString();

            txtSCapacity.Text = "";
            txtBPages.Text = "";
            txtPrice.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string[] disp_list = null;
            try
            {
                disp_list = listBoxProducts.SelectedItem.ToString().Split('\t');
                update_index = listBoxProducts.SelectedIndex;

                // Fill the fields
                txtSN.Text = disp_list[1];
                cmbTypeProd.Text = disp_list[2];
                txtTitle.Text = disp_list[3];
                txtAuthor.Text = disp_list[4];
                txtPrice.Text = disp_list[5];
                txtHDay.Text = disp_list[6];
                txtHMonth.Text = disp_list[7];
                txtHYear.Text = disp_list[8];
                txtStock.Text = disp_list[9];
                tempsn = disp_list[1]; // Saving in case of choice modify option
                temp_id = Convert.ToInt16(disp_list[0]); // Saving ID in case of choice modify option
                

                if (cmbTypeProd.Text == "Book")
                {
                    txtBPages.Text = disp_list[10];
                    cmbBGenre.Text = disp_list[11];
                }
                if (cmbTypeProd.Text == "Software")
                {
                    txtSCapacity.Text = disp_list[10];
                    cmbSoftType.Text = disp_list[11];
                }
            }
            catch
            {
                MessageBox.Show("It must to add or select an item and display it, use Display Option",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            FileHandler txtwrite = new FileHandler();

            txtwrite.writeFile(product_list);

            save_flag = false;

            MessageBox.Show("Products were saved in the filepath: " + txtwrite.getMyfile(),
                    "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            FileHandler txtload = new FileHandler();
            SequenceID.setProd_id(1); // Initialize the Sequence Id
            product_list.ReturnList().Clear();
            product_list = txtload.readFile();

            // Clean the List Box
            listBoxProducts.Items.Clear();

            foreach (Product emp in product_list.ReturnList())
            {
                listBoxProducts.Items.Add(product_list.ShowListInBox(emp));
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            Product prod = null;
            string[] str;
            try
            {
                str = listBoxProducts.SelectedItem.ToString().Split('\t');
                MessageBox.Show(str[0]);
                prod = product_list.search(Convert.ToInt16(str[0]));
                product_list.remove(prod.SerialNumber);
                listBoxProducts.Items.RemoveAt(listBoxProducts.SelectedIndex);
                save_flag = true;
            }
            catch
            {
                MessageBox.Show("It must to add or select an item to erase",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Product prod = null;
            int temp_seq = 0;
            try
            {

                if (cmbTypeProd.Text == "Book")
                {
                    if (!DataValidator.verifyData(txtBPages.Text, new Regex(DataValidator.patternNumber)))
                    {
                        MessageBox.Show("Pages must be a numeric value", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    prod = new Book(Convert.ToInt16(txtBPages.Text),
                          (EnumBookGenre)cmbBGenre.SelectedItem);
                    temp_seq = prod.Item; //Store last sequence

                }
                else if (cmbTypeProd.Text == "Software")
                {
                    if (!DataValidator.verifyData(txtSCapacity.Text, new Regex(DataValidator.patternNumber)))
                    {
                        MessageBox.Show("Software Capacity has to be a numeric value", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    prod = new Software(txtSCapacity.Text, (EnumSoftType)cmbSoftType.SelectedItem);
                    temp_seq = prod.Item; //Store last sequence

                }
                else
                    MessageBox.Show("Must be selected an Employee's Category...", "Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    prod.SerialNumber = txtSN.Text;
                    prod.Type = (EnumProdType)cmbTypeProd.SelectedItem;
                    prod.Titname = txtTitle.Text;
                    prod.Author = txtAuthor.Text;

                    // Validating Price
                    if (!DataValidator.verifyData(txtPrice.Text, new Regex(DataValidator.patternMoney)))
                    {
                        MessageBox.Show("Price has to be a numeric value", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    prod.Price = Convert.ToDouble(txtPrice.Text);

                    //Validating Date
                    if (!DataValidator.verifyData(txtHDay.Text, new Regex(DataValidator.patternDay)))
                    {
                        MessageBox.Show("Wrong day...Must be between 1 and 31", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SequenceID.setProd_id(temp_seq); // Decrease the sequence
                        return;

                    }
                    if (!DataValidator.verifyData(txtHMonth.Text, new Regex(DataValidator.patternMonth)))
                    {
                        MessageBox.Show("Wrong month...Must be between 1 and 12", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SequenceID.setProd_id(temp_seq); // Decrease the sequence
                        return;

                    }
                    if (!DataValidator.verifyData(txtHYear.Text, new Regex(DataValidator.patternYear)))
                    {
                        MessageBox.Show("Wrong year...Must be between 1900 and 2099", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SequenceID.setProd_id(temp_seq); // Decrease the sequence
                        return;

                    }
                    prod.Ed_pubDate = new Date(txtHDay.Text, txtHMonth.Text, txtHYear.Text);

                    // Validating Stock
                    if (!DataValidator.verifyData(txtStock.Text, new Regex(DataValidator.patternNumber)))
                    {
                        MessageBox.Show("Stock has to be a numeric value", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    prod.Stock = Convert.ToInt16(txtStock.Text);

                    prod.SerialNumber = tempsn; //Assign last displayed SN

                    prod.Item = temp_id;
                                        
                    if (txtSN.Text != prod.SerialNumber)
                    {
                        MessageBox.Show("Can't to modify the SN in the Modify option.  It should use Add button",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (update_index > -1)
                    {
                        // Update list Box and list of Products
                        product_list.modify(prod, prod.SerialNumber);
                        listBoxProducts.Items.Clear();
                        foreach (Product temp in product_list.ReturnList())
                        {
                            this.listBoxProducts.Items.Add(product_list.ShowListInBox(temp));
                        }

                        btnReset.PerformClick();

                        update_index = -1;

                        save_flag = true;

                        MessageBox.Show("Product Mofified", "Confirmation",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show("It must to select an item and display it.  Use Display Option",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch
                {
                    MessageBox.Show("Missing or incorrects values to enter...Check and Try again",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Missing or incorrects values to enter...Check and Try again",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radbtnBySIN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchByKey_Click(object sender, EventArgs e)
        {
            Product prod = null;
            if (radbtnBySN.Checked)
            {
                prod = product_list.search(txtSearch.Text);

                if (prod != null)
                {
                    listBoxProducts.SelectedIndex = prod.Item - 1;

                    btnDisplay.PerformClick();
                }
                else
                    MessageBox.Show("SN not found!", "Not Finded", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);

            }
            if (radbtnByItem.Checked)
            {
                if (!DataValidator.verifyData(txtSearch.Text, new Regex(DataValidator.patternNumber)))
                {
                    MessageBox.Show("Item has to be a numeric value", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                prod = product_list.search(Convert.ToInt16(txtSearch.Text));

                if (prod != null)
                {
                    listBoxProducts.SelectedIndex = prod.Item - 1;

                    btnDisplay.PerformClick();
                }
                else
                    MessageBox.Show("SN not found!", "Not Finded", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);

            }
        }
    }
}
