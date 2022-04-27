using Project.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Project
{
    public partial class frmMain : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ Application.StartupPath+@"\Project\DataBase.mdf;Integrated Security=True");
        SqlCommand cmd = null;
        DataTable dt = null;
        SqlDataAdapter da = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseDataSet.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.dataBaseDataSet.tblProduct);
            // TODO: This line of code loads data into the 'dataBaseDataSet.tblDistributor' table. You can move, or remove it, as needed.
            this.tblDistributorTableAdapter.Fill(this.dataBaseDataSet.tblDistributor);
            // TODO: This line of code loads data into the 'dataBaseDataSet.tblEmployee' table. You can move, or remove it, as needed.
            this.tblEmployeeTableAdapter.Fill(this.dataBaseDataSet.tblEmployee);
            // TODO: This line of code loads data into the 'dataBaseDataSet.tblStoreBuy' table. You can move, or remove it, as needed.
            this.tblStoreBuyTableAdapter.Fill(this.dataBaseDataSet.tblStoreBuy);
            // TODO: This line of code loads data into the 'dataBaseDataSet.tblExportReceipt' table. You can move, or remove it, as needed.
            this.tblExportReceiptTableAdapter.Fill(this.dataBaseDataSet.tblExportReceipt);
            txtPriceImport.Enabled = false;
            txtProductIDImport.Enabled = false;
            txtQuantityWImport.Enabled = false;
            txtEmployeeNameImport.Enabled = false;
            txtImportReceiptID.Enabled = false;
            txtDayOrder.Enabled = false;
            txtPayMethodExport.Enabled = false;
            txtStoreExportID.Enabled = false;
            cbbReceiptIDExport.SelectedIndex = -1;
        }

        #region Import
        //random id
        private void btnSetImportReceiptID_Click(object sender, EventArgs e)
        {
            btnSetImportReceiptID.Enabled = false;
            Random number = new Random();
            txtImportReceiptID.Text = Convert.ToString(number.Next(10, 10000));
        }
        //Calculate total price of all product 
        void UpdateUSDImport()
        {
            double sum = 0;
            for (int j = 0; j < dgvProduct.Rows.Count; j++)
            {
                double total = Convert.ToDouble(dgvProduct.Rows[j].Cells[5].Value);
                sum += total;
                txtTotalImport.Text = sum.ToString();
            }

        }
        private void btnAddProductmport_Click_1(object sender, EventArgs e)
        {
            if (txtImportReceiptID.Text == "")
            {
                MessageBox.Show("Please press Set button to take ID", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtImportReceiptID.Focus();
            }
            else
            {
                if (boxQuantityImport.Value > 0)
                {
                    bool checkExist = false;
                    for (int i = 0; i < dgvProduct.Rows.Count; i++)
                    {
                        // increase quantity if product existed
                        if (Convert.ToString(dgvProduct.Rows[i].Cells[2].Value) == cbbImportName.Text)
                        {
                            dgvProduct.Rows[i].Cells[3].Value = Convert.ToString(boxQuantityImport.Value + Convert.ToDecimal(dgvProduct.Rows[i].Cells[3].Value));
                            checkExist = true;
                            break;
                        }
                    }
                    // add product to dgv
                    if (checkExist == false)
                    {
                        dgvProduct.Rows.Add(txtImportReceiptID.Text, txtProductIDImport.Text, cbbImportName.Text, boxQuantityImport.Value.ToString(), txtPriceImport.Text);
                    }
                    UpdateUSDImport();

                    // Calculate Total column
                    for (int i = 0; i < dgvProduct.Rows.Count; i++)
                    {
                        double quantity = Convert.ToDouble(dgvProduct.Rows[i].Cells[3].Value);
                        double price = Convert.ToDouble(dgvProduct.Rows[i].Cells[4].Value);
                        dgvProduct.Rows[i].Cells[5].Value = Convert.ToString(quantity * price);
                    }

                    UpdateUSDImport();
                    boxQuantityImport.Value = 0;
                }
                else
                {
                    MessageBox.Show("Choose quantity of product!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnDeleteProductImport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                if (Convert.ToString(dgvProduct.Rows[i].Cells[2].Value) == cbbImportName.Text)
                {
                    dgvProduct.Rows.Remove(dgvProduct.Rows[i]);
                }
                UpdateUSDImport();
            }
        }
        // clear product list
        public void Clear()
        {
            if (dgvProduct.Rows.Count > 0)
            {
                for (int i = 0; i < dgvProduct.Rows.Count; i++)
                {
                    dgvProduct.Rows.Clear();
                }
            }
            else
            {
                return;
            }
            txtTotalImport.Text = "0";
            boxQuantityImport.Value = 0;
        }
        // clear product list
        private void btnClearImportList_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
        //create import receipt
        private void btnCreateImport_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT ImportReceiptID From tblImportReceipt WHERE ImportReceiptID = 'N" + txtImportReceiptID.Text + "'";//checkkey
            //check if product list null
            if (dgvProduct.Rows.Count < 1)
            {
                MessageBox.Show("There are no product have been add to list!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //check if receipt null
                if (txtImportReceiptID.Text.Trim() != "")
                {
                    // create a import receipt

                    String str = ("SELECT ImportReceiptID From tblImportReceipt WHERE ImportReceiptID = N'" + txtImportReceiptID.Text + "'");

                    if (Function.CheckKey(str))
                    {
                        MessageBox.Show("Already have this Import Receipt ID. Try another!");
                        txtImportReceiptID.Text = "";
                        btnSetImportReceiptID.Enabled = true;
                        txtImportReceiptID.Focus();
                        return;
                    }
                    else
                    {

                        con.Open();
                        cmd = new SqlCommand("INSERT INTO tblImportReceipt(ImportReceiptID, EmployeeID, DistributorID, Date, TotalPrice) VALUES (@ImportReceiptID, @EmployeeID, @DistributorID, @Date, @TotalPrice)", con);
                        cmd.Parameters.AddWithValue("@ImportReceiptID", txtImportReceiptID.Text);
                        cmd.Parameters.AddWithValue("@EmployeeID", ccbEmployeeIDImport.Text);
                        cmd.Parameters.AddWithValue("@DistributorID", ccbEmployeeIDImport.Text);
                        cmd.Parameters.AddWithValue("@Date", Function.ConvertDateTime(dtpDateImport.Text));
                        cmd.Parameters.AddWithValue("@TotalPrice", txtTotalImport.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        //update quantity of product in warehouse
                        for (int i = 0; i < dgvProduct.Rows.Count; i++)
                        {
                            int quantity = 0;
                            quantity = Convert.ToInt32(dgvProduct.Rows[i].Cells[3].Value) + Convert.ToInt32(txtQuantityWImport.Text);
                            con.Open();
                            cmd = new SqlCommand("UPDATE tblProduct SET Quantity =" + quantity + "Where ProductID= N'" + txtProductIDImport.Text.Trim() + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }


                        //insert product to tblImportDetail
                        for (int i = 0; i < dgvProduct.Rows.Count; i++)
                        {
                            con.Open();
                            cmd = new SqlCommand("INSERT INTO tblImportDetail (ImportReceiptID,ProductID, Name, Quantity,Price,TotalPrice) VALUES (@ImportReceiptID,@ProductID,@Name,@Quantity,@Price,@TotalPrice)", con);
                            cmd.Parameters.AddWithValue("@ImportReceiptID", dgvProduct.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("@ProductID", dgvProduct.Rows[i].Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@Name", dgvProduct.Rows[i].Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@Quantity", dgvProduct.Rows[i].Cells[3].Value.ToString());
                            cmd.Parameters.AddWithValue("@Price", dgvProduct.Rows[i].Cells[4].Value.ToString());
                            cmd.Parameters.AddWithValue("@TotalPrice", dgvProduct.Rows[i].Cells[5].Value.ToString());
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        Clear();
                        MessageBox.Show("Create warehouse receipt success!");
                    }
                }


                else
                {
                    MessageBox.Show("Please press Set button to take ID!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }
        #endregion
        #region Export
        
        private void cbbReceiptIDExport_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql = "select * from tblExportDetail where ExportReceiptID = N'" + cbbReceiptIDExport.Text.Trim() + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            
            da.Fill(dt);
            dgvExport.DataSource = dt;
            dgvExport.Columns[0].HeaderText = "Product ID";
            dgvExport.Columns[1].HeaderText = "Receipt ID";
            dgvExport.Columns[3].HeaderText = "Name";
            dgvExport.Columns[4].HeaderText = "Quantity";
            dgvExport.Columns[5].HeaderText = "Price";
            dgvExport.Columns[4].HeaderText = "Total";
            dgvExport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvExport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvExport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvExport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvExport.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvExport.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            con.Close();
            double sum = 0;
            
            for (int i = 0; i < dgvExport.Rows.Count; i++)
            {
                double total = Convert.ToDouble(dgvExport.Rows[i].Cells[5].Value);
                sum += total;
                txtTotalExport.Text = sum.ToString();
            }
        }
        
        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
        #region Quit
        private void lblQuit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblQuit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblQuit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
                
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Import")
            {

                string sql = "select * from tblExportDetail where ExportReceiptID = N'" + cbbReceiptIDExport.Text.Trim() + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgvExport.DataSource = dt;
                con.Close();
            }
            else if (comboBox1.Text == "Export")
            {
                string sql = "select * from tblExportDetail";
                con.Open();
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgvExport.DataSource = dt;
                con.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvExport.Rows.Count < 1)
            {
                MessageBox.Show("There are no product in list!");
            }
            else
            {
                //delete product
                for (int i = 0; i < dgvExport.Rows.Count; i++)
                {
                    string sql1 = "Delete tblExportDetail where ExportReceiptID = N'" + cbbReceiptIDExport.Text + "'";
                    con.Open();
                    cmd = new SqlCommand(sql1, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }


                //delete receipt
                
                String sql = "Delete tblExportReceipt where ExportReceiptID = N'" + cbbReceiptIDExport.Text + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                 
                //delete store
                String sql2 = "Delete tblStoreBuy where StoreID = N'" + txtStoreExportID.Text + "'";
                con.Open();
                cmd = new SqlCommand(sql2, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Export success!");
                cbbReceiptIDExport.SelectedIndex = 0;
            }
        }
    }
}
