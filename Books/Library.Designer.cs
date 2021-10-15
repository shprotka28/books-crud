namespace Books
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ControlContainer = new MetroFramework.Controls.MetroPanel();
            this.GenreLabel = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.Author = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtBookAuthor = new MetroFramework.Controls.MetroTextBox();
            this.txtBookName = new MetroFramework.Controls.MetroTextBox();
            this.labelbookID = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtBookID = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.PDFreader = new AxAcroPDFLib.AxAcroPDF();
            this.FilesMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.file_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.load = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contentDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pdfLibraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDFreader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfLibraryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlContainer
            // 
            this.ControlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlContainer.Controls.Add(this.GenreLabel);
            this.ControlContainer.Controls.Add(this.metroTextBox1);
            this.ControlContainer.Controls.Add(this.Author);
            this.ControlContainer.Controls.Add(this.htmlLabel4);
            this.ControlContainer.Controls.Add(this.txtBookAuthor);
            this.ControlContainer.Controls.Add(this.txtBookName);
            this.ControlContainer.Controls.Add(this.labelbookID);
            this.ControlContainer.Controls.Add(this.txtBookID);
            this.ControlContainer.HorizontalScrollbarBarColor = true;
            this.ControlContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.ControlContainer.HorizontalScrollbarSize = 6;
            this.ControlContainer.Location = new System.Drawing.Point(34, 66);
            this.ControlContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ControlContainer.Name = "ControlContainer";
            this.ControlContainer.Size = new System.Drawing.Size(321, 208);
            this.ControlContainer.TabIndex = 1;
            this.ControlContainer.VerticalScrollbarBarColor = true;
            this.ControlContainer.VerticalScrollbarHighlightOnWheel = false;
            this.ControlContainer.VerticalScrollbarSize = 7;
            this.ControlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoScroll = true;
            this.GenreLabel.AutoScrollMinSize = new System.Drawing.Size(52, 32);
            this.GenreLabel.AutoSize = false;
            this.GenreLabel.BackColor = System.Drawing.SystemColors.Window;
            this.GenreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(26, 139);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(117, 28);
            this.GenreLabel.TabIndex = 7;
            this.GenreLabel.Text = "Genre";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(163, 144);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(143, 22);
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Author
            // 
            this.Author.AutoScroll = true;
            this.Author.AutoScrollMinSize = new System.Drawing.Size(58, 32);
            this.Author.AutoSize = false;
            this.Author.BackColor = System.Drawing.SystemColors.Window;
            this.Author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.Location = new System.Drawing.Point(26, 101);
            this.Author.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(116, 24);
            this.Author.TabIndex = 4;
            this.Author.Text = "Author";
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(52, 32);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel4.Location = new System.Drawing.Point(26, 59);
            this.htmlLabel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(116, 28);
            this.htmlLabel4.TabIndex = 4;
            this.htmlLabel4.Text = "Name";
            // 
            // txtBookAuthor
            // 
            // 
            // 
            // 
            this.txtBookAuthor.CustomButton.Image = null;
            this.txtBookAuthor.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtBookAuthor.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookAuthor.CustomButton.Name = "";
            this.txtBookAuthor.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txtBookAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookAuthor.CustomButton.TabIndex = 1;
            this.txtBookAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookAuthor.CustomButton.UseSelectable = true;
            this.txtBookAuthor.CustomButton.Visible = false;
            this.txtBookAuthor.Lines = new string[0];
            this.txtBookAuthor.Location = new System.Drawing.Point(163, 103);
            this.txtBookAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBookAuthor.MaxLength = 32767;
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.PasswordChar = '\0';
            this.txtBookAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookAuthor.SelectedText = "";
            this.txtBookAuthor.SelectionLength = 0;
            this.txtBookAuthor.SelectionStart = 0;
            this.txtBookAuthor.ShortcutsEnabled = true;
            this.txtBookAuthor.Size = new System.Drawing.Size(143, 22);
            this.txtBookAuthor.TabIndex = 5;
            this.txtBookAuthor.UseSelectable = true;
            this.txtBookAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBookName
            // 
            // 
            // 
            // 
            this.txtBookName.CustomButton.Image = null;
            this.txtBookName.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtBookName.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookName.CustomButton.Name = "";
            this.txtBookName.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txtBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookName.CustomButton.TabIndex = 1;
            this.txtBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookName.CustomButton.UseSelectable = true;
            this.txtBookName.CustomButton.Visible = false;
            this.txtBookName.Lines = new string[0];
            this.txtBookName.Location = new System.Drawing.Point(163, 65);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBookName.MaxLength = 32767;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PasswordChar = '\0';
            this.txtBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookName.SelectedText = "";
            this.txtBookName.SelectionLength = 0;
            this.txtBookName.SelectionStart = 0;
            this.txtBookName.ShortcutsEnabled = true;
            this.txtBookName.Size = new System.Drawing.Size(143, 22);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.UseSelectable = true;
            this.txtBookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelbookID
            // 
            this.labelbookID.AutoScroll = true;
            this.labelbookID.AutoScrollMinSize = new System.Drawing.Size(60, 32);
            this.labelbookID.AutoSize = false;
            this.labelbookID.BackColor = System.Drawing.SystemColors.Window;
            this.labelbookID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbookID.Location = new System.Drawing.Point(26, 19);
            this.labelbookID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelbookID.Name = "labelbookID";
            this.labelbookID.Size = new System.Drawing.Size(117, 28);
            this.labelbookID.TabIndex = 3;
            this.labelbookID.Text = "bookID";
            this.labelbookID.Click += new System.EventHandler(this.htmlLabel1_Click);
            // 
            // txtBookID
            // 
            // 
            // 
            // 
            this.txtBookID.CustomButton.Image = null;
            this.txtBookID.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtBookID.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookID.CustomButton.Name = "";
            this.txtBookID.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txtBookID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBookID.CustomButton.TabIndex = 1;
            this.txtBookID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBookID.CustomButton.UseSelectable = true;
            this.txtBookID.CustomButton.Visible = false;
            this.txtBookID.Lines = new string[0];
            this.txtBookID.Location = new System.Drawing.Point(163, 25);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBookID.MaxLength = 32767;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PasswordChar = '\0';
            this.txtBookID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBookID.SelectedText = "";
            this.txtBookID.SelectionLength = 0;
            this.txtBookID.SelectionStart = 0;
            this.txtBookID.ShortcutsEnabled = true;
            this.txtBookID.Size = new System.Drawing.Size(143, 22);
            this.txtBookID.TabIndex = 2;
            this.txtBookID.UseSelectable = true;
            this.txtBookID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBookID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBookID.Click += new System.EventHandler(this.txtBookID_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdd.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAdd.Location = new System.Drawing.Point(359, 115);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDelete.Location = new System.Drawing.Point(359, 202);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEdit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEdit.Location = new System.Drawing.Point(359, 156);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 34);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBrowse.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBrowse.Location = new System.Drawing.Point(359, 72);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(70, 32);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.Location = new System.Drawing.Point(359, 242);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PDFreader
            // 
            this.PDFreader.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PDFreader.Enabled = true;
            this.PDFreader.Location = new System.Drawing.Point(55, 322);
            this.PDFreader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PDFreader.Name = "PDFreader";
            this.PDFreader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFreader.OcxState")));
            this.PDFreader.Size = new System.Drawing.Size(1230, 567);
            this.PDFreader.TabIndex = 8;
            this.PDFreader.OnError += new System.EventHandler(this.axAcroPDF1_OnError);
            // 
            // FilesMetroGrid
            // 
            this.FilesMetroGrid.AllowUserToResizeRows = false;
            this.FilesMetroGrid.AutoGenerateColumns = false;
            this.FilesMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FilesMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilesMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FilesMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FilesMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FilesMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contentDataGridViewImageColumn,
            this.file_name,
            this.load,
            this.delete});
            this.FilesMetroGrid.DataSource = this.pdfLibraryBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FilesMetroGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.FilesMetroGrid.EnableHeadersVisualStyles = false;
            this.FilesMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FilesMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FilesMetroGrid.Location = new System.Drawing.Point(1005, 66);
            this.FilesMetroGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilesMetroGrid.Name = "FilesMetroGrid";
            this.FilesMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FilesMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.FilesMetroGrid.RowHeadersWidth = 62;
            this.FilesMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FilesMetroGrid.RowTemplate.Height = 28;
            this.FilesMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FilesMetroGrid.Size = new System.Drawing.Size(306, 218);
            this.FilesMetroGrid.TabIndex = 9;
            this.FilesMetroGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid2_CellContentClick_1);
            this.FilesMetroGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.metroGrid_DataError);
            // 
            // file_name
            // 
            this.file_name.DataPropertyName = "file_name";
            this.file_name.HeaderText = "Path";
            this.file_name.MinimumWidth = 6;
            this.file_name.Name = "file_name";
            this.file_name.Width = 125;
            // 
            // load
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Load";
            this.load.DefaultCellStyle = dataGridViewCellStyle2;
            this.load.HeaderText = "load";
            this.load.MinimumWidth = 15;
            this.load.Name = "load";
            this.load.Text = "load";
            this.load.ToolTipText = "load";
            this.load.UseColumnTextForButtonValue = true;
            this.load.Width = 44;
            // 
            // delete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "delete";
            this.delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.delete.HeaderText = "delete";
            this.delete.MinimumWidth = 15;
            this.delete.Name = "delete";
            this.delete.Width = 56;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 150;
            // 
            // BooksMetroGrid
            // 
            this.BooksMetroGrid.AllowUserToResizeRows = false;
            this.BooksMetroGrid.AutoGenerateColumns = false;
            this.BooksMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BooksMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BooksMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BooksMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.BooksMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.genreDataGridViewTextBoxColumn});
            this.BooksMetroGrid.DataSource = this.bookBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BooksMetroGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.BooksMetroGrid.EnableHeadersVisualStyles = false;
            this.BooksMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BooksMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BooksMetroGrid.Location = new System.Drawing.Point(488, 66);
            this.BooksMetroGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BooksMetroGrid.Name = "BooksMetroGrid";
            this.BooksMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.BooksMetroGrid.RowHeadersWidth = 62;
            this.BooksMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BooksMetroGrid.RowTemplate.Height = 28;
            this.BooksMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksMetroGrid.Size = new System.Drawing.Size(513, 218);
            this.BooksMetroGrid.TabIndex = 10;
            this.BooksMetroGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.metroGrid_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "book_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "book_author";
            this.dataGridViewTextBoxColumn2.HeaderText = "Author";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Books.Core.Book);
            // 
            // contentDataGridViewImageColumn
            // 
            this.contentDataGridViewImageColumn.DataPropertyName = "content";
            this.contentDataGridViewImageColumn.HeaderText = "content";
            this.contentDataGridViewImageColumn.MinimumWidth = 8;
            this.contentDataGridViewImageColumn.Name = "contentDataGridViewImageColumn";
            this.contentDataGridViewImageColumn.Visible = false;
            this.contentDataGridViewImageColumn.Width = 66;
            // 
            // pdfLibraryBindingSource
            // 
            this.pdfLibraryBindingSource.DataSource = typeof(Books.Core.PdfLibrary);
            this.pdfLibraryBindingSource.CurrentChanged += new System.EventHandler(this.pdfLibraryBindingSource_CurrentChanged);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 904);
            this.Controls.Add(this.BooksMetroGrid);
            this.Controls.Add(this.FilesMetroGrid);
            this.Controls.Add(this.PDFreader);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ControlContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Library";
            this.Padding = new System.Windows.Forms.Padding(14, 60, 14, 13);
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PDFreader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfLibraryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel ControlContainer;
        private MetroFramework.Drawing.Html.HtmlLabel Author;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Controls.MetroTextBox txtBookAuthor;
        private MetroFramework.Controls.MetroTextBox txtBookName;
        private MetroFramework.Drawing.Html.HtmlLabel labelbookID;
        private MetroFramework.Controls.MetroTextBox txtBookID;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroButton btnSave;
        private AxAcroPDFLib.AxAcroPDF PDFreader;
        private System.Windows.Forms.BindingSource pdfLibraryBindingSource;
        private MetroFramework.Controls.MetroGrid FilesMetroGrid;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private MetroFramework.Drawing.Html.HtmlLabel GenreLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroGrid BooksMetroGrid;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn contentDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_name;
        private System.Windows.Forms.DataGridViewButtonColumn load;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}

