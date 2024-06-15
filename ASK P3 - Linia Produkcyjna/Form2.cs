using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ASK_P3___Linia_Produkcyjna
{
    public partial class Form2 : Form
    {

        private int usage = 45, temp = 60, speed = 600;

        Form form1;
        private Form3 form3;

        private Timer update_values_timer = new Timer();
        private Timer prod_line_button_timer = new Timer();
        private Timer add_fan_button_timer = new Timer();
        private Timer speed_fan_button_timer = new Timer();
        private Timer sleep_form3_timer = new Timer();

        private Random rnd = new Random();
        public Form2(Form calling_form)
        {
            InitializeComponent();

            form1 = calling_form;

            sleep_form3_timer.Interval = 8000;
            sleep_form3_timer.Tick += new EventHandler(Sleep_timer_Tick);
            sleep_form3_timer.Start();

            update_values_timer.Interval = 1250;
            update_values_timer.Tick += new EventHandler(Update_Values);
            update_values_timer.Start();

            prod_line_button_timer.Interval = add_fan_button_timer.Interval = speed_fan_button_timer.Interval = 5000;
            prod_line_button_timer.Tick += new EventHandler(Block_Prod);
            add_fan_button_timer.Tick += new EventHandler(Block_Add);
            speed_fan_button_timer.Tick += new EventHandler(Block_Speed);

        }

        private void Sleep_timer_Tick(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new Form3(this);
                form3.Show();
                form3.TopMost = true;
                form3.FormClosed += Form3_FormClosed;
            }
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form3 = null;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (sleep_form3_timer != null)
            {
                sleep_form3_timer.Stop();
                sleep_form3_timer.Dispose();
            }
            form1.Show();
        }

        public void CloseAll()
        {
            sleep_form3_timer.Stop();
            if (form3 != null && !form3.IsDisposed)
            {
                form3.Close();
            }
            this.Close();
            form1.Show();
        }

        private void Update_Values(object sender, EventArgs e)
        {
            int random = rnd.Next(-20, 30);
            usage += random;
            if (usage < 30) usage = 30;
            if (usage <= 90) Usage_value_display.ForeColor = Color.Lime;
            else Usage_value_display.ForeColor = Color.Red;

            random = rnd.Next(-20, 30);
            temp += random;
            if (temp < 40) temp = 40;
            if (temp <= 100) Temp_value_display.ForeColor = Color.Lime;
            else Temp_value_display.ForeColor = Color.Red;

            random = rnd.Next(-300, 300);
            speed += random;
            if (speed < 50) speed = 50;
            if (speed <= 900 && speed >= 300) Speed_value_display.ForeColor = Color.Lime;
            else Speed_value_display.ForeColor = Color.Red;

            Usage_value_display.Text = usage.ToString();
            Temp_value_display.Text = temp.ToString();
            Speed_value_display.Text = speed.ToString();
        }

        private void Block_Prod(object sender, EventArgs e)
        {
            Prod_line_button.Enabled = true;
            prod_line_button_timer.Stop();
        }

        private void Block_Add(object sender, EventArgs e)
        {
            Add_fan_button.Enabled = true;
            add_fan_button_timer.Stop();
        }

        private void Block_Speed(object sender, EventArgs e)
        {
            Speed_fan_button.Enabled = true;
            speed_fan_button_timer.Stop();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Prod_line_Click(object sender, EventArgs e)
        {
            int r1 = rnd.Next(30, 70);
            usage = r1;
            Usage_value_display.ForeColor = Color.Lime;
            Usage_value_display.Text = usage.ToString();
            Prod_line_button.Enabled = false;
            prod_line_button_timer.Start();
        }

        private void Add_fan_Click(object sender, EventArgs e)
        {
            int r2 = rnd.Next(40, 60);
            temp = r2;
            Temp_value_display.ForeColor = Color.Lime;
            Temp_value_display.Text = temp.ToString();
            Add_fan_button.Enabled = false;
            add_fan_button_timer.Start();
        }

        private void Speed_fan_Click(object sender, EventArgs e)
        {
            int r3 = rnd.Next(400, 700);
            speed = r3;
            Speed_value_display.ForeColor = Color.Lime;
            Speed_value_display.Text = speed.ToString();
            Speed_fan_button.Enabled = false;
            speed_fan_button_timer.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
