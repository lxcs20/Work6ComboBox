
namespace Combobox
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cobProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cobEmp = new System.Windows.Forms.ComboBox();
            this.tbEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbComboDataSet = new Combobox.dbComboDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtAmout = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbEmployeesTableAdapter = new Combobox.dbComboDataSetTableAdapters.tbEmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbComboDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cobProduct
            // 
            this.cobProduct.FormattingEnabled = true;
            this.cobProduct.Location = new System.Drawing.Point(91, 139);
            this.cobProduct.Name = "cobProduct";
            this.cobProduct.Size = new System.Drawing.Size(152, 21);
            this.cobProduct.TabIndex = 0;
            this.cobProduct.SelectedIndexChanged += new System.EventHandler(this.cobProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ສິນຄ້າ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ພະນັກງານ";
            // 
            // cobEmp
            // 
            this.cobEmp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbEmployeesBindingSource, "emName", true));
            this.cobEmp.DataSource = this.tbEmployeesBindingSource;
            this.cobEmp.DisplayMember = "emName";
            this.cobEmp.FormattingEnabled = true;
            this.cobEmp.Location = new System.Drawing.Point(91, 87);
            this.cobEmp.Name = "cobEmp";
            this.cobEmp.Size = new System.Drawing.Size(152, 21);
            this.cobEmp.TabIndex = 2;
            this.cobEmp.ValueMember = "emName";
            // 
            // tbEmployeesBindingSource
            // 
            this.tbEmployeesBindingSource.DataMember = "tbEmployees";
            this.tbEmployeesBindingSource.DataSource = this.dbComboDataSet;
            // 
            // dbComboDataSet
            // 
            this.dbComboDataSet.DataSetName = "dbComboDataSet";
            this.dbComboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ລາຄາ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ລວມ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ຈຳນວນ";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(252, 139);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(103, 20);
            this.txtprice.TabIndex = 10;
            // 
            // txtAmout
            // 
            this.txtAmout.Location = new System.Drawing.Point(361, 139);
            this.txtAmout.Name = "txtAmout";
            this.txtAmout.Size = new System.Drawing.Size(103, 20);
            this.txtAmout.TabIndex = 11;
            this.txtAmout.TextChanged += new System.EventHandler(this.txtAmout_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(470, 139);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(103, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(474, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "ບັນທຶກ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbEmployeesTableAdapter
            // 
            this.tbEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 286);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtAmout);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cobEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cobProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbComboDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cobProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtAmout;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSave;
        private dbComboDataSet dbComboDataSet;
        private System.Windows.Forms.BindingSource tbEmployeesBindingSource;
        private dbComboDataSetTableAdapters.tbEmployeesTableAdapter tbEmployeesTableAdapter;
    }
}

