using System.Windows.Forms;

namespace Activity5App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String str;
        int max_val = 0, max_index = 0, vow_count = 0, vow_index;
        private void clickHereToSelectButton1_Click(object sender, EventArgs e)
        {
            //here we can see the open file
            OpenFileDialog ofd = new OpenFileDialog(); //Creates open file dialog
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                str = System.IO.File.ReadAllText(ofd.FileName); //read text file from our string file s
                displayFileTextBox1.Text = str.ToLower();//make it in lower
                string[] array = str.Split(' ');//split string with blank seperator
                firstWordTextBox2.Text = array[0];//it is first word
                lastWordTextBox3.Text = array[array.Length - 1];//it is last word
                for (int i = 0; i < array.Length - 1; i++)//here loop from start to end to make our appropriate output
                {
                    if (max_val < array[i].Length)
                    {
                        max_val = array[i].Length;
                        max_index = i;
                    }
                    if (vow_count < VowelCount(array[i]))
                    {
                        vow_count = VowelCount(array[i]);
                        vow_index = i;
                    }
                }
                longestWordTextBox4.Text = array[max_index];//output dispaly
                mostVowelTextBox5.Text = array[vow_index];//output dispaly
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\write.txt");//Textfile write here
                sw.WriteLine("Converting in Lower ::" + displayFileTextBox1.Text);//Textfile write here
                sw.WriteLine("First Word ::" + firstWordTextBox2.Text);//Textfile write here
                sw.WriteLine("Last Word ::" + lastWordTextBox3.Text);//Textfile write here
                sw.WriteLine("Longest word ::" + longestWordTextBox4.Text);//Textfile write here
                sw.WriteLine("Longest Vowel Word ::" + mostVowelTextBox5.Text);//Textfile write here
                sw.Close();
                MessageBox.Show("Text file is Created");//output display for message
            }

        }
        public int VowelCount(string sentence)//function for vowel count here
        {
            int vowels = 0;
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u') || (sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
                'I' || sentence[i] == 'O' || sentence[i] == 'U'))
                {
                    vowels = vowels + 1;
                }

            }
            return vowels;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
