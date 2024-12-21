namespace CarRental
{
    partial class Return
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Returndate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.fineTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.RentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustnameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.customer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DelayTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Retrn = new System.Windows.Forms.Label();
            this.CaridTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ReturnDGV = new System.Windows.Forms.Label();
            this.ReturnDVG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 76);
            this.panel1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.purepng_com_red_ford_taurus_front_carcarvehicletransportford_961524663610bic6i;
            this.pictureBox1.Location = new System.Drawing.Point(32, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(888, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Return";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Car rental System";
            // 
            // Returndate
            // 
            this.Returndate.CheckedState.Parent = this.Returndate;
            this.Returndate.FillColor = System.Drawing.Color.OrangeRed;
            this.Returndate.FocusedColor = System.Drawing.Color.White;
            this.Returndate.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returndate.ForeColor = System.Drawing.Color.White;
            this.Returndate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Returndate.HoverState.Parent = this.Returndate;
            this.Returndate.Location = new System.Drawing.Point(130, 271);
            this.Returndate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Returndate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Returndate.Name = "Returndate";
            this.Returndate.ShadowDecoration.Parent = this.Returndate;
            this.Returndate.Size = new System.Drawing.Size(225, 36);
            this.Returndate.TabIndex = 84;
            this.Returndate.Value = new System.DateTime(2020, 12, 15, 10, 52, 25, 68);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(0, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 26);
            this.label11.TabIndex = 83;
            this.label11.Text = "Return Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(32, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 26);
            this.label10.TabIndex = 81;
            this.label10.Text = "Carid";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 28);
            this.panel2.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(276, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 90;
            // 
            // fineTb
            // 
            this.fineTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fineTb.Enabled = false;
            this.fineTb.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.fineTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.fineTb.HintForeColor = System.Drawing.Color.Empty;
            this.fineTb.HintText = "";
            this.fineTb.isPassword = true;
            this.fineTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.fineTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.fineTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.fineTb.LineThickness = 4;
            this.fineTb.Location = new System.Drawing.Point(119, 356);
            this.fineTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fineTb.Name = "fineTb";
            this.fineTb.Size = new System.Drawing.Size(225, 31);
            this.fineTb.TabIndex = 77;
            this.fineTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(32, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 26);
            this.label8.TabIndex = 76;
            this.label8.Text = "fine";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // RentDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.RentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RentDGV.BackgroundColor = System.Drawing.Color.White;
            this.RentDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RentDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RentDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RentDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RentDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.RentDGV.EnableHeadersVisualStyles = false;
            this.RentDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RentDGV.Location = new System.Drawing.Point(380, 125);
            this.RentDGV.Name = "RentDGV";
            this.RentDGV.RowHeadersVisible = false;
            this.RentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RentDGV.Size = new System.Drawing.Size(538, 142);
            this.RentDGV.TabIndex = 75;
            this.RentDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RentDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RentDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OrangeRed;
            this.RentDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RentDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RentDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.RentDGV.ThemeStyle.ReadOnly = false;
            this.RentDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RentDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RentDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RentDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RentDGV.ThemeStyle.RowsStyle.Height = 22;
            this.RentDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RentDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(153, 439);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 30);
            this.button4.TabIndex = 74;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(289, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 30);
            this.button3.TabIndex = 73;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(144, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 30);
            this.button2.TabIndex = 72;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(17, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 71;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTb
            // 
            this.idTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTb.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.idTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.idTb.HintForeColor = System.Drawing.Color.Empty;
            this.idTb.HintText = "";
            this.idTb.isPassword = false;
            this.idTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.idTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.idTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.idTb.LineThickness = 4;
            this.idTb.Location = new System.Drawing.Point(119, 111);
            this.idTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(225, 31);
            this.idTb.TabIndex = 70;
            this.idTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(74, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 26);
            this.label7.TabIndex = 69;
            this.label7.Text = "ID";
            // 
            // CustnameTb
            // 
            this.CustnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustnameTb.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CustnameTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.CustnameTb.HintForeColor = System.Drawing.Color.Empty;
            this.CustnameTb.HintText = "";
            this.CustnameTb.isPassword = false;
            this.CustnameTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.CustnameTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.CustnameTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.CustnameTb.LineThickness = 4;
            this.CustnameTb.Location = new System.Drawing.Point(112, 212);
            this.CustnameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CustnameTb.Name = "CustnameTb";
            this.CustnameTb.Size = new System.Drawing.Size(225, 31);
            this.CustnameTb.TabIndex = 68;
            this.CustnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.customer.ForeColor = System.Drawing.Color.OrangeRed;
            this.customer.Location = new System.Drawing.Point(40, 215);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(66, 26);
            this.customer.TabIndex = 66;
            this.customer.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(566, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 26);
            this.label6.TabIndex = 65;
            this.label6.Text = "Cars On Rent";
            // 
            // DelayTb
            // 
            this.DelayTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DelayTb.Enabled = false;
            this.DelayTb.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.DelayTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.DelayTb.HintForeColor = System.Drawing.Color.Empty;
            this.DelayTb.HintText = "";
            this.DelayTb.isPassword = true;
            this.DelayTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.DelayTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.DelayTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.DelayTb.LineThickness = 4;
            this.DelayTb.Location = new System.Drawing.Point(118, 314);
            this.DelayTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DelayTb.Name = "DelayTb";
            this.DelayTb.Size = new System.Drawing.Size(226, 31);
            this.DelayTb.TabIndex = 86;
            this.DelayTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Retrn
            // 
            this.Retrn.AutoSize = true;
            this.Retrn.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.Retrn.ForeColor = System.Drawing.Color.OrangeRed;
            this.Retrn.Location = new System.Drawing.Point(27, 314);
            this.Retrn.Name = "Retrn";
            this.Retrn.Size = new System.Drawing.Size(65, 26);
            this.Retrn.TabIndex = 85;
            this.Retrn.Text = "Delay";
            // 
            // CaridTb
            // 
            this.CaridTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CaridTb.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.CaridTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.CaridTb.HintForeColor = System.Drawing.Color.Empty;
            this.CaridTb.HintText = "";
            this.CaridTb.isPassword = false;
            this.CaridTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.CaridTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.CaridTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.CaridTb.LineThickness = 4;
            this.CaridTb.Location = new System.Drawing.Point(103, 160);
            this.CaridTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CaridTb.Name = "CaridTb";
            this.CaridTb.Size = new System.Drawing.Size(225, 31);
            this.CaridTb.TabIndex = 87;
            this.CaridTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ReturnDGV
            // 
            this.ReturnDGV.AutoSize = true;
            this.ReturnDGV.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDGV.ForeColor = System.Drawing.Color.OrangeRed;
            this.ReturnDGV.Location = new System.Drawing.Point(526, 270);
            this.ReturnDGV.Name = "ReturnDGV";
            this.ReturnDGV.Size = new System.Drawing.Size(208, 26);
            this.ReturnDGV.TabIndex = 88;
            this.ReturnDGV.Text = "Cars Returned";
            // 
            // ReturnDVG
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.ReturnDVG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ReturnDVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReturnDVG.BackgroundColor = System.Drawing.Color.White;
            this.ReturnDVG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReturnDVG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReturnDVG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnDVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ReturnDVG.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReturnDVG.DefaultCellStyle = dataGridViewCellStyle6;
            this.ReturnDVG.EnableHeadersVisualStyles = false;
            this.ReturnDVG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnDVG.Location = new System.Drawing.Point(402, 314);
            this.ReturnDVG.Name = "ReturnDVG";
            this.ReturnDVG.RowHeadersVisible = false;
            this.ReturnDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReturnDVG.Size = new System.Drawing.Size(516, 137);
            this.ReturnDVG.TabIndex = 89;
            this.ReturnDVG.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ReturnDVG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReturnDVG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReturnDVG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ReturnDVG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReturnDVG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReturnDVG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReturnDVG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnDVG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OrangeRed;
            this.ReturnDVG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReturnDVG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDVG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReturnDVG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReturnDVG.ThemeStyle.HeaderStyle.Height = 30;
            this.ReturnDVG.ThemeStyle.ReadOnly = false;
            this.ReturnDVG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReturnDVG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReturnDVG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReturnDVG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReturnDVG.ThemeStyle.RowsStyle.Height = 22;
            this.ReturnDVG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnDVG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT Condensed", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(283, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 31);
            this.label5.TabIndex = 91;
            this.label5.Text = "SET BY SALLO SENIOR -659325548";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.ReturnDVG);
            this.Controls.Add(this.ReturnDGV);
            this.Controls.Add(this.CaridTb);
            this.Controls.Add(this.DelayTb);
            this.Controls.Add(this.Retrn);
            this.Controls.Add(this.Returndate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fineTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RentDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CustnameTb);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDVG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker Returndate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fineTb;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView RentDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idTb;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustnameTb;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DelayTb;
        private System.Windows.Forms.Label Retrn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CaridTb;
        private System.Windows.Forms.Label ReturnDGV;
        private Guna.UI2.WinForms.Guna2DataGridView ReturnDVG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}