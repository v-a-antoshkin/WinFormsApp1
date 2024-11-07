namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            gr.FillRectangle(Brushes.White, 0, 0, 100, 100);


            Graphics graphics = CreateGraphics();
            graphics.FillEllipse(Brushes.Green, 20, 50, 100, 100);
        }
    }
}