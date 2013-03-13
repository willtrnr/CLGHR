namespace CLGHR
{
    partial class MainWindow
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
            if (disposing && (components != null)) {
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label1;
            this.departmentsListBox = new System.Windows.Forms.ListBox();
            this.departmentsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addDepartmentBtn = new System.Windows.Forms.Button();
            this.deleteDepartmentBtn = new System.Windows.Forms.Button();
            this.mainFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hiredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.photoBrowseBtn = new System.Windows.Forms.Button();
            this.formActionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.previousBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.photoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            titleLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.departmentsTableLayoutPanel.SuspendLayout();
            this.mainFormTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.formActionsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.ForeColor = System.Drawing.Color.Gray;
            titleLabel.Location = new System.Drawing.Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(484, 55);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "CLG HR";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(161, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 13);
            label2.TabIndex = 0;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(147, 32);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 13);
            label3.TabIndex = 1;
            label3.Text = "Prenom";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(151, 58);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(39, 13);
            label4.TabIndex = 2;
            label4.Text = "Salaire";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(99, 84);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 13);
            label5.TabIndex = 3;
            label5.Text = "Date d\'embauche";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(155, 150);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 9;
            label1.Text = "Photo";
            // 
            // departmentsListBox
            // 
            this.departmentsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentsListBox.FormattingEnabled = true;
            this.departmentsListBox.Location = new System.Drawing.Point(3, 3);
            this.departmentsListBox.Name = "departmentsListBox";
            this.departmentsTableLayoutPanel.SetRowSpan(this.departmentsListBox, 2);
            this.departmentsListBox.Size = new System.Drawing.Size(381, 82);
            this.departmentsListBox.TabIndex = 1;
            this.departmentsListBox.SelectedIndexChanged += new System.EventHandler(this.departmentsListBox_SelectedIndexChanged);
            // 
            // departmentsTableLayoutPanel
            // 
            this.departmentsTableLayoutPanel.ColumnCount = 2;
            this.departmentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.departmentsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.departmentsTableLayoutPanel.Controls.Add(this.departmentsListBox, 0, 0);
            this.departmentsTableLayoutPanel.Controls.Add(this.addDepartmentBtn, 1, 0);
            this.departmentsTableLayoutPanel.Controls.Add(this.deleteDepartmentBtn, 1, 1);
            this.departmentsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.departmentsTableLayoutPanel.Location = new System.Drawing.Point(0, 55);
            this.departmentsTableLayoutPanel.Name = "departmentsTableLayoutPanel";
            this.departmentsTableLayoutPanel.RowCount = 2;
            this.departmentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.departmentsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.departmentsTableLayoutPanel.Size = new System.Drawing.Size(484, 88);
            this.departmentsTableLayoutPanel.TabIndex = 2;
            // 
            // addDepartmentBtn
            // 
            this.addDepartmentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addDepartmentBtn.AutoSize = true;
            this.addDepartmentBtn.Location = new System.Drawing.Point(390, 10);
            this.addDepartmentBtn.Name = "addDepartmentBtn";
            this.addDepartmentBtn.Size = new System.Drawing.Size(91, 23);
            this.addDepartmentBtn.TabIndex = 2;
            this.addDepartmentBtn.Text = "Ajouter";
            this.addDepartmentBtn.UseVisualStyleBackColor = true;
            this.addDepartmentBtn.Click += new System.EventHandler(this.addDepartmentBtn_Click);
            // 
            // deleteDepartmentBtn
            // 
            this.deleteDepartmentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteDepartmentBtn.AutoSize = true;
            this.deleteDepartmentBtn.Enabled = false;
            this.deleteDepartmentBtn.Location = new System.Drawing.Point(390, 54);
            this.deleteDepartmentBtn.Name = "deleteDepartmentBtn";
            this.deleteDepartmentBtn.Size = new System.Drawing.Size(91, 23);
            this.deleteDepartmentBtn.TabIndex = 3;
            this.deleteDepartmentBtn.Text = "Supprimer";
            this.deleteDepartmentBtn.UseVisualStyleBackColor = true;
            this.deleteDepartmentBtn.Click += new System.EventHandler(this.deleteDepartmentBtn_Click);
            // 
            // mainFormTableLayoutPanel
            // 
            this.mainFormTableLayoutPanel.ColumnCount = 2;
            this.mainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainFormTableLayoutPanel.Controls.Add(label2, 0, 0);
            this.mainFormTableLayoutPanel.Controls.Add(this.lastnameTextBox, 1, 0);
            this.mainFormTableLayoutPanel.Controls.Add(label3, 0, 1);
            this.mainFormTableLayoutPanel.Controls.Add(this.firstnameTextBox, 1, 1);
            this.mainFormTableLayoutPanel.Controls.Add(label4, 0, 2);
            this.mainFormTableLayoutPanel.Controls.Add(this.salaryNumericUpDown, 1, 2);
            this.mainFormTableLayoutPanel.Controls.Add(label5, 0, 3);
            this.mainFormTableLayoutPanel.Controls.Add(this.hiredDateTimePicker, 1, 3);
            this.mainFormTableLayoutPanel.Controls.Add(label1, 0, 4);
            this.mainFormTableLayoutPanel.Controls.Add(this.photoPictureBox, 1, 4);
            this.mainFormTableLayoutPanel.Controls.Add(this.photoBrowseBtn, 1, 5);
            this.mainFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormTableLayoutPanel.Location = new System.Drawing.Point(0, 143);
            this.mainFormTableLayoutPanel.Name = "mainFormTableLayoutPanel";
            this.mainFormTableLayoutPanel.RowCount = 6;
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainFormTableLayoutPanel.Size = new System.Drawing.Size(484, 248);
            this.mainFormTableLayoutPanel.TabIndex = 3;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastnameTextBox.Location = new System.Drawing.Point(196, 3);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(240, 20);
            this.lastnameTextBox.TabIndex = 4;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstnameTextBox.Location = new System.Drawing.Point(196, 29);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(240, 20);
            this.firstnameTextBox.TabIndex = 5;
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.salaryNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.salaryNumericUpDown.Location = new System.Drawing.Point(196, 55);
            this.salaryNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.salaryNumericUpDown.TabIndex = 6;
            this.salaryNumericUpDown.ThousandsSeparator = true;
            // 
            // hiredDateTimePicker
            // 
            this.hiredDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hiredDateTimePicker.Checked = false;
            this.hiredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hiredDateTimePicker.Location = new System.Drawing.Point(196, 81);
            this.hiredDateTimePicker.Name = "hiredDateTimePicker";
            this.hiredDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.hiredDateTimePicker.TabIndex = 7;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPictureBox.Location = new System.Drawing.Point(196, 107);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 8;
            this.photoPictureBox.TabStop = false;
            // 
            // photoBrowseBtn
            // 
            this.photoBrowseBtn.Location = new System.Drawing.Point(196, 213);
            this.photoBrowseBtn.Name = "photoBrowseBtn";
            this.photoBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.photoBrowseBtn.TabIndex = 10;
            this.photoBrowseBtn.Text = "Parcourir...";
            this.photoBrowseBtn.UseVisualStyleBackColor = true;
            this.photoBrowseBtn.Click += new System.EventHandler(this.photoBrowseBtn_Click);
            // 
            // formActionsTableLayoutPanel
            // 
            this.formActionsTableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.formActionsTableLayoutPanel.ColumnCount = 5;
            this.formActionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.formActionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formActionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formActionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formActionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.formActionsTableLayoutPanel.Controls.Add(this.previousBtn, 0, 0);
            this.formActionsTableLayoutPanel.Controls.Add(this.newBtn, 1, 0);
            this.formActionsTableLayoutPanel.Controls.Add(this.saveBtn, 2, 0);
            this.formActionsTableLayoutPanel.Controls.Add(this.deleteBtn, 3, 0);
            this.formActionsTableLayoutPanel.Controls.Add(this.nextBtn, 4, 0);
            this.formActionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formActionsTableLayoutPanel.Location = new System.Drawing.Point(0, 391);
            this.formActionsTableLayoutPanel.Name = "formActionsTableLayoutPanel";
            this.formActionsTableLayoutPanel.RowCount = 1;
            this.formActionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.formActionsTableLayoutPanel.Size = new System.Drawing.Size(484, 30);
            this.formActionsTableLayoutPanel.TabIndex = 0;
            // 
            // previousBtn
            // 
            this.previousBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousBtn.Location = new System.Drawing.Point(3, 3);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(54, 24);
            this.previousBtn.TabIndex = 0;
            this.previousBtn.Text = "<<";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newBtn.Enabled = false;
            this.newBtn.Location = new System.Drawing.Point(63, 3);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(115, 24);
            this.newBtn.TabIndex = 1;
            this.newBtn.Text = "Nouveau";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.Location = new System.Drawing.Point(184, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(115, 24);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Sauvegarder";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.Location = new System.Drawing.Point(305, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(115, 24);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Supprimer";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextBtn.Location = new System.Drawing.Point(426, 3);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(55, 24);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = ">>";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // photoOpenFileDialog
            // 
            this.photoOpenFileDialog.Filter = "Fichiers images (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif|Tous les fichiers (*.*)|*.*" +
    "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 421);
            this.Controls.Add(this.mainFormTableLayoutPanel);
            this.Controls.Add(this.formActionsTableLayoutPanel);
            this.Controls.Add(this.departmentsTableLayoutPanel);
            this.Controls.Add(titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "CLG HR";
            this.departmentsTableLayoutPanel.ResumeLayout(false);
            this.departmentsTableLayoutPanel.PerformLayout();
            this.mainFormTableLayoutPanel.ResumeLayout(false);
            this.mainFormTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.formActionsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox departmentsListBox;
        private System.Windows.Forms.TableLayoutPanel departmentsTableLayoutPanel;
        private System.Windows.Forms.Button addDepartmentBtn;
        private System.Windows.Forms.Button deleteDepartmentBtn;
        private System.Windows.Forms.TableLayoutPanel mainFormTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel formActionsTableLayoutPanel;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.NumericUpDown salaryNumericUpDown;
        private System.Windows.Forms.DateTimePicker hiredDateTimePicker;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button photoBrowseBtn;
        private System.Windows.Forms.OpenFileDialog photoOpenFileDialog;
    }
}

