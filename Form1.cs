namespace İkili_Arama___2021512001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int elemanSayısı;
        int[] dizi1;

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            elemanSayısı = int.Parse(textBox1.Text);
            dizi1 = new int[elemanSayısı];


            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] =
                int.Parse(Microsoft.VisualBasic.Interaction.InputBox(i + 1 + ". elemanı giriniz", "DİZİ ELEMANLARI", "", 50, 50));
                textBox2.Text += dizi1[i] + " ";
            }
            for (int i = 0; i < dizi1.Length - 1; i++) for (int j = 0; j < dizi1.Length - i - 1; j++) if (dizi1[j] > dizi1[j + 1])
                    {
                        int yedek = dizi1[j]; dizi1[j] = dizi1[j + 1]; dizi1[j + 1] = yedek;
                    }
            for (int i = 0; i < dizi1.Length; i++) textBox3.Text += dizi1[i] + " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            textBox4.Clear();
            textBox2.Text = ("");
            textBox1.Text = ("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aranan = int.Parse(textBox4.Text); 
            int bulundu = 0, alt = 0, ct = 0, üst = dizi1.Length, orta; 
            while ((üst - alt > 1) && (bulundu == 0))
            {
                orta = (alt + üst) / 2; 
                if (dizi1[orta] == aranan) bulundu = orta;
                else if (aranan > dizi1[orta]) alt = orta;
                else üst = orta;
            }
            if (bulundu != 0)
                MessageBox.Show("Aranan değer " + (bulundu + 1) + ". sırada bulundu.");
            else
                MessageBox.Show("Aranan değer bulunamadı.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Listeye Eklediğiniz Eleman Dizisi = "+ textBox2.Text+" Şeklindedir.");
            listBox2.Items.Add("---------------------------------------------------------------------------------");
            listBox2.Items.Add("Eleman Dizisinin Sıralanmış Hali = " + textBox3.Text + " Şeklindedir.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = ("");
            textBox3.Text = ("");
            label5.Text = ("----------------------------------------------------");
        }

    }
}