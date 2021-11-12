namespace FileList
{
    public partial class FIleList : Form
    {
        public FIleList()
        {
            InitializeComponent();
        }


        List<string> list = new List<string>();
        private void button1_Click_1(object sender, EventArgs e)
        {


            DirectoryInfo d = new DirectoryInfo(textBox2.Text); // C:\Users\Nikola\Downloads\dokumenti

            FileInfo[] Files = d.GetFiles("*" + textBox3.Text); // .pdf

            if (textBox3.Text == "folder")
            {
                list = Directory.GetDirectories(textBox2.Text).ToList();
            }


            foreach (var item in Files)
            {
                list.Add(item.ToString());
            }
            foreach (var item in list)
            {
                var len = 0;
                if (textBox3.Text != "folder")
                {
                    len = textBox2.TextLength + 1;
                }
                else
                {
                    len = textBox2.TextLength;
                }
                var newitem = item.Remove(0, len);
                textBox1.Text += newitem + "\r\n";
            }
            list.Clear();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            list.Clear();
            textBox1.Clear();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FIleList_Load(object sender, EventArgs e)
        {

        }
    }
}