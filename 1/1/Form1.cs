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
        string[] song = new string[] { "稻香", "屋梅子醬", "在樹上唱歌", "溫柔", "好不容易" };
        string[] singer = new string[] { "周杰倫", "李榮浩", "郭靜", "五月天", "告五人" };
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