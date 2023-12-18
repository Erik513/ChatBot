using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ChatBot
{
    public partial class Form1 : Form
    {
        private bool isDragging;
        private Point lastLocation;
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_MAXIMIZE = 3;

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.Location.X - lastLocation.X;
                int deltaY = e.Location.Y - lastLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void dragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            if (this.Top <= Screen.PrimaryScreen.WorkingArea.Top)
            {
                ShowWindow(this.Handle, SW_MAXIMIZE);
            }
        }
        private void FensterSchließen(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowMaximize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                CenterToScreen();
            }
        }

        private void WindowMinimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            panelLeiste.MouseDown += dragPanel_MouseDown;
            panelLeiste.MouseMove += dragPanel_MouseMove;
            panelLeiste.MouseUp += dragPanel_MouseUp;
            txtQuestion.KeyPress += txtQuestion_KeyPress; ;
        }

        private void txtQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtAnswer.Text = "Antwort";
                //Antwort generieren
                e.Handled = true;
            }
        }
    }
}
