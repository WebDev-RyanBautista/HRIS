namespace HRIS_Biometrics
{
    partial class CaptureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureForm));
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StatusLine = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Prompt = new System.Windows.Forms.Label();
            this.PromptLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Employee_Info = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeOut = new System.Windows.Forms.Label();
            this.Emp_Name_lbl = new System.Windows.Forms.Label();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.Department_lbl = new System.Windows.Forms.Label();
            this.Position_lbl = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Deepartment = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.comboBoxFullName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeIn = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.Employee_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 672F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1601, 633);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.StatusLine, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Picture, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(634, 627);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // StatusLine
            // 
            this.StatusLine.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.StatusLine.BackColor = System.Drawing.Color.White;
            this.StatusLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLine.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatusLine.Location = new System.Drawing.Point(10, 447);
            this.StatusLine.Margin = new System.Windows.Forms.Padding(9);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Padding = new System.Windows.Forms.Padding(20);
            this.StatusLine.Size = new System.Drawing.Size(614, 65);
            this.StatusLine.TabIndex = 6;
            this.StatusLine.Text = "[Status line]";
            this.StatusLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.Window;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.Location = new System.Drawing.Point(51, 21);
            this.Picture.Margin = new System.Windows.Forms.Padding(50, 20, 50, 10);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(532, 406);
            this.Picture.TabIndex = 3;
            this.Picture.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.Prompt, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.PromptLabel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 525);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(626, 98);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.BackColor = System.Drawing.Color.White;
            this.Prompt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prompt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prompt.Location = new System.Drawing.Point(196, 9);
            this.Prompt.Margin = new System.Windows.Forms.Padding(9);
            this.Prompt.Name = "Prompt";
            this.Prompt.Padding = new System.Windows.Forms.Padding(20);
            this.Prompt.Size = new System.Drawing.Size(421, 80);
            this.Prompt.TabIndex = 3;
            this.Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PromptLabel
            // 
            this.PromptLabel.AutoSize = true;
            this.PromptLabel.BackColor = System.Drawing.Color.White;
            this.PromptLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PromptLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromptLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PromptLabel.Location = new System.Drawing.Point(9, 9);
            this.PromptLabel.Margin = new System.Windows.Forms.Padding(9);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Padding = new System.Windows.Forms.Padding(20);
            this.PromptLabel.Size = new System.Drawing.Size(169, 80);
            this.PromptLabel.TabIndex = 2;
            this.PromptLabel.Text = "Prompt:";
            this.PromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Employee_Info, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(643, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(955, 627);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Controls.Add(this.StatusText, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.StatusLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.CloseButton, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 522);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(955, 105);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // StatusText
            // 
            this.StatusText.BackColor = System.Drawing.Color.White;
            this.StatusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StatusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StatusText.Location = new System.Drawing.Point(200, 0);
            this.StatusText.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatusText.Size = new System.Drawing.Size(602, 105);
            this.StatusText.TabIndex = 17;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.White;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatusLabel.Location = new System.Drawing.Point(9, 0);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(20);
            this.StatusLabel.Size = new System.Drawing.Size(178, 105);
            this.StatusLabel.TabIndex = 16;
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(837, 33);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(91, 39);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Employee_Info
            // 
            this.Employee_Info.AutoSize = true;
            this.Employee_Info.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Employee_Info.BackColor = System.Drawing.Color.White;
            this.Employee_Info.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Employee_Info.ColumnCount = 2;
            this.Employee_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Employee_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Employee_Info.Controls.Add(this.label2, 0, 5);
            this.Employee_Info.Controls.Add(this.TimeOut, 0, 5);
            this.Employee_Info.Controls.Add(this.Emp_Name_lbl, 0, 0);
            this.Employee_Info.Controls.Add(this.Email_lbl, 0, 1);
            this.Employee_Info.Controls.Add(this.Department_lbl, 0, 2);
            this.Employee_Info.Controls.Add(this.Position_lbl, 0, 3);
            this.Employee_Info.Controls.Add(this.Email, 1, 1);
            this.Employee_Info.Controls.Add(this.Deepartment, 1, 2);
            this.Employee_Info.Controls.Add(this.Position, 1, 3);
            this.Employee_Info.Controls.Add(this.comboBoxFullName, 1, 0);
            this.Employee_Info.Controls.Add(this.label3, 0, 4);
            this.Employee_Info.Controls.Add(this.TimeIn, 1, 4);
            this.Employee_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Employee_Info.Location = new System.Drawing.Point(9, 0);
            this.Employee_Info.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
            this.Employee_Info.Name = "Employee_Info";
            this.Employee_Info.Padding = new System.Windows.Forms.Padding(20);
            this.Employee_Info.RowCount = 6;
            this.Employee_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Employee_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Employee_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Employee_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Employee_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Employee_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Employee_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Employee_Info.Size = new System.Drawing.Size(937, 513);
            this.Employee_Info.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(24, 411);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(172, 81);
            this.label2.TabIndex = 13;
            this.label2.Text = "Time Out";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeOut
            // 
            this.TimeOut.AutoSize = true;
            this.TimeOut.BackColor = System.Drawing.Color.White;
            this.TimeOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TimeOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeOut.Location = new System.Drawing.Point(203, 411);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.TimeOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeOut.Size = new System.Drawing.Size(710, 81);
            this.TimeOut.TabIndex = 12;
            this.TimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Emp_Name_lbl
            // 
            this.Emp_Name_lbl.AutoSize = true;
            this.Emp_Name_lbl.BackColor = System.Drawing.Color.White;
            this.Emp_Name_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Emp_Name_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Emp_Name_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Name_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Emp_Name_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Emp_Name_lbl.Location = new System.Drawing.Point(24, 21);
            this.Emp_Name_lbl.Name = "Emp_Name_lbl";
            this.Emp_Name_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Emp_Name_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Emp_Name_lbl.Size = new System.Drawing.Size(172, 77);
            this.Emp_Name_lbl.TabIndex = 1;
            this.Emp_Name_lbl.Text = "Employee Name";
            this.Emp_Name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Emp_Name_lbl.UseMnemonic = false;
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.BackColor = System.Drawing.Color.White;
            this.Email_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Email_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Email_lbl.Location = new System.Drawing.Point(24, 99);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Email_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Email_lbl.Size = new System.Drawing.Size(172, 77);
            this.Email_lbl.TabIndex = 2;
            this.Email_lbl.Text = "Email";
            this.Email_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Department_lbl
            // 
            this.Department_lbl.AutoSize = true;
            this.Department_lbl.BackColor = System.Drawing.Color.White;
            this.Department_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Department_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Department_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Department_lbl.Location = new System.Drawing.Point(24, 177);
            this.Department_lbl.Name = "Department_lbl";
            this.Department_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Department_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Department_lbl.Size = new System.Drawing.Size(172, 77);
            this.Department_lbl.TabIndex = 6;
            this.Department_lbl.Text = "Department";
            this.Department_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Position_lbl
            // 
            this.Position_lbl.AutoSize = true;
            this.Position_lbl.BackColor = System.Drawing.Color.White;
            this.Position_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Position_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Position_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Position_lbl.Location = new System.Drawing.Point(24, 255);
            this.Position_lbl.Name = "Position_lbl";
            this.Position_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Position_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Position_lbl.Size = new System.Drawing.Size(172, 77);
            this.Position_lbl.TabIndex = 7;
            this.Position_lbl.Text = "Position";
            this.Position_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.White;
            this.Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Email.Location = new System.Drawing.Point(203, 99);
            this.Email.Name = "Email";
            this.Email.Padding = new System.Windows.Forms.Padding(20);
            this.Email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Email.Size = new System.Drawing.Size(710, 77);
            this.Email.TabIndex = 9;
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Deepartment
            // 
            this.Deepartment.AutoSize = true;
            this.Deepartment.BackColor = System.Drawing.Color.White;
            this.Deepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Deepartment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deepartment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Deepartment.Location = new System.Drawing.Point(203, 177);
            this.Deepartment.Name = "Deepartment";
            this.Deepartment.Padding = new System.Windows.Forms.Padding(20);
            this.Deepartment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Deepartment.Size = new System.Drawing.Size(710, 77);
            this.Deepartment.TabIndex = 10;
            this.Deepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.BackColor = System.Drawing.Color.White;
            this.Position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Position.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Position.Location = new System.Drawing.Point(203, 255);
            this.Position.Name = "Position";
            this.Position.Padding = new System.Windows.Forms.Padding(20);
            this.Position.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Position.Size = new System.Drawing.Size(710, 77);
            this.Position.TabIndex = 11;
            this.Position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxFullName
            // 
            this.comboBoxFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxFullName.BackColor = System.Drawing.Color.White;
            this.comboBoxFullName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxFullName.FormattingEnabled = true;
            this.comboBoxFullName.Location = new System.Drawing.Point(271, 45);
            this.comboBoxFullName.Name = "comboBoxFullName";
            this.comboBoxFullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxFullName.Size = new System.Drawing.Size(574, 28);
            this.comboBoxFullName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 333);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(172, 77);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time In";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeIn
            // 
            this.TimeIn.AutoSize = true;
            this.TimeIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIn.Location = new System.Drawing.Point(203, 333);
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.Size = new System.Drawing.Size(710, 77);
            this.TimeIn.TabIndex = 15;
            this.TimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1641, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 720);
            this.Name = "CaptureForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Capture Enrollment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaptureForm_FormClosed);
            this.Load += new System.EventHandler(this.CaptureForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.Employee_Info.ResumeLayout(false);
            this.Employee_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.PictureBox Picture;
        public System.Windows.Forms.Label StatusLine;
        public System.Windows.Forms.Label PromptLabel;
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel Employee_Info;
        private System.Windows.Forms.Label Emp_Name_lbl;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.Label Position_lbl;
        public System.Windows.Forms.Label Email;
        public System.Windows.Forms.Label Deepartment;
        public System.Windows.Forms.Label Position;
        public System.Windows.Forms.ComboBox comboBoxFullName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label Department_lbl;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label TimeOut;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label TimeIn;
    }
}