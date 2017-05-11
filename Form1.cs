using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hangman3
{
    //we define a class in here.//********************************CLASS******************************************//

    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }
        string[] letters = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z", "x", "q", "w" };
        Hangman_operations cl_hangman;
        string word;
        string[] selected_word;
        int trial_right=7;
        int remaining_right;
        int width, height;
        private void Form1_Load(object sender, EventArgs e)
        {
            set_location();
            width =pcb_man.Width ;
            height = pcb_man.Height;
            remaining_right = trial_right;
            selected_word = new string[0];
            cl_hangman = new Hangman_operations();
        }
        private void select_word()
        {

            Hangman_operations.New_Word our_word_ = cl_hangman.take_word();
            lbl_category.Text =" This is a/an  " + our_word_.category;
            word = our_word_.word;
            foreach (char letter in word.ToCharArray())
            {
                lbl_word.Text = lbl_word.Text + "_ ";
            }
            strt_btn.Visible = false;


        }

        private void strt_btn_Click(object sender, EventArgs e)
        {
            pcb_man.Visible = true;
            textBox1.Visible = true;
            lbl_spoken.Visible = true;
            lbl_word.Visible = true;
            lbl_category.Visible = true;
            btn_try.Visible = true;
            select_word();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            bool found = false;
            bool spoken = false;
            foreach(var item in selected_word)
            {
                if(data.ToLower() == item.ToLower())
                {
                    spoken = true;
                    MessageBox.Show("You have said this letter before");
                }
            }
            if (!spoken) { 
            for (int i =0;i < letters.Length; i++)
            {
                if (data.ToLower() == letters[i])
                {
                    found = true;
                    find_the_word(data);
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Write the valid value");
            }
            update();
            }
            int index = lbl_word.Text.IndexOf(" ");
            if (index == -1)
            {
                next_stage();
            }
        }
        private void find_the_word(string letter)
        {
            bool check_correct = false;
            char[] array = word.ToCharArray();
            for(int a=0;a<array.Length;a++)
            {
                if(array[a].ToString() != "")
                {
                    if (letter == array[a].ToString().ToLower())
                    {
                        check_correct = true;
                        lbl_word.Text = lbl_word.Text.Remove(a * 2, 1);
                        lbl_word.Text = lbl_word.Text.Insert(a * 2, letter).ToUpper();
                        
                    }
                }
            }
            if (!check_correct)
            {
                remaining_right--;
                pcb_man.Invalidate();
            }
            add_letter(letter);
        }
        private void update()
        {
            lbl_spoken.Text = "";
            foreach(string item in selected_word)
            {
                lbl_spoken.Text = lbl_spoken.Text + item + " ";
            }
        }

        private void pcb_man_Paint(object sender, PaintEventArgs e)
        {
            Pen pencil = new Pen(Color.Black, 12);
            if (remaining_right != -1)
            {
                if (remaining_right < trial_right)
                {
                    e.Graphics.DrawLine(pencil, width / 10, height / 15, width / 10, height / 15 * 14);
                    e.Graphics.DrawLine(pencil, width / 10, height / 15, width / 2, height / 15);
                }
                if (remaining_right < trial_right - 1)
                {
                    e.Graphics.DrawLine(pencil, width / 2, height / 15, width / 2, height / 15 * 3);
                    e.Graphics.DrawEllipse(pencil, width / 2 - width / 20, height / 5, width / 10, height / 10);
                }
                if (remaining_right < trial_right - 2)
                {
                    e.Graphics.DrawLine(pencil, width / 2, height / 10 * 3, width / 2, height / 10 * 6);
                }
                if (remaining_right < trial_right - 3)
                {
                    e.Graphics.DrawLine(pencil, width / 2, height / 10 * 3, width / 2 + width / 10, height / 10 * 3 + height / 5);
                }
                if (remaining_right < trial_right - 4)
                {
                    e.Graphics.DrawLine(pencil, width / 2, height / 10 * 3, width / 2 - width / 10, height / 10 * 3 + height / 5);
                }
                if (remaining_right < trial_right - 5)
                {
                    e.Graphics.DrawLine(pencil, width / 2, height / 10 * 6, width / 2 + width / 10, height / 10 * 6 + height / 10);
                }
                if (remaining_right < trial_right - 6)
                {
                    e.Graphics.DrawLine(pencil, width / 2, height / 10 * 6, width / 2 - width / 10, height / 10 * 6 + height / 10);

                }
            }
            else {game_over(); }

        }

        private void add_letter(string letter)
        {
            string[] a = new string[selected_word.Length + 1];
           for(int i = 0; i < selected_word.Length; i++)
            {
                a[i] = selected_word[i];
            }
            a[a.Length - 1] = letter;
            selected_word = a;
        }
        private void next_stage()
        {
            clean();
            select_word();
        }
        private void game_over()
        {
            MessageBox.Show("Game is over. Correct word is : " + word);
            strt_btn.Visible = true;
            textBox1.Visible = false;
            btn_try.Visible = false;
            clean();
            pcb_man.Visible = false;
        }

        private void homepage_SizeChanged(object sender, EventArgs e)
        {

        }
        public void set_location()
        {
            int width, height;
            width = this.Width;
            height = this.Height;
            panel1.Width = width;
            panel1.Height = height;
            panel1.Location = new Point(0, 0);
            pcb_man.Width = width / 9 * 4;
            pcb_man.Height = height / 4 * 3;
            pcb_man.Location = new Point(width - pcb_man.Width - 10, 10);
            lbl_category.Location = new Point(10, 10);
            lbl_word.Location = new Point(10, 50);
            lbl_spoken.Location = new Point(10, 120);
            strt_btn.Size = new System.Drawing.Size(width / 3, height / 10);
            textBox1.Location = new Point(10, 90);
            strt_btn.Location = new Point(width / 2 - strt_btn.Width / 2, height / 2 - strt_btn.Height / 2);
            btn_try.Location = new Point(120, 90);
            lbl_spoken.Location = new Point(10, height / 2);




        }
        private void clean()
        {
            selected_word = new string[0];
            remaining_right = trial_right;
            pcb_man.Invalidate();
            lbl_category.Text = "";
            lbl_word.Text = "";
            lbl_spoken.Text = "";
            textBox1.Text = "";
        }
    }
    class Hangman_operations
    {
        private List<New_Word> New_Word_List;
        private List<New_Word> Word_List;
        public Hangman_operations()
        {
            take_data_folder();

        }
        public struct New_Word
        {
            public string word;
            public string category;
        }
        public New_Word take_word()
        {
            if (Word_List.Count == 0)
            {
                Word_List = New_Word_List;
            }
            Random rndm = new Random();
            int a = rndm.Next(0, Word_List.Count);
            New_Word our_word = Word_List[a];
            return our_word;
        }

        private New_Word Create_New_Word(string word,string category)
        {
            New_Word our_word = new New_Word();
            our_word.word = word;
            our_word.category = category;
            return our_word;
        }
        private void take_data_folder()
        {
            
            New_Word_List = new List<New_Word>();
            StreamReader read = new StreamReader(@"data.txt", Encoding.Default);
            string data;
            while ((data = read.ReadLine()) != null)
            {
                if (data != "")
                {
                    New_Word_List.Add(Create_New_Word(data.Split(',')[0], data.Split(',')[1]));
                }
            }
            Word_List = New_Word_List;


        }





    }

}
