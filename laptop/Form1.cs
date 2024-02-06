using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace laptop
{
    public partial class D_V_Launcher : Form
    {
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public bool checkstartup;
        public D_V_Launcher()
        {
            InitializeComponent();
            this.TopMost = true;
            this.button6.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button5.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button1.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button2.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button3.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button7.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button8.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button9.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button10.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button11.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button12.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button6.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button1.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button2.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button3.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button7.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button8.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button9.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button10.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button11.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button12.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            timer2.Enabled = true;
            if (rkApp.GetValue("D_V_launcher") == null)
            {
                checkstartup = false;
                this.button8.BackColor = System.Drawing.Color.Maroon;
            }
            else
            {
                checkstartup = true;
                this.button8.BackColor = System.Drawing.Color.Green;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = .50;
            this.Location = new Point((Screen.FromControl(this).Bounds.Width/2)-(ClientSize.Width/2), 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\name\AppData\Local\Torch\Application\torch.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
            
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = true;
            timer3.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.FromControl(this).Bounds.Width / 2) - (ClientSize.Width / 2), (Screen.FromControl(this).Bounds.Height) - (Screen.FromControl(this).Bounds.Height + 55));
     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.FromControl(this).Bounds.Width / 2) - (ClientSize.Width / 2), 0);
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Adobe\Adobe Photoshop CC 2014\Photoshop.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office15\WINWORD.EXE");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            { this.TopMost = false; }
            else if(this.TopMost == false)
            { this.TopMost = true; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!checkstartup)
            {
                    rkApp.SetValue("D_V_launcher", Application.ExecutablePath.ToString());
                    this.button8.BackColor = System.Drawing.Color.Green;
                    checkstartup = true;
            }
            else if(checkstartup)
            {
                rkApp.DeleteValue("D_V_launcher", false);
                this.button8.BackColor = Color.Maroon;
                checkstartup = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\name\Desktop\past papers.exe");
        }

        private void button10_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(@"C:\Users\name\Desktop\Mail");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\name\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\System Tools\Control Panel");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\VirtualDJ\virtualdj8.exe");
        }
    }
}
