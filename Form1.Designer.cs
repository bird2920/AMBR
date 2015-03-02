namespace WindowsFormsApplication1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.refreshButton = new System.Windows.Forms.Button();
            this.doneClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.incomeTab = new System.Windows.Forms.TabPage();
            this.incomeGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.currBalTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.primaryAccount = new System.Windows.Forms.TextBox();
            this.balanceGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.expenseGrid = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.expenseTotalL = new System.Windows.Forms.Label();
            this.expenseTotalV = new System.Windows.Forms.Label();
            this.afterExpTotalV = new System.Windows.Forms.Label();
            this.currBalanceV = new System.Windows.Forms.Label();
            this.incomeAftTaxV = new System.Windows.Forms.Label();
            this.incomeTotal = new System.Windows.Forms.Label();
            this.afterExpTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.incomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeGrid)).BeginInit();
            this.currBalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.refreshButton.FlatAppearance.BorderSize = 2;
            this.refreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshButton.Location = new System.Drawing.Point(801, 632);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(131, 29);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh Records";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButtonClick);
            // 
            // doneClose
            // 
            this.doneClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.doneClose.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.doneClose.FlatAppearance.BorderSize = 2;
            this.doneClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.doneClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneClose.ForeColor = System.Drawing.SystemColors.Control;
            this.doneClose.Location = new System.Drawing.Point(938, 632);
            this.doneClose.Name = "doneClose";
            this.doneClose.Size = new System.Drawing.Size(131, 29);
            this.doneClose.TabIndex = 1;
            this.doneClose.Text = "Done";
            this.toolTip1.SetToolTip(this.doneClose, "Update Data then Close Window");
            this.doneClose.UseVisualStyleBackColor = false;
            this.doneClose.Click += new System.EventHandler(this.doneCloseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.incomeTab);
            this.tabControl1.Controls.Add(this.currBalTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(506, 16);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 424);
            this.tabControl1.TabIndex = 14;
            // 
            // incomeTab
            // 
            this.incomeTab.BackColor = System.Drawing.SystemColors.ControlDark;
            this.incomeTab.Controls.Add(this.incomeGrid);
            this.incomeTab.Controls.Add(this.button1);
            this.incomeTab.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeTab.Location = new System.Drawing.Point(4, 23);
            this.incomeTab.Name = "incomeTab";
            this.incomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.incomeTab.Size = new System.Drawing.Size(555, 397);
            this.incomeTab.TabIndex = 1;
            this.incomeTab.Text = "Income";
            // 
            // incomeGrid
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.incomeGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.incomeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incomeGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.incomeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.incomeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.incomeGrid.Location = new System.Drawing.Point(3, 3);
            this.incomeGrid.Name = "incomeGrid";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.incomeGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 10F);
            this.incomeGrid.Size = new System.Drawing.Size(549, 353);
            this.incomeGrid.TabIndex = 14;
            this.incomeGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCellLeave);
            this.incomeGrid.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.deleteRowUpdate);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(410, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate Tax";
            this.toolTip1.SetToolTip(this.button1, "Commit the row, get the id, calculate the taxed income amount.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.calculateTax);
            // 
            // currBalTab
            // 
            this.currBalTab.BackColor = System.Drawing.SystemColors.ControlDark;
            this.currBalTab.Controls.Add(this.label2);
            this.currBalTab.Controls.Add(this.primaryAccount);
            this.currBalTab.Controls.Add(this.balanceGrid);
            this.currBalTab.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currBalTab.Location = new System.Drawing.Point(4, 23);
            this.currBalTab.Name = "currBalTab";
            this.currBalTab.Padding = new System.Windows.Forms.Padding(3);
            this.currBalTab.Size = new System.Drawing.Size(555, 397);
            this.currBalTab.TabIndex = 0;
            this.currBalTab.Text = "Current Account Balances";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Primary Account:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // primaryAccount
            // 
            this.primaryAccount.Location = new System.Drawing.Point(449, 369);
            this.primaryAccount.Name = "primaryAccount";
            this.primaryAccount.Size = new System.Drawing.Size(100, 22);
            this.primaryAccount.TabIndex = 16;
            this.toolTip1.SetToolTip(this.primaryAccount, "If account ID entered the After Expense Total\r\nwill only reflect the total from t" +
        "he account specified.\r\nOtherwise it will calculate the total of all current acco" +
        "unt balances.");
            // 
            // balanceGrid
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.balanceGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.balanceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.balanceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.balanceGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.balanceGrid.Location = new System.Drawing.Point(3, 3);
            this.balanceGrid.Name = "balanceGrid";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.balanceGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 10F);
            this.balanceGrid.Size = new System.Drawing.Size(549, 353);
            this.balanceGrid.TabIndex = 15;
            this.balanceGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCellLeave);
            this.balanceGrid.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.deleteRowUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Expenses";
            // 
            // expenseGrid
            // 
            this.expenseGrid.AllowDrop = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.expenseGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.expenseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expenseGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.expenseGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.expenseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.expenseGrid.Location = new System.Drawing.Point(12, 38);
            this.expenseGrid.Name = "expenseGrid";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseGrid.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.expenseGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 10F);
            this.expenseGrid.Size = new System.Drawing.Size(477, 588);
            this.expenseGrid.TabIndex = 15;
            this.expenseGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCellLeave);
            this.expenseGrid.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCellLeave);
            this.expenseGrid.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.deleteRowUpdate);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.expenseTotalL);
            this.panel1.Controls.Add(this.expenseTotalV);
            this.panel1.Controls.Add(this.afterExpTotalV);
            this.panel1.Controls.Add(this.currBalanceV);
            this.panel1.Controls.Add(this.incomeAftTaxV);
            this.panel1.Controls.Add(this.incomeTotal);
            this.panel1.Controls.Add(this.afterExpTotal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(506, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 180);
            this.panel1.TabIndex = 6;
            // 
            // expenseTotalL
            // 
            this.expenseTotalL.AutoEllipsis = true;
            this.expenseTotalL.AutoSize = true;
            this.expenseTotalL.Cursor = System.Windows.Forms.Cursors.Default;
            this.expenseTotalL.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseTotalL.ForeColor = System.Drawing.Color.Moccasin;
            this.expenseTotalL.Location = new System.Drawing.Point(44, 44);
            this.expenseTotalL.Name = "expenseTotalL";
            this.expenseTotalL.Size = new System.Drawing.Size(99, 17);
            this.expenseTotalL.TabIndex = 6;
            this.expenseTotalL.Text = "Expense Total:";
            // 
            // expenseTotalV
            // 
            this.expenseTotalV.AutoEllipsis = true;
            this.expenseTotalV.AutoSize = true;
            this.expenseTotalV.Cursor = System.Windows.Forms.Cursors.Default;
            this.expenseTotalV.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseTotalV.ForeColor = System.Drawing.SystemColors.Control;
            this.expenseTotalV.Location = new System.Drawing.Point(140, 44);
            this.expenseTotalV.Name = "expenseTotalV";
            this.expenseTotalV.Size = new System.Drawing.Size(16, 17);
            this.expenseTotalV.TabIndex = 8;
            this.expenseTotalV.Text = "$";
            // 
            // afterExpTotalV
            // 
            this.afterExpTotalV.AutoEllipsis = true;
            this.afterExpTotalV.AutoSize = true;
            this.afterExpTotalV.Cursor = System.Windows.Forms.Cursors.Default;
            this.afterExpTotalV.Font = new System.Drawing.Font("Tahoma", 30F);
            this.afterExpTotalV.ForeColor = System.Drawing.SystemColors.Control;
            this.afterExpTotalV.Location = new System.Drawing.Point(312, 61);
            this.afterExpTotalV.Name = "afterExpTotalV";
            this.afterExpTotalV.Size = new System.Drawing.Size(42, 48);
            this.afterExpTotalV.TabIndex = 7;
            this.afterExpTotalV.Text = "$";
            // 
            // currBalanceV
            // 
            this.currBalanceV.AutoEllipsis = true;
            this.currBalanceV.AutoSize = true;
            this.currBalanceV.Cursor = System.Windows.Forms.Cursors.Default;
            this.currBalanceV.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currBalanceV.ForeColor = System.Drawing.SystemColors.Control;
            this.currBalanceV.Location = new System.Drawing.Point(140, 24);
            this.currBalanceV.Name = "currBalanceV";
            this.currBalanceV.Size = new System.Drawing.Size(16, 17);
            this.currBalanceV.TabIndex = 9;
            this.currBalanceV.Text = "$";
            // 
            // incomeAftTaxV
            // 
            this.incomeAftTaxV.AutoEllipsis = true;
            this.incomeAftTaxV.AutoSize = true;
            this.incomeAftTaxV.Cursor = System.Windows.Forms.Cursors.Default;
            this.incomeAftTaxV.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeAftTaxV.ForeColor = System.Drawing.SystemColors.Control;
            this.incomeAftTaxV.Location = new System.Drawing.Point(140, 88);
            this.incomeAftTaxV.Name = "incomeAftTaxV";
            this.incomeAftTaxV.Size = new System.Drawing.Size(16, 17);
            this.incomeAftTaxV.TabIndex = 9;
            this.incomeAftTaxV.Text = "$";
            // 
            // incomeTotal
            // 
            this.incomeTotal.AutoEllipsis = true;
            this.incomeTotal.AutoSize = true;
            this.incomeTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.incomeTotal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.incomeTotal.Location = new System.Drawing.Point(140, 66);
            this.incomeTotal.Name = "incomeTotal";
            this.incomeTotal.Size = new System.Drawing.Size(16, 17);
            this.incomeTotal.TabIndex = 9;
            this.incomeTotal.Text = "$";
            // 
            // afterExpTotal
            // 
            this.afterExpTotal.AutoEllipsis = true;
            this.afterExpTotal.AutoSize = true;
            this.afterExpTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.afterExpTotal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterExpTotal.ForeColor = System.Drawing.Color.SpringGreen;
            this.afterExpTotal.Location = new System.Drawing.Point(357, 41);
            this.afterExpTotal.Name = "afterExpTotal";
            this.afterExpTotal.Size = new System.Drawing.Size(132, 17);
            this.afterExpTotal.TabIndex = 5;
            this.afterExpTotal.Text = "After Expense Total:";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Turquoise;
            this.label7.Location = new System.Drawing.Point(23, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Current Accounts:";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Income After Tax:";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(50, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Income Total:";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(555, 397);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Logging";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1079, 666);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expenseGrid);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.doneClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMBR Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.incomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.incomeGrid)).EndInit();
            this.currBalTab.ResumeLayout(false);
            this.currBalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button doneClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label afterExpTotalV;
        private System.Windows.Forms.Label incomeTotal;
        private System.Windows.Forms.Label afterExpTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label incomeAftTaxV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label expenseTotalL;
        private System.Windows.Forms.Label expenseTotalV;
        private System.Windows.Forms.Label currBalanceV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage currBalTab;
        private System.Windows.Forms.DataGridView balanceGrid;
        private System.Windows.Forms.TabPage incomeTab;
        private System.Windows.Forms.DataGridView incomeGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView expenseGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox primaryAccount;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

