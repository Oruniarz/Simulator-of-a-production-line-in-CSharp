using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASK_P3___Linia_Produkcyjna
{
    public partial class Form3 : Form
    {
        private Timer timeout_timer = new Timer();
        private Form2 form2;
        public Form3(Form2 calling_form2)
        {
            InitializeComponent();

            form2 = calling_form2;
            timeout_timer.Interval = 10000;
            timeout_timer.Tick += new EventHandler(Timeout_timer_Tick);
            timeout_timer.Start();
        }

        private void Timeout_timer_Tick(object sender, EventArgs e)
        {
            timeout_timer.Stop();
            if (form2 != null)
            {
                form2.CloseAll();
            }
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Potwierdzenie_Click(object sender, EventArgs e)
        {
            timeout_timer.Stop();
            this.Close();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (timeout_timer != null)
            {
                timeout_timer.Stop();
                timeout_timer.Dispose();
            }
        }
    }
}
