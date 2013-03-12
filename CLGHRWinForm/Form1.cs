using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLGHRWinForm
{
    public partial class Form1 : Form
    {
        private OracleConnection conn = null;
        private DataSet dataSet = null;
        private DataViewManager dvm = null;

        public Form1()
        {
            this.InitializeComponent();

            ConnectionStringSettings connString =  ConfigurationManager.ConnectionStrings["DefaultConnection"];
            if (connString != null) {
                this.conn = new OracleConnection(connString.ConnectionString);
                this.conn.Open();
            }
            
            this.dataSet = new DataSet();
            this.dvm = this.dataSet.DefaultViewManager;
            
            this.UpdateDepartments();
        }

        private void UpdateDepartments()
        {
            int selected = this.departmentsListBox.SelectedIndex;
            this.departmentsListBox.Items.Clear();
            using (OracleCommand cmd = this.conn.CreateCommand()) {
                cmd.CommandText = "SELECT COUNT(*) AS population FROM employes";
                using (OracleDataReader reader = cmd.ExecuteReader()) {
                    if (reader.Read()) {
                        this.departmentsListBox.Items.Add(new Department() { Name = "Tous les départements", Population = reader.GetInt32(0) });
                    }
                }
            }
            using (OracleCommand cmd = this.conn.CreateCommand()) {
                cmd.CommandText = "SELECT dep.codedept, dep.nomdept, COUNT(emp.codedept) AS population FROM departements dep LEFT JOIN employes emp ON dep.codedept=emp.codedept GROUP BY dep.codedept, dep.nomdept";
                using (OracleDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        this.departmentsListBox.Items.Add(new Department() { Code = reader.GetString(0), Name = reader.GetString(1), Population = reader.GetInt32(2) });
                    }
                }
            }
            this.departmentsListBox.SelectedIndex = selected;
            this.newBtn.Enabled = (selected > 0);
        }

        private void UpdateDataSet()
        {
            using (OracleCommand cmd = this.conn.CreateCommand()) {
                Department dep = (Department)this.departmentsListBox.SelectedItem;
                if (dep == null || dep.Code == null) {
                    cmd.CommandText = "SELECT * FROM employes";
                } else {
                    cmd.CommandText = "SELECT * FROM employes WHERE codedept=:dep";
                    cmd.Parameters.Add(new OracleParameter(":dep", dep.Code));
                    cmd.Prepare();
                }
                using (OracleDataAdapter adapter = new OracleDataAdapter(cmd)) {
                    this.dataSet = new DataSet();
                    this.dvm = this.dataSet.DefaultViewManager;
                    adapter.Fill(this.dataSet, "EMPLOYES");

                    this.lastnameTextBox.DataBindings.Clear();
                    this.lastnameTextBox.DataBindings.Add("Text", this.dvm, "EMPLOYES.NOMEMP");

                    this.firstnameTextBox.DataBindings.Clear();
                    this.firstnameTextBox.DataBindings.Add("Text", this.dvm, "EMPLOYES.PRENOMEMP");

                    this.salaryNumericUpDown.DataBindings.Clear();
                    this.salaryNumericUpDown.DataBindings.Add("Value", this.dvm, "EMPLOYES.SALAIREEMP");

                    this.hiredDateTimePicker.DataBindings.Clear();
                    this.hiredDateTimePicker.DataBindings.Add("Value", this.dvm, "EMPLOYES.DATEEMBAUCHE");
                }
            }
        }

        private void UpdateForm()
        {
            if (this.dataSet.Tables["EMPLOYES"] != null && this.BindingContext[this.dvm, "EMPLOYES"].Position >= 0) {
                DataRow row = this.dataSet.Tables["EMPLOYES"].Rows[this.BindingContext[this.dvm, "EMPLOYES"].Position];
                if (row != null && row["PHOTO"] != DBNull.Value && ((byte[])row["PHOTO"]).Length > 0) {
                    using (MemoryStream ms = new MemoryStream((byte[])row["PHOTO"])) {
                        this.photoPictureBox.Image = Image.FromStream(ms);
                    }
                } else {
                    this.photoPictureBox.Image = null;
                }
            } else {
                this.photoPictureBox.Image = null;
            }
        }

        private void departmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.deleteDepartmentBtn.Enabled = (this.departmentsListBox.SelectedIndex > -1);
            this.newBtn.Enabled = (this.departmentsListBox.SelectedIndex > 0);
            this.UpdateDataSet();
            this.UpdateForm();
        }

        private void addDepartmentBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void deleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void photoBrowseBtn_Click(object sender, EventArgs e)
        {
            if (this.photoOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                this.photoPictureBox.Image = Image.FromFile(this.photoOpenFileDialog.FileName);
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (this.dataSet.Tables["EMPLOYES"] != null && this.BindingContext[this.dvm, "EMPLOYES"].Position > 0) {
                this.BindingContext[this.dvm, "EMPLOYES"].Position--;
                this.UpdateForm();
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.dataSet.Clear();
            this.lastnameTextBox.DataBindings.Clear();
            this.lastnameTextBox.Text = "";
            this.firstnameTextBox.DataBindings.Clear();
            this.firstnameTextBox.Text = "";
            this.salaryNumericUpDown.DataBindings.Clear();
            this.salaryNumericUpDown.Value = 0;
            this.hiredDateTimePicker.DataBindings.Clear();
            this.hiredDateTimePicker.Value = DateTime.Now;
            this.photoPictureBox.Image = null;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (OracleCommand cmd = this.conn.CreateCommand()) {
                cmd.Parameters.Add(new OracleParameter(":lastname", OracleDbType.Varchar2) { Value = this.lastnameTextBox.Text });
                cmd.Parameters.Add(new OracleParameter(":firstname", OracleDbType.Varchar2) { Value = this.firstnameTextBox.Text });
                cmd.Parameters.Add(new OracleParameter(":salary", OracleDbType.Decimal) { Value = this.salaryNumericUpDown.Value });
                cmd.Parameters.Add(new OracleParameter(":hireddate", OracleDbType.Date) { Value = this.hiredDateTimePicker.Value });
                using (MemoryStream ms = new MemoryStream()) {
                    if (this.photoPictureBox.Image != null) this.photoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    cmd.Parameters.Add(new OracleParameter(":photo", OracleDbType.Blob) { Value = ms.ToArray() });
                }
                if (this.dataSet.Tables["EMPLOYES"] != null && this.BindingContext[this.dvm, "EMPLOYES"].Position > -1) {
                    DataRow row = this.dataSet.Tables["EMPLOYES"].Rows[this.BindingContext[this.dvm, "EMPLOYES"].Position];
                    cmd.CommandText = "UPDATE employes SET nomemp=:lastname, prenomemp=:firstname, salaireemp=:salary, dateembauche=:hireddate, photo=:photo WHERE numemp=:id";
                    cmd.Parameters.Add(new OracleParameter(":id", OracleDbType.Decimal) { Value = row["NUMEMP"] });
                } else {
                    Department dep = (Department)this.departmentsListBox.SelectedItem;
                    cmd.CommandText = "INSERT INTO employes (nomemp, prenomemp, salaireemp, dateembauche, photo, codedept) VALUES (:lastname, :firstname, :salary, :hireddate, :photo, :dep)";
                    cmd.Parameters.Add(new OracleParameter(":dep", OracleDbType.Char) { Value = dep.Code });
                }
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                this.UpdateDepartments();
                this.UpdateDataSet();
                this.UpdateForm();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.dataSet.Tables["EMPLOYES"] != null) {
                DataRow row = this.dataSet.Tables["EMPLOYES"].Rows[this.BindingContext[this.dvm, "EMPLOYES"].Position];
                if (row != null) {
                    using (OracleCommand cmd = this.conn.CreateCommand()) {
                        cmd.CommandText = "DELETE FROM employes WHERE numemp=:id";
                        cmd.Parameters.Add(new OracleParameter(":id", row["NUMEMP"]));
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        this.UpdateDepartments();
                        this.UpdateForm();
                    }
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (this.dataSet.Tables["EMPLOYES"] != null && this.BindingContext[this.dvm, "EMPLOYES"].Position < this.dataSet.Tables["EMPLOYES"].Rows.Count) {
                this.BindingContext[this.dvm, "EMPLOYES"].Position++;
                this.UpdateForm();
            }
        }
    }
}
