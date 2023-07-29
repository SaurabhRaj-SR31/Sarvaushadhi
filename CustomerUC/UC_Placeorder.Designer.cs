namespace PharmacyManagementSystem.CustomerUC
{
    partial class UC_Placeorder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Placeorder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtfinalprice = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnpurchase = new Guna.UI.WinForms.GunaButton();
            this.btnremove = new Guna.UI.WinForms.GunaButton();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaddtocart = new Guna.UI.WinForms.GunaButton();
            this.txttotalprice = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtquantity = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmedname = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcname = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcid = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listboxmedicines = new System.Windows.Forms.ListBox();
            this.txtsearchbox = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsync = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmedid = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfinalprice
            // 
            this.txtfinalprice.AutoSize = true;
            this.txtfinalprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtfinalprice.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfinalprice.Location = new System.Drawing.Point(494, 659);
            this.txtfinalprice.Name = "txtfinalprice";
            this.txtfinalprice.Size = new System.Drawing.Size(122, 41);
            this.txtfinalprice.TabIndex = 57;
            this.txtfinalprice.Text = "Rs. 00";
            this.txtfinalprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtfinalprice.Click += new System.EventHandler(this.txtfinalprice_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(353, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 56;
            // 
            // btnpurchase
            // 
            this.btnpurchase.AnimationHoverSpeed = 0.07F;
            this.btnpurchase.AnimationSpeed = 0.03F;
            this.btnpurchase.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnpurchase.BorderColor = System.Drawing.Color.Black;
            this.btnpurchase.Cursor = System.Windows.Forms.Cursors.No;
            this.btnpurchase.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnpurchase.FocusedColor = System.Drawing.Color.Empty;
            this.btnpurchase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnpurchase.ForeColor = System.Drawing.Color.White;
            this.btnpurchase.Image = null;
            this.btnpurchase.ImageSize = new System.Drawing.Size(20, 20);
            this.btnpurchase.Location = new System.Drawing.Point(664, 658);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnpurchase.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnpurchase.OnHoverForeColor = System.Drawing.Color.White;
            this.btnpurchase.OnHoverImage = null;
            this.btnpurchase.OnPressedColor = System.Drawing.Color.Black;
            this.btnpurchase.Size = new System.Drawing.Size(160, 42);
            this.btnpurchase.TabIndex = 55;
            this.btnpurchase.Text = "Purchase & Print";
            this.btnpurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // btnremove
            // 
            this.btnremove.AnimationHoverSpeed = 0.07F;
            this.btnremove.AnimationSpeed = 0.03F;
            this.btnremove.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnremove.BorderColor = System.Drawing.Color.Black;
            this.btnremove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnremove.FocusedColor = System.Drawing.Color.Empty;
            this.btnremove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.Image = ((System.Drawing.Image)(resources.GetObject("btnremove.Image")));
            this.btnremove.ImageSize = new System.Drawing.Size(20, 20);
            this.btnremove.Location = new System.Drawing.Point(286, 659);
            this.btnremove.Name = "btnremove";
            this.btnremove.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnremove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnremove.OnHoverForeColor = System.Drawing.Color.White;
            this.btnremove.OnHoverImage = null;
            this.btnremove.OnPressedColor = System.Drawing.Color.Black;
            this.btnremove.Size = new System.Drawing.Size(160, 42);
            this.btnremove.TabIndex = 54;
            this.btnremove.Text = "Remove";
            this.btnremove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeight = 35;
            this.gunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(277, 471);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 62;
            this.gunaDataGridView1.RowTemplate.Height = 28;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(547, 168);
            this.gunaDataGridView1.TabIndex = 53;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "c_Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "m_id";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "quantity";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total_Price";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.AnimationHoverSpeed = 0.07F;
            this.btnaddtocart.AnimationSpeed = 0.03F;
            this.btnaddtocart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnaddtocart.BorderColor = System.Drawing.Color.Black;
            this.btnaddtocart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnaddtocart.FocusedColor = System.Drawing.Color.Empty;
            this.btnaddtocart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnaddtocart.ForeColor = System.Drawing.Color.White;
            this.btnaddtocart.Image = ((System.Drawing.Image)(resources.GetObject("btnaddtocart.Image")));
            this.btnaddtocart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnaddtocart.Location = new System.Drawing.Point(664, 423);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnaddtocart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnaddtocart.OnHoverForeColor = System.Drawing.Color.White;
            this.btnaddtocart.OnHoverImage = null;
            this.btnaddtocart.OnPressedColor = System.Drawing.Color.Black;
            this.btnaddtocart.Size = new System.Drawing.Size(160, 42);
            this.btnaddtocart.TabIndex = 52;
            this.btnaddtocart.Text = "Add to Cart";
            this.btnaddtocart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // txttotalprice
            // 
            this.txttotalprice.BaseColor = System.Drawing.Color.White;
            this.txttotalprice.BorderColor = System.Drawing.Color.Silver;
            this.txttotalprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttotalprice.FocusedBaseColor = System.Drawing.Color.White;
            this.txttotalprice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttotalprice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttotalprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalprice.ForeColor = System.Drawing.Color.Black;
            this.txttotalprice.Location = new System.Drawing.Point(619, 354);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.PasswordChar = '\0';
            this.txttotalprice.ReadOnly = true;
            this.txttotalprice.SelectedText = "";
            this.txttotalprice.Size = new System.Drawing.Size(205, 42);
            this.txttotalprice.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(614, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 29);
            this.label9.TabIndex = 50;
            this.label9.Text = "Total Price";
            // 
            // txtquantity
            // 
            this.txtquantity.BaseColor = System.Drawing.Color.White;
            this.txtquantity.BorderColor = System.Drawing.Color.Silver;
            this.txtquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtquantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtquantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtquantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtquantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.ForeColor = System.Drawing.Color.Black;
            this.txtquantity.Location = new System.Drawing.Point(619, 248);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.PasswordChar = '\0';
            this.txtquantity.SelectedText = "";
            this.txtquantity.Size = new System.Drawing.Size(205, 42);
            this.txtquantity.TabIndex = 49;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 48;
            this.label6.Text = "No. of Units";
            // 
            // txtmedname
            // 
            this.txtmedname.BaseColor = System.Drawing.Color.White;
            this.txtmedname.BorderColor = System.Drawing.Color.Silver;
            this.txtmedname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmedname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtmedname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtmedname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmedname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedname.ForeColor = System.Drawing.Color.Black;
            this.txtmedname.Location = new System.Drawing.Point(619, 154);
            this.txtmedname.Name = "txtmedname";
            this.txtmedname.PasswordChar = '\0';
            this.txtmedname.SelectedText = "";
            this.txtmedname.Size = new System.Drawing.Size(205, 42);
            this.txtmedname.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(614, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 29);
            this.label7.TabIndex = 46;
            this.label7.Text = "Medicine Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 44;
            this.label5.Text = "Medicine ID";
            // 
            // txtcname
            // 
            this.txtcname.BaseColor = System.Drawing.Color.White;
            this.txtcname.BorderColor = System.Drawing.Color.Silver;
            this.txtcname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcname.ForeColor = System.Drawing.Color.Black;
            this.txtcname.Location = new System.Drawing.Point(277, 248);
            this.txtcname.Name = "txtcname";
            this.txtcname.PasswordChar = '\0';
            this.txtcname.SelectedText = "";
            this.txtcname.Size = new System.Drawing.Size(277, 42);
            this.txtcname.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Customer Name";
            // 
            // txtcid
            // 
            this.txtcid.BaseColor = System.Drawing.Color.White;
            this.txtcid.BorderColor = System.Drawing.Color.Silver;
            this.txtcid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcid.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.ForeColor = System.Drawing.Color.Black;
            this.txtcid.Location = new System.Drawing.Point(277, 154);
            this.txtcid.Name = "txtcid";
            this.txtcid.PasswordChar = '\0';
            this.txtcid.SelectedText = "";
            this.txtcid.Size = new System.Drawing.Size(277, 42);
            this.txtcid.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "Customer ID";
            // 
            // listboxmedicines
            // 
            this.listboxmedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxmedicines.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listboxmedicines.FormattingEnabled = true;
            this.listboxmedicines.ItemHeight = 29;
            this.listboxmedicines.Location = new System.Drawing.Point(17, 216);
            this.listboxmedicines.Name = "listboxmedicines";
            this.listboxmedicines.Size = new System.Drawing.Size(249, 468);
            this.listboxmedicines.TabIndex = 39;
            this.listboxmedicines.SelectedIndexChanged += new System.EventHandler(this.listboxmedicines_SelectedIndexChanged);
            // 
            // txtsearchbox
            // 
            this.txtsearchbox.BaseColor = System.Drawing.Color.White;
            this.txtsearchbox.BorderColor = System.Drawing.Color.Silver;
            this.txtsearchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearchbox.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsearchbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsearchbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsearchbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbox.ForeColor = System.Drawing.Color.Black;
            this.txtsearchbox.Location = new System.Drawing.Point(12, 154);
            this.txtsearchbox.Name = "txtsearchbox";
            this.txtsearchbox.PasswordChar = '\0';
            this.txtsearchbox.SelectedText = "";
            this.txtsearchbox.Size = new System.Drawing.Size(249, 42);
            this.txtsearchbox.TabIndex = 38;
            this.txtsearchbox.TextChanged += new System.EventHandler(this.txtsearchbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Search";
            // 
            // btnsync
            // 
            this.btnsync.AnimationHoverSpeed = 0.07F;
            this.btnsync.AnimationSpeed = 0.03F;
            this.btnsync.BackColor = System.Drawing.Color.White;
            this.btnsync.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnsync.BorderColor = System.Drawing.Color.Black;
            this.btnsync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsync.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsync.FocusedColor = System.Drawing.Color.Empty;
            this.btnsync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsync.ForeColor = System.Drawing.Color.White;
            this.btnsync.Image = null;
            this.btnsync.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsync.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsync.Location = new System.Drawing.Point(251, 19);
            this.btnsync.Name = "btnsync";
            this.btnsync.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnsync.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsync.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsync.OnHoverImage = null;
            this.btnsync.OnPressedColor = System.Drawing.Color.Black;
            this.btnsync.Size = new System.Drawing.Size(89, 50);
            this.btnsync.TabIndex = 36;
            this.btnsync.Text = "Refresh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 49);
            this.label1.TabIndex = 34;
            this.label1.Text = "CART";
            // 
            // txtmedid
            // 
            this.txtmedid.BaseColor = System.Drawing.Color.White;
            this.txtmedid.BorderColor = System.Drawing.Color.Silver;
            this.txtmedid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmedid.FocusedBaseColor = System.Drawing.Color.White;
            this.txtmedid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtmedid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmedid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedid.ForeColor = System.Drawing.Color.Black;
            this.txtmedid.Location = new System.Drawing.Point(277, 354);
            this.txtmedid.Name = "txtmedid";
            this.txtmedid.PasswordChar = '\0';
            this.txtmedid.SelectedText = "";
            this.txtmedid.Size = new System.Drawing.Size(277, 42);
            this.txtmedid.TabIndex = 58;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // UC_Placeorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.txtmedid);
            this.Controls.Add(this.txtfinalprice);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnpurchase);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.btnaddtocart);
            this.Controls.Add(this.txttotalprice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmedname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listboxmedicines);
            this.Controls.Add(this.txtsearchbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsync);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Placeorder";
            this.Size = new System.Drawing.Size(930, 720);
            this.Load += new System.EventHandler(this.UC_Placeorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtfinalprice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaButton btnpurchase;
        private Guna.UI.WinForms.GunaButton btnremove;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaButton btnaddtocart;
        private Guna.UI.WinForms.GunaTextBox txttotalprice;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtquantity;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtmedname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtcname;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtcid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listboxmedicines;
        private Guna.UI.WinForms.GunaTextBox txtsearchbox;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnsync;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtmedid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
