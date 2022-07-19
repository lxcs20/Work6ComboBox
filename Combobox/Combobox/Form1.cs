using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection con;
        private SqlCommand cmd;
        private string sql;

        public BindingSource binding;

        ConnectDB Q = new ConnectDB();

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string strcon = @"Data Source=helloxyt;Initial Catalog=dbCombo;Integrated Security=True";
            con = new SqlConnection(strcon);
            con.Open();
            // TODO: This line of code loads data into the 'dbComboDataSet.tbEmployees' table. You can move, or remove it, as needed.
            this.tbEmployeesTableAdapter.Fill(this.dbComboDataSet.tbEmployees);
            
            Q.Query("Select prName from tbProduct");
            cobProduct.DataSource = Q.ds.Tables["data"];
            cobProduct.DisplayMember = "prName";
            selectProduct();
        }

        private void selectProduct()
        {
            Q.Query("Select*from tbProduct");
            binding = new BindingSource();
            binding.DataSource = Q.ds.Tables["data"];

            txtprice.DataBindings.Add("Text", binding, "price");

        }

        private void cobProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding == null)
            {
                return;
            }
            binding.Position = cobProduct.SelectedIndex;
            float price = Convert.ToInt32(txtprice.Text);
            float amout = Convert.ToInt32(txtAmout.Text);
            txtTotal.Text = (price * amout).ToString();
        }

        private void txtAmout_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAmout.Text == "" || Convert.ToInt32(txtAmout.Text) > 200)
                {
                    return;
                }
                float price = Convert.ToInt32(txtprice.Text);
                float amout = Convert.ToInt32(txtAmout.Text);
                txtTotal.Text = (price * amout).ToString();
            }
            catch
            {
                MessageBox.Show("ປ້ອນຕົວເລກເທົ່ານັ້ນ");
            }

        }

        private void Insert()
        {
            
            sql = @"Insert into tbOrder(prID,prName,amout,price,total)
                    Values(@pid, @pname, @amo, @pr, @to)";

            cmd = new SqlCommand(sql,con);
            cmd.Parameters.Clear();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("pid", (cobProduct.SelectedIndex + 1).ToString());
            cmd.Parameters.AddWithValue("pname", cobProduct.Text);
            cmd.Parameters.AddWithValue("amo", Convert.ToInt32(txtAmout.Text));
            cmd.Parameters.AddWithValue("pr", Convert.ToInt32(txtprice.Text));
            cmd.Parameters.AddWithValue("to", Convert.ToInt32(txtTotal.Text));

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show("ສຳເລັດ", "ຜົນລັບ");

            }
            else
            {
                MessageBox.Show("ເກີດຂໍ້ຜິດພາດ", "ຜົນລັບ");

            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Insert();
        }
    }
}
