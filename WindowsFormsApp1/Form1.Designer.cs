namespace WindowsFormsApp1
{
    partial class form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlWindowbtn = new System.Windows.Forms.Panel();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblUnmaximum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.pnl = new System.Windows.Forms.Panel();
            this.pnlEmpty1 = new System.Windows.Forms.Panel();
            this.rbtnPet = new System.Windows.Forms.RadioButton();
            this.rbtnSum = new System.Windows.Forms.RadioButton();
            this.rbtnCreate = new System.Windows.Forms.RadioButton();
            this.rbtnView = new System.Windows.Forms.RadioButton();
            this.ptbKuromi = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDate = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.pnlWindowbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.pnl.SuspendLayout();
            this.pnlEmpty1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKuromi)).BeginInit();
            this.pnlDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClose.Location = new System.Drawing.Point(1044, 0);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(21, 20);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pnlWindowbtn
            // 
            this.pnlWindowbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pnlWindowbtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlWindowbtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWindowbtn.Controls.Add(this.lblMinimum);
            this.pnlWindowbtn.Controls.Add(this.lblUnmaximum);
            this.pnlWindowbtn.Controls.Add(this.lblMaximum);
            this.pnlWindowbtn.Controls.Add(this.lblClose);
            this.pnlWindowbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindowbtn.Location = new System.Drawing.Point(0, 0);
            this.pnlWindowbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlWindowbtn.Name = "pnlWindowbtn";
            this.pnlWindowbtn.Size = new System.Drawing.Size(1067, 21);
            this.pnlWindowbtn.TabIndex = 5;
            this.pnlWindowbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlWindowbtn_MouseDown);
            this.pnlWindowbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlWindowbtn_MouseMove);
            this.pnlWindowbtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlWindowbtn_MouseUp);
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimum.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimum.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMinimum.Location = new System.Drawing.Point(979, 0);
            this.lblMinimum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(23, 20);
            this.lblMinimum.TabIndex = 10;
            this.lblMinimum.Text = "--";
            this.lblMinimum.Click += new System.EventHandler(this.lblMinimum_Click);
            // 
            // lblUnmaximum
            // 
            this.lblUnmaximum.AutoSize = true;
            this.lblUnmaximum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUnmaximum.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUnmaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnmaximum.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUnmaximum.Location = new System.Drawing.Point(1002, 0);
            this.lblUnmaximum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnmaximum.Name = "lblUnmaximum";
            this.lblUnmaximum.Size = new System.Drawing.Size(19, 20);
            this.lblUnmaximum.TabIndex = 9;
            this.lblUnmaximum.Text = "o";
            this.lblUnmaximum.Visible = false;
            this.lblUnmaximum.Click += new System.EventHandler(this.lblUnmaximum_Click);
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMaximum.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximum.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMaximum.Location = new System.Drawing.Point(1021, 0);
            this.lblMaximum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(23, 20);
            this.lblMaximum.TabIndex = 8;
            this.lblMaximum.Text = "O";
            this.lblMaximum.Click += new System.EventHandler(this.lblMaximum_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(900, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 422);
            this.panel2.TabIndex = 8;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(0, 132);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.Size = new System.Drawing.Size(900, 422);
            this.dgvTable.TabIndex = 9;
            // 
            // pnl
            // 
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.pnlDate);
            this.pnl.Controls.Add(this.rbtnView);
            this.pnl.Controls.Add(this.rbtnCreate);
            this.pnl.Controls.Add(this.rbtnSum);
            this.pnl.Controls.Add(this.rbtnPet);
            this.pnl.Controls.Add(this.pnlEmpty1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.ForeColor = System.Drawing.Color.Transparent;
            this.pnl.Location = new System.Drawing.Point(0, 21);
            this.pnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1067, 111);
            this.pnl.TabIndex = 7;
            // 
            // pnlEmpty1
            // 
            this.pnlEmpty1.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmpty1.Controls.Add(this.ptbKuromi);
            this.pnlEmpty1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEmpty1.Location = new System.Drawing.Point(899, 0);
            this.pnlEmpty1.Name = "pnlEmpty1";
            this.pnlEmpty1.Size = new System.Drawing.Size(166, 109);
            this.pnlEmpty1.TabIndex = 0;
            // 
            // rbtnPet
            // 
            this.rbtnPet.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnPet.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnPet.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPet.ForeColor = System.Drawing.Color.DeepPink;
            this.rbtnPet.Location = new System.Drawing.Point(780, 0);
            this.rbtnPet.Name = "rbtnPet";
            this.rbtnPet.Size = new System.Drawing.Size(119, 109);
            this.rbtnPet.TabIndex = 7;
            this.rbtnPet.Text = "PET";
            this.rbtnPet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnPet.UseVisualStyleBackColor = true;
            // 
            // rbtnSum
            // 
            this.rbtnSum.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnSum.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnSum.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSum.ForeColor = System.Drawing.Color.DeepPink;
            this.rbtnSum.Location = new System.Drawing.Point(610, 0);
            this.rbtnSum.Name = "rbtnSum";
            this.rbtnSum.Size = new System.Drawing.Size(170, 109);
            this.rbtnSum.TabIndex = 8;
            this.rbtnSum.Text = "SUMERIZE";
            this.rbtnSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnSum.UseVisualStyleBackColor = true;
            // 
            // rbtnCreate
            // 
            this.rbtnCreate.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnCreate.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCreate.ForeColor = System.Drawing.Color.DeepPink;
            this.rbtnCreate.Location = new System.Drawing.Point(467, 0);
            this.rbtnCreate.Name = "rbtnCreate";
            this.rbtnCreate.Size = new System.Drawing.Size(143, 109);
            this.rbtnCreate.TabIndex = 9;
            this.rbtnCreate.Text = "CREATE";
            this.rbtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnCreate.UseVisualStyleBackColor = true;
            // 
            // rbtnView
            // 
            this.rbtnView.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnView.Checked = true;
            this.rbtnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnView.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnView.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnView.ForeColor = System.Drawing.Color.DeepPink;
            this.rbtnView.Location = new System.Drawing.Point(303, 0);
            this.rbtnView.Name = "rbtnView";
            this.rbtnView.Size = new System.Drawing.Size(164, 109);
            this.rbtnView.TabIndex = 10;
            this.rbtnView.Text = "VIEW";
            this.rbtnView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnView.UseVisualStyleBackColor = true;
            // 
            // ptbKuromi
            // 
            this.ptbKuromi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbKuromi.Image = ((System.Drawing.Image)(resources.GetObject("ptbKuromi.Image")));
            this.ptbKuromi.Location = new System.Drawing.Point(0, 0);
            this.ptbKuromi.Name = "ptbKuromi";
            this.ptbKuromi.Size = new System.Drawing.Size(166, 109);
            this.ptbKuromi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbKuromi.TabIndex = 0;
            this.ptbKuromi.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlDate
            // 
            this.pnlDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlDate.Controls.Add(this.txtDate);
            this.pnlDate.Controls.Add(this.lblDate);
            this.pnlDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDate.Location = new System.Drawing.Point(0, 0);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(303, 109);
            this.pnlDate.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Purple;
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 23);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date :";
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDate.Location = new System.Drawing.Point(58, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(179, 22);
            this.txtDate.TabIndex = 14;
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.pnlWindowbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_Main";
            this.Text = "BUMBUMBENGBENG";
            this.Load += new System.EventHandler(this.form_Main_Load);
            this.pnlWindowbtn.ResumeLayout(false);
            this.pnlWindowbtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnlEmpty1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbKuromi)).EndInit();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel pnlWindowbtn;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblUnmaximum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel pnlEmpty1;
        private System.Windows.Forms.RadioButton rbtnCreate;
        private System.Windows.Forms.RadioButton rbtnSum;
        private System.Windows.Forms.RadioButton rbtnPet;
        private System.Windows.Forms.RadioButton rbtnView;
        private System.Windows.Forms.PictureBox ptbKuromi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
    }
}

