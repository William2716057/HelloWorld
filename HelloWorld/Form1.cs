namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
