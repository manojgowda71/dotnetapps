using emplib;

namespace empforms
{
    public partial class Form1 : Form
    {

        employee kpmgemp = new employee();
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button_click2;
            button1.Click += Button_click3;
            kpmgemp.join += Srikar_join;
            kpmgemp.join += rana_join;
            kpmgemp.join += sneha_join;
            kpmgemp.join += sichana_join;
            kpmgemp.resign += amelin_join;
            kpmgemp.resign += harshith_join;
        }

        private void harshith_join(object? sender, EventArgs e)
        {
            MessageBox.Show("harshith resigned");
        }

        private void amelin_join(object? sender, EventArgs e)
        {
            MessageBox.Show("amelin resigned");
        }

        private void sichana_join(object? sender, EventArgs e)
        {
            MessageBox.Show("sichana joined");
        }

        private void sneha_join(object? sender, EventArgs e)
        {
            MessageBox.Show("sneha joined");
        }

        private void rana_join(object? sender, EventArgs e)
        {
            MessageBox.Show("rohith joined");
        }

        private void Srikar_join(object? sender, EventArgs e)
        {
            MessageBox.Show("srikar joined kpmg successfully");
        }

        private void Button_click3(object? sender, EventArgs e)
        {
            MessageBox.Show("you clicked the button3");
        }

        private void Button_click2(object? sender, EventArgs e)
        {
            MessageBox.Show("you clicked the button2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked the button");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Srikar_join(null, null);
            //rana_join(null, null);
            //sneha_join(null, null);
            kpmgemp.triggerjoinevents();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kpmgemp.triggerjoinevents1();
        }
    }
}