namespace CarRental
{
    partial class Rental
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
            this.label9 = new System.Windows.Forms.Label();
            this.carRegTb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RentFeeTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.RentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustnameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Rentdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Returndate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.Custid = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(3, 361);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 33);
            this.label9.TabIndex = 58;
            this.label9.Text = "Rental Date";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // carRegTb
            // 
            this.carRegTb.BackColor = System.Drawing.Color.Transparent;
            this.carRegTb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carRegTb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carRegTb.FocusedColor = System.Drawing.Color.Empty;
            this.carRegTb.FocusedState.Parent = this.carRegTb;
            this.carRegTb.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.carRegTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.carRegTb.FormattingEnabled = true;
            this.carRegTb.HoverState.Parent = this.carRegTb;
            this.carRegTb.ItemHeight = 30;
            this.carRegTb.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.carRegTb.ItemsAppearance.Parent = this.carRegTb;
            this.carRegTb.Location = new System.Drawing.Point(169, 196);
            this.carRegTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carRegTb.Name = "carRegTb";
            this.carRegTb.ShadowDecoration.Parent = this.carRegTb;
            this.carRegTb.Size = new System.Drawing.Size(299, 36);
            this.carRegTb.TabIndex = 57;
            this.carRegTb.SelectionChangeCommitted += new System.EventHandler(this.carRegTb_SelectionChangeCommitted);
            // 
            // RentFeeTb
            // 
            this.RentFeeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RentFeeTb.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.RentFeeTb.ForeColor = System.Drawing.Color.OrangeRed;
            this.RentFeeTb.HintForeColor = System.Drawing.Color.Empty;
            this.RentFeeTb.HintText = "";
            this.RentFeeTb.isPassword = true;
            this.RentFeeTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.RentFeeTb.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.RentFeeTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.RentFeeTb.LineThickness = 4;
            this.RentFeeTb.Location = new System.Drawing.Point(169, 449);
            this.RentFeeTb.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RentFeeTb.Name = "RentFeeTb";
            this.RentFeeTb.Size = new System.Drawing.Size(300, 39);
            this.RentFeeTb.TabIndex = 56;
            this.RentFeeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(27, 449);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 33);
            this.label8.TabIndex = 55;
            this.label8.Text = "Rent Fee";
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
            this.RentDGV.Location = new System.Drawing.Point(492, 182);
            this.RentDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentDGV.Name = "RentDGV";
            this.RentDGV.RowHeadersVisible = false;
            this.RentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RentDGV.Size = new System.Drawing.Size(707, 310);
            this.RentDGV.TabIndex = 54;
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
            this.button4.Location = new System.Drawing.Point(215, 551);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 37);
            this.button4.TabIndex = 53;
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
            this.button3.Location = new System.Drawing.Point(396, 506);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 37);
            this.button3.TabIndex = 52;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(203, 507);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 37);
            this.button2.TabIndex = 51;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 506);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 37);
            this.button1.TabIndex = 50;
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
            this.idTb.Location = new System.Drawing.Point(169, 148);
            this.idTb.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(300, 39);
            this.idTb.TabIndex = 49;
            this.idTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idTb.OnValueChanged += new System.EventHandler(this.idTb_OnValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(109, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 33);
            this.label7.TabIndex = 48;
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
            this.CustnameTb.Location = new System.Drawing.Point(169, 298);
            this.CustnameTb.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CustnameTb.Name = "CustnameTb";
            this.CustnameTb.Size = new System.Drawing.Size(300, 39);
            this.CustnameTb.TabIndex = 47;
            this.CustnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(53, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 33);
            this.label4.TabIndex = 45;
            this.label4.Text = "CustID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(69, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 33);
            this.label5.TabIndex = 44;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(765, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 34);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cars On Rent";
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 94);
            this.panel1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.purepng_com_red_ford_taurus_front_carcarvehicletransportford_961524663610bic6i;
            this.pictureBox1.Location = new System.Drawing.Point(43, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1159, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Car rental System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 595);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 31);
            this.panel2.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bodoni MT Condensed", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(349, -4);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(558, 38);
            this.label12.TabIndex = 26;
            this.label12.Text = "SET BY RAHMA JAMA ADN AWO ALI 4010673/3092667\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(53, 208);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 33);
            this.label10.TabIndex = 60;
            this.label10.Text = "CarReg";
            // 
            // Rentdate
            // 
            this.Rentdate.CheckedState.Parent = this.Rentdate;
            this.Rentdate.FillColor = System.Drawing.Color.OrangeRed;
            this.Rentdate.FocusedColor = System.Drawing.Color.White;
            this.Rentdate.Font = new System.Drawing.Font("Century Schoolbook", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rentdate.ForeColor = System.Drawing.Color.White;
            this.Rentdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Rentdate.HoverState.Parent = this.Rentdate;
            this.Rentdate.Location = new System.Drawing.Point(169, 348);
            this.Rentdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rentdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Rentdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Rentdate.Name = "Rentdate";
            this.Rentdate.ShadowDecoration.Parent = this.Rentdate;
            this.Rentdate.Size = new System.Drawing.Size(300, 44);
            this.Rentdate.TabIndex = 61;
            this.Rentdate.Value = new System.DateTime(2020, 12, 15, 12, 54, 1, 230);
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
            this.Returndate.Location = new System.Drawing.Point(169, 400);
            this.Returndate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Returndate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Returndate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Returndate.Name = "Returndate";
            this.Returndate.ShadowDecoration.Parent = this.Returndate;
            this.Returndate.Size = new System.Drawing.Size(300, 44);
            this.Returndate.TabIndex = 63;
            this.Returndate.Value = new System.DateTime(2020, 12, 15, 10, 52, 25, 68);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(3, 405);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 33);
            this.label11.TabIndex = 62;
            this.label11.Text = "Return Date";
            // 
            // Custid
            // 
            this.Custid.BackColor = System.Drawing.Color.Transparent;
            this.Custid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Custid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Custid.FocusedColor = System.Drawing.Color.Empty;
            this.Custid.FocusedState.Parent = this.Custid;
            this.Custid.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.Custid.ForeColor = System.Drawing.Color.OrangeRed;
            this.Custid.FormattingEnabled = true;
            this.Custid.HoverState.Parent = this.Custid;
            this.Custid.ItemHeight = 30;
            this.Custid.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.Custid.ItemsAppearance.Parent = this.Custid;
            this.Custid.Location = new System.Drawing.Point(165, 254);
            this.Custid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Custid.Name = "Custid";
            this.Custid.ShadowDecoration.Parent = this.Custid;
            this.Custid.Size = new System.Drawing.Size(299, 36);
            this.Custid.TabIndex = 64;
            this.Custid.SelectionChangeCommitted += new System.EventHandler(this.Custid_SelectionChangeCommitted);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 626);
            this.Controls.Add(this.Custid);
            this.Controls.Add(this.Returndate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Rentdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.carRegTb);
            this.Controls.Add(this.RentFeeTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RentDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CustnameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox carRegTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox RentFeeTb;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView RentDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idTb;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CustnameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker Rentdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker Returndate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox Custid;
    }
}