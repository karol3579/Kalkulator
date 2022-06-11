using System.Diagnostics;

namespace Kalkulator
{
    public partial class Form1 : Form
    {

        int charcount = 0;
        int numberscount=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zapisz(button1);
        }


       

        private void button2_Click(object sender, EventArgs e)
        {
            zapisz(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zapisz(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zapisz(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zapisz(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            zapisz(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zapisz(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            zapisz(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            zapisz(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            zapisz(button10);
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (charcount == 0)
            {
                zapisz(buttonDodaj);
                charcount++;
            }
        }

        private void buttonOdejmij_Click(object sender, EventArgs e)
        {
            if (charcount == 0) {
                zapisz(buttonOdejmij);
                charcount++;
            }
        }

        private void buttonRownaSie_Click(object sender, EventArgs e)
        {
            char[] arr = textBox1.Text.ToCharArray();
            int wynik;
            if (arr[numberscount-1] == '+') {
                textBox1.Text = (convertLiczba1(arr) + convertLiczba2(arr)).ToString();
            } else textBox1.Text = (convertLiczba1(arr) - convertLiczba2(arr)).ToString();
            clearText();
        }

        private void zapisz(Button button)
        {
            textBox1.Text = textBox1.Text + button.Text;
            if(charcount==0) numberscount++;

        }

        int convertLiczba1(char[] liczby) {
            string text = "";
            int liczba1;
            for (int i = 0; i < numberscount-1; i++) {
                text = text + liczby[i];
            }
            Debug.WriteLine(text);
            liczba1 = int.Parse(text);


            return liczba1;
        }

        int convertLiczba2(char[] liczby)
        {
            string text = "";
            int liczba2;

            for (int j = numberscount; j < liczby.Length; j++)
            {
                text = text + liczby[j];
            }
            Debug.WriteLine(text);
            liczba2 = int.Parse(text);

            return liczba2;
        }



        private void clearText() {

        charcount = 0;
        numberscount = textBox1.TextLength;
        }
    }
}