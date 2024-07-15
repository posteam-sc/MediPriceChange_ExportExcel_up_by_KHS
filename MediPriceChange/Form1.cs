using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;




namespace MediPriceChange
{
    public partial class Form1 : Form
    {

        System.Data.DataTable dt = new System.Data.DataTable();
        DataTable dtNew= new System.Data.DataTable();// to avoid the namespace confilict


        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private bool check;
        string filenamewithoutext = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            check = false;
            CheckSaveButton();
        }

        private void CheckSaveButton()
        {
            btnSave.Visible = (check == false ? false : true);
        }



        private void ofdSelect_FileOk(object sender, CancelEventArgs e)
        {

            btnSave.Visible = false;

            dt.Columns.Add(new DataColumn("ProductCode"));
            dt.Columns.Add(new DataColumn("ProductDescription"));
            dt.Columns.Add(new DataColumn("Price"));
            string filePath = ofd.FileName;
            filenamewithoutext = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);
            string conString = "";
            string sheetName = "";
            switch (extension)
            {
                case ".xls":
                    conString = string.Format(Excel03ConString, filePath, "YES");
                    break;
                case ".xlsx":
                    conString = string.Format(Excel07ConString, filePath, "YES");
                    break;
                default:
                    MessageBox.Show("Invalid file", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    System.Data.DataTable dth = new System.Data.DataTable();
                    dth = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dth.Rows[0]["Table_Name"].ToString();
                    con.Close();
                }
            }
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    OleDbDataAdapter oda = new OleDbDataAdapter();
                    cmd.CommandText = "SELECT ProductCode,ProductDescription,Price FROM [" + sheetName + "]";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    oda.SelectCommand = cmd;
                    oda.Fill(dt);
                    con.Close();
                    dgvImport.DataSource = dt;
                }
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {

            ofd.ShowDialog();
            //foreach (DataGridViewColumn dc in dgvImport.Columns)
            //{
            //    dt1.Columns.Add(dc.HeaderText, dc.ValueType);
            //}

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            POSEntities entity = new POSEntities();


            if (dgvImport.Rows.Count > 0)
            {
                check = true;
                dtNew = dt.Clone();

                for (int i = 0; i < dgvImport.Rows.Count - 1; i++)
                {
                    bool checkOk = true;

                    string dgvProduct = dgvImport.Rows[i].Cells["ProductCode"].Value.ToString();
                    string productCodeName = entity.Products.Where(x => x.ProductCode == dgvProduct).Select(x => x.ProductCode).FirstOrDefault();
                    if (productCodeName == null)
                    {
                        dgvImport.Rows[i].Cells["ProductCode"].Style.BackColor = Color.Red;
                        check = false;
                        checkOk = false;

                    }


                    if (!String.IsNullOrWhiteSpace(Convert.ToString(dgvImport.Rows[i].Cells["ProductCode"])))
                    {
                        if (String.IsNullOrWhiteSpace(dgvImport.Rows[i].Cells["Price"].Value.ToString()) || Convert.ToInt32(dgvImport.Rows[i].Cells["Price"].Value.ToString()) == 0)
                        {
                            dgvImport.Rows[i].Cells["Price"].Style.BackColor = Color.Red;
                            check = false;

                        }

                    }
                    if (checkOk)
                    {
                        dtNew.Rows.Add();
                        foreach (DataGridViewCell cell in dgvImport.Rows[i].Cells)
                        {
                            dtNew.Rows[dtNew.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                        }
                    }
                }
            }
            CheckSaveButton();
            btnExporttoExcel.Visible = true;
            // return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (dgvImport.Rows.Count > 0)
            {
                DialogResult ok = MessageBox.Show("are you sure to save data?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    // List<Product> prodcutList = new List<Product>();
                    for (int i = 0; i < dgvImport.Rows.Count - 1; i++)
                    {
                        try
                        {
                            POSEntities entity = new POSEntities();
                            ProductPriceChange productPriceChange = new ProductPriceChange();
                            string dgvProduct = dgvImport.Rows[i].Cells["Product Code"].Value.ToString();
                            string productCodeName = entity.Products.Where(x => x.ProductCode == dgvProduct).Select(x => x.ProductCode).FirstOrDefault();
                            Product product = (from p in entity.Products where p.ProductCode == productCodeName select p).FirstOrDefault();
                            int productId = Convert.ToInt32(product.Id);
                            long oldPrice = product.Price;
                            product.Price = Convert.ToInt64(dgvImport.Rows[i].Cells["Price"].Value.ToString());

                            productPriceChange.ProductId = productId;
                            productPriceChange.UpdateDate = DateTime.Now;
                            productPriceChange.UserID = 1034;
                            productPriceChange.Price = Convert.ToInt64(dgvImport.Rows[i].Cells["Price"].Value.ToString());
                            entity.ProductPriceChanges.Add(productPriceChange);
                            entity.SaveChanges();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }
                    MessageBox.Show("Save Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExporttoExcel_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }
        private void ExportExcel()
        {
            string folderpath = @"C:\SourceCodeCo\exported\";
            if (!Directory.Exists(folderpath))
            {
                Directory.CreateDirectory(folderpath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dtNew, "PriceUpdate"); // add the worksheet with a name
                wb.Worksheet(1).Columns().AdjustToContents(); // adjust the width of the columns
                wb.SaveAs(folderpath + filenamewithoutext + "_PriceUpdate_Checked.xlsx");
                MessageBox.Show("Successfully export to Excel");
            }

        }

       
    }
}
