namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        string[] song = new string[] { "�_��", "�α��l��", "�b��W�ۺq", "�ŬX", "�n���e��" };
        string[] singer = new string[] { "�P�N��", "���a�E", "���R", "�����", "�i���H" };
        int[] no = new int[] { 1, 2, 3, 4, 5 };
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < no.Length; i++)
                textBox1.Text += $"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] son2 = new string[song.Length];
            song.CopyTo(song, 0);
            Array.Sort(song,no);
            Array.Sort(song2, singer);
            
            for (int i = 0; i < no.Length; i++)
                textBox1.Text += $"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
        }
    }
    }
}