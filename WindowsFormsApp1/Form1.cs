using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_Main : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;
        private Point lastFormPos;
        DataTable dt = new DataTable();
        List<Sheet_Model> listModel = new List<Sheet_Model>;
        
        private void KhoiTaoDataTable()
        {
            dt.Columns.Add("Time", typeof(DateTime));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Priority", typeof(bool));
            dt.Columns.Add("Task", typeof(string));
            dt.Columns.Add("Done", typeof(bool));
            dt.DefaultView.Sort = "Time ASC";
        }
        public form_Main()
        {
            InitializeComponent();
            this.pnlWindowbtn.MouseDown += pnlWindowbtn_MouseDown;
            this.pnlWindowbtn.MouseMove += pnlWindowbtn_MouseMove;  
            this.pnlWindowbtn.MouseUp += pnlWindowbtn_MouseUp;
        }



        #region CaiDatGiaoDien
        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblMaximum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            lblMaximum.Visible = false;
            lblUnmaximum.Visible = true;
        }

        private void lblMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblUnmaximum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            lblMaximum.Visible = true;
            lblUnmaximum.Visible = false;
        }

        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void form_Main_Load(object sender, EventArgs e)
        {
            KhoiTaoDataTable();
            dgvTable.DataSource = dt;
            timer1.Start();
        }

        private void pnlWindowbtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPos = Cursor.Position;
                lastFormPos = this.Location;
            }
        }

        private void pnlWindowbtn_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging== true)
            {
                int deltaX = Cursor.Position.X - lastCursorPos.X;
                int deltaY = Cursor.Position.Y - lastCursorPos.Y;

                this.Location = new Point(lastFormPos.X + deltaX,lastFormPos.Y + deltaY);
            }
        }

        private void pnlWindowbtn_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging= false;
        }
    }
}
