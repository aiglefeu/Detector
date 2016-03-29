using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Détecteur_de_mots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            
        }

      
        static void detecteur(string envoyer, string comparaison)
        {

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string envoyer = richTextBox1.Text+" " ;
            string test2 = " " + richTextBox1.Text;
            string comparaison = textBox2.Text;
            int nombredecarac = comparaison.Length;
            string afficher;
            string afficher1;
            int compteur = 0;
            string[] ponctutation = { ",", " ", ";", ":","." };


            if (checkBox2.Checked == true)
            {

                    for (int i = 0; i + (nombredecarac) < envoyer.Length; i++)
                {

                    afficher = envoyer.Substring(i, nombredecarac);

                    
                    
                    

                    if (afficher.ToLower() == comparaison)
                        {

                        compteur += 1;

                        if (checkBox3.Checked == true)
                        {
                            richTextBox1.SelectionStart = i;
                            richTextBox1.SelectionLength = nombredecarac;

                            switch (listBox1.Text)
                            {
                                case "Rouge":
                                    richTextBox1.SelectionColor = Color.Red;
                                    break;

                                case "Vert":
                                    richTextBox1.SelectionColor = Color.Green;
                                    break;

                                case "Jaune":
                                    richTextBox1.SelectionColor = Color.Yellow;
                                    break;

                                case "Bleu":
                                    richTextBox1.SelectionColor = Color.Blue;
                                    break;

                                case "Violet":
                                    richTextBox1.SelectionColor = Color.Purple;
                                    break;

                                case "Noir":
                                    richTextBox1.SelectionColor = Color.Black;
                                    break;

                            }
                            
                            
                        }

                        else
                        {
                            richTextBox1.SelectionStart = i;
                            richTextBox1.SelectionLength = nombredecarac;
                            richTextBox1.SelectionColor = Color.Black;
                        }
                        
                        }

                    

                }

                label1.Text = "nombres de sons " + comparaison + " : " + compteur;

            }

            if (checkBox1.Checked == true)
            {

                for (int a = 0; a + (nombredecarac + 2) < envoyer.Length; a++)
                {
                    foreach (string x in ponctutation)
                    {

                        if (a == 0)
                        {
                            afficher1 = envoyer.Substring(a, nombredecarac + 1);

                            if (afficher1.ToLower() == comparaison + x)
                            {
                                compteur += 1;
                                if (checkBox3.Checked == true)
                                {
                                    richTextBox1.SelectionStart = a;
                                    richTextBox1.SelectionLength = nombredecarac;

                                    switch (listBox1.Text)
                                    {
                                        case "Rouge":
                                            richTextBox1.SelectionColor = Color.Red;
                                            break;

                                        case "Vert":
                                            richTextBox1.SelectionColor = Color.Green;
                                            break;

                                        case "Jaune":
                                            richTextBox1.SelectionColor = Color.Yellow;
                                            break;

                                        case "Bleu":
                                            richTextBox1.SelectionColor = Color.Blue;
                                            break;

                                        case "Violet":
                                            richTextBox1.SelectionColor = Color.Purple;
                                            break;

                                        case "Noir":
                                            richTextBox1.SelectionColor = Color.Black;
                                            break;

                                    }


                                }

                               
                            }

                        }

                            afficher1 = envoyer.Substring(a, nombredecarac + 2);

                            if (afficher1.ToLower() == " " + comparaison + x)
                            {

                                compteur += 1;
                            if (checkBox3.Checked == true)
                            {
                                richTextBox1.SelectionStart = a;
                                richTextBox1.SelectionLength = nombredecarac+2;

                                switch (listBox1.Text)
                                {
                                    case "Rouge":
                                        richTextBox1.SelectionColor = Color.Red;
                                        break;

                                    case "Vert":
                                        richTextBox1.SelectionColor = Color.Green;
                                        break;

                                    case "Jaune":
                                        richTextBox1.SelectionColor = Color.Yellow;
                                        break;

                                    case "Bleu":
                                        richTextBox1.SelectionColor = Color.Blue;
                                        break;

                                    case "Violet":
                                        richTextBox1.SelectionColor = Color.Purple;
                                        break;

                                    case "Noir":
                                        richTextBox1.SelectionColor = Color.Black;
                                        break;

                                }


                            }

                            else
                            {
                                richTextBox1.SelectionStart = a;
                                richTextBox1.SelectionLength = nombredecarac+2;
                                richTextBox1.SelectionColor = Color.Black;
                            }

                        }

                        


                    }

                    label1.Text = "nombres de mots " + comparaison + " : " + compteur;
                }


            }
        }
    

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                checkBox2.Checked = false;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
            
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }
    }
}

