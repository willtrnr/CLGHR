using Microsoft.Win32;
using Oracle.DataAccess.Client;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace CLGHR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OracleConnection conn = null;
        private CLG clg = null;
        private CLGTableAdapters.EMPLOYESTableAdapter employesTableAdapter = null;
        private CollectionViewSource employesViewSource = null;
        //private DataSet dataSet = new DataSet();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            this.ConnectDatabase();
            this.UpdateDepartments();

            this.clg = (CLG)this.FindResource("clg");
            this.employesTableAdapter = new CLGTableAdapters.EMPLOYESTableAdapter();
            this.employesViewSource = (CollectionViewSource)this.FindResource("employesViewSource");
        }

        /// <summary>
        /// Connects the database.
        /// </summary>
        private void ConnectDatabase()
        {
            ConnectionStringSettings connString =  ConfigurationManager.ConnectionStrings["DefaultConnection"];
            if (connString != null) {
                this.conn = new OracleConnection(connString.ConnectionString);
                this.conn.Open();
            }
        }

        /// <summary>
        /// Updates the departments.
        /// </summary>
        private void UpdateDepartments()
        {
            int selected = this.DepartmentListBox.SelectedIndex;
            this.DepartmentListBox.Items.Clear();
            this.DepartmentComboBox.Items.Clear();
            using (OracleCommand cmd = this.conn.CreateCommand()) {
                cmd.CommandText = "SELECT COUNT(*) AS population FROM employes";
                using (OracleDataReader reader = cmd.ExecuteReader()) {
                    if (reader.Read()) {
                        this.DepartmentListBox.Items.Add(new Department() { Code = "Tous", Name = "les départements", Population = reader.GetInt32(0) });
                    }
                }
            }
            using (OracleCommand cmd = this.conn.CreateCommand()) {
                cmd.CommandText = "SELECT dep.codedept, dep.nomdept, COUNT(emp.codedept) AS population FROM departements dep LEFT JOIN employes emp ON dep.codedept=emp.codedept GROUP BY dep.codedept, dep.nomdept";
                using (OracleDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        this.DepartmentListBox.Items.Add(new Department() { Code = reader.GetString(0), Name = reader.GetString(1), Population = reader.GetInt32(2) });
                        this.DepartmentComboBox.Items.Add(new Department() { Code = reader.GetString(0), Name = reader.GetString(1), Population = -1 });
                    }
                }
            }
            this.DepartmentListBox.SelectedIndex = selected;
            if (selected > -1) this.DepartmentComboBox.SelectedIndex = selected - 1;
        }

        /// <summary>
        /// Handles the SelectionChanged event of the DepartmentListBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs" /> instance containing the event data.</param>
        private void DepartmentListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.DepartmentListBox.SelectedIndex > 0) this.DepartmentComboBox.SelectedIndex = this.DepartmentListBox.SelectedIndex - 1;

            Department dept = (Department)this.DepartmentListBox.SelectedItem;
            if (dept == null || dept.Code == "Tous") {
                this.employesTableAdapter.Fill(this.clg.EMPLOYES);
            } else {
                this.employesTableAdapter.FillByDept(clg.EMPLOYES, dept.Code);
            }
            this.employesViewSource.View.MoveCurrentToFirst();
        }

        /// <summary>
        /// Handles the Click event of the SalaryPlusBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void SalaryPlusBtn_Click(object sender, RoutedEventArgs e)
        {
            int i;
            if (int.TryParse(this.SalaryTextBox.Text, out i)) {
                this.SalaryTextBox.Text = (i + 100).ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the SalaryMinusBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void SalaryMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            int i;
            if (int.TryParse(this.SalaryTextBox.Text, out i)) {
                this.SalaryTextBox.Text = ((i > 100) ? i - 100 : 0).ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the BrowseBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void BrowseBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Fichiers images (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif;|Tous les fichiers (*.*)|*.*";
            open.FilterIndex = 0;
            open.Multiselect = false;
            if (open.ShowDialog() == true) {
                this.ImagePathTextBox.Text = open.FileName;
                this.clg.EMPLOYES[this.employesViewSource.View.CurrentPosition].PHOTO = System.IO.File.ReadAllBytes(open.FileName);
            }
        }

        /// <summary>
        /// Handles the Click event of the PrevBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void PrevBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.employesViewSource.View.CurrentPosition > 0) this.employesViewSource.View.MoveCurrentToPrevious();
        }

        /// <summary>
        /// Handles the Click event of the NewBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            // FIXME: No worky, plz fix meh
            CLG.EMPLOYESRow row = this.clg.EMPLOYES.NewEMPLOYESRow();
            row.NUMEMP = 0;
            row.NOMEMP = "";
            row.PRENOMEMP = "";
            this.clg.EMPLOYES.Rows.Add(row);
            this.employesViewSource.View.MoveCurrentToLast();
        }

        /// <summary>
        /// Handles the Click event of the SaveBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            // FIXME: For some reason, many edits are dropped
            this.clg.EMPLOYES.AcceptChanges();
            this.employesTableAdapter.Update(this.clg.EMPLOYES);
            this.UpdateDepartments();
        }

        /// <summary>
        /// Handles the Click event of the DeleteBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            // FIXME: Check position
            this.clg.EMPLOYES[this.employesViewSource.View.CurrentPosition].Delete();
            this.employesTableAdapter.Update(this.clg.EMPLOYES);
            this.UpdateDepartments();
        }

        /// <summary>
        /// Handles the Click event of the NextBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.employesViewSource.View.CurrentPosition < ((CollectionView)this.employesViewSource.View).Count - 1) this.employesViewSource.View.MoveCurrentToNext();
        }
    }
}
