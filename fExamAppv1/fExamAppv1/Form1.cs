using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fExamAppv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] question1;
        public string[] question2;
        public string[] question3;
        public string[] question4;
        public string[] question5;
        public string[] question6;
        public string[] question7;
        public string[] question8;
        public string[] question9;
        public string[] question10;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void Checkit()
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserAnswer1.Text))
                {
                    this.sonuc1.Text = "∅";//empty
                }
                else if (txtUserAnswer1.Text == txtQuestion1Correct1.Text)
                {
                    this.sonuc1.Text = "✓";//true
                }
                else
                {
                    this.sonuc1.Text = "×";//false
                }

                //
                if (string.IsNullOrEmpty(txtUserAnswer2.Text))
                {
                    this.sonuc2.Text = "∅";//empty
                }
                else if (txtUserAnswer2.Text == txtQuestion2Correct2.Text)
                {
                    this.sonuc2.Text = "✓";//true
                }
                else
                {
                    this.sonuc2.Text = "×";//false
                }

                //
                if (string.IsNullOrEmpty(txtUserAnswer3.Text))
                {
                    this.sonuc3.Text = "∅";//empty
                }
                else if (txtUserAnswer3.Text == txtQuestion3Correct3.Text)
                {
                    this.sonuc3.Text = "✓";//true
                }
                else
                {
                    this.sonuc3.Text = "×";//false
                }

                //
                if (string.IsNullOrEmpty(txtUserAnswer4.Text))
                {
                    this.sonuc4.Text = "∅";//empty
                }
                else if (txtUserAnswer4.Text == txtQuestion4Correct4.Text)
                {
                    this.sonuc4.Text = "✓";//true
                }
                else
                {
                    this.sonuc4.Text = "×";//false
                }

                //
                if (string.IsNullOrEmpty(txtUserAnswer5.Text))
                {
                    this.sonuc5.Text = "∅";//empty
                }
                else if (txtUserAnswer5.Text == txtQuestion5Correct5.Text)
                {
                    this.sonuc5.Text = "✓";//true
                }
                else
                {
                    this.sonuc5.Text = "×";//false
                }

                //
                if (string.IsNullOrEmpty(txtUserAnswer6.Text))
                {
                    this.sonuc6.Text = "∅";//empty
                }
                else if (txtUserAnswer6.Text == txtQuestion6Correct6.Text)
                {
                    this.sonuc6.Text = "✓";//true
                }
                else
                {
                    this.sonuc6.Text = "×";//false
                }

                //
                if (string.IsNullOrEmpty(txtUserAnswer7.Text))
                {
                    this.sonuc7.Text = "∅";//empty
                }
                else if (txtUserAnswer7.Text == txtQuestion7Correct7.Text)
                {
                    this.sonuc7.Text = "✓";//true
                }
                else
                {
                    this.sonuc7.Text = "×";//false
                }

                //
                if (string.IsNullOrEmpty(txtUserAnswer8.Text))
                {
                    this.sonuc8.Text = "∅";//empty
                }
                else if (txtUserAnswer8.Text == txtQuestion8Correct8.Text)
                {
                    this.sonuc8.Text = "✓";//true
                }
                else
                {
                    this.sonuc8.Text = "×";//false
                }

                //
                if (string.IsNullOrEmpty(txtUserAnswer9.Text))
                {
                    this.sonuc9.Text = "∅";//empty
                }
                else if (txtUserAnswer9.Text == txtQuestion9Correct9.Text)
                {
                    this.sonuc9.Text = "✓";//true
                }
                else
                {
                    this.sonuc9.Text = "×";//false
                }

                //
                if (string.IsNullOrEmpty(txtUserAnswer10.Text))
                {
                    this.sonuc10.Text = "∅";//empty
                }
                else if (txtUserAnswer10.Text == txtQuestion10Correct10.Text)
                {
                    this.sonuc10.Text = "✓";//true
                }
                else
                {
                    this.sonuc10.Text = "×";//false
                }
            }

            catch (Exception)
            {
                MessageBox.Show("hata");
            }


        }

        public void possibleAnswersAndQuestion()
        {

            //adding text into arrays for question 10
            question1 = new string[5]

                {
                txtQuestion1.Text,
                txtQuestion1Possible1.Text,
                txtQuestion1Possible2.Text,
                txtQuestion1Possible3.Text,
                txtQuestion1Possible4.Text
                };


            question2 = new string[5]
                {
                txtQuestion2.Text,
                txtQuestion2Possible1.Text,
                txtQuestion2Possible2.Text,
                txtQuestion2Possible3.Text,
                txtQuestion2Possible4.Text
                };


            question3 = new string[5]
                {
                txtQuestion3.Text,
                txtQuestion3Possible1.Text,
                txtQuestion3Possible2.Text,
                txtQuestion3Possible3.Text,
                txtQuestion3Possible4.Text
                };

            question4 = new string[5]
                {
                txtQuestion4.Text,
                txtQuestion4Possible1.Text,
                txtQuestion4Possible2.Text,
                txtQuestion4Possible3.Text,
                txtQuestion4Possible4.Text
                };


            question5 = new string[5]
                {
                txtQuestion5.Text,
                txtQuestion5Possible1.Text,
                txtQuestion5Possible2.Text,
                txtQuestion5Possible3.Text,
                txtQuestion5Possible4.Text
                };


            question6 = new string[5]

                {
                txtQuestion6.Text,
                txtQuestion6Possible1.Text,
                txtQuestion6Possible2.Text,
                txtQuestion6Possible3.Text,
                txtQuestion6Possible4.Text
                };


            question7 = new string[5]
                {
                txtQuestion7.Text,
                txtQuestion7Possible1.Text,
                txtQuestion7Possible2.Text,
                txtQuestion7Possible3.Text,
                txtQuestion7Possible4.Text
                };


            question8 = new string[5]
                {
                txtQuestion8.Text,
                txtQuestion8Possible1.Text,
                txtQuestion8Possible2.Text,
                txtQuestion8Possible3.Text,
                txtQuestion8Possible4.Text
                };

            question9 = new string[5]
                {
                txtQuestion9.Text,
                txtQuestion9Possible1.Text,
                txtQuestion9Possible2.Text,
                txtQuestion9Possible3.Text,
                txtQuestion9Possible4.Text
                };


            question10 = new string[5]
                {
                txtQuestion10.Text,
                txtQuestion10Possible1.Text,
                txtQuestion10Possible2.Text,
                txtQuestion10Possible3.Text,
                txtQuestion10Possible4.Text
                };


            lblQuestion1.Text = question1[0];
            lblQuestion1Possible.Text = "";

            for (int x = 1; x < question1.Length; x++)
            {
                lblQuestion1Possible.Text += question1[x] + "\n";
            }


            lblQuestion2.Text = question2[0];
            lblQuestion2Possible.Text = "";

            for (int x = 1; x < question2.Length; x++)
            {
                lblQuestion2Possible.Text += question2[x] + "\n";
            }


            lblQuestion3.Text = question3[0];
            lblQuestion3Possible.Text = "";

            for (int x = 1; x < question3.Length; x++)
            {
                lblQuestion3Possible.Text += question3[x] + "\n";
            }


            lblQuestion4.Text = question4[0];
            lblQuestion4Possible.Text = "";

            for (int x = 1; x < question4.Length; x++)
            {
                lblQuestion4Possible.Text += question4[x] + "\n";
            }


            lblQuestion5.Text = question5[0];
            lblQuestion5Possible.Text = "";

            for (int x = 1; x < question5.Length; x++)
            {
                lblQuestion5Possible.Text += question5[x] + "\n";
            }

            lblQuestion6.Text = question6[0];
            lblQuestion6Possible.Text = "";

            for (int x = 1; x < question6.Length; x++)
            {
                lblQuestion6Possible.Text += question6[x] + "\n";
            }

            lblQuestion7.Text = question7[0];
            lblQuestion7Possible.Text = "";

            for (int x = 1; x < question7.Length; x++)
            {
                lblQuestion7Possible.Text += question7[x] + "\n";
            }

            lblQuestion8.Text = question8[0];
            lblQuestion8Possible.Text = "";

            for (int x = 1; x < question8.Length; x++)
            {
                lblQuestion8Possible.Text += question8[x] + "\n";
            }

            lblQuestion9.Text = question9[0];
            lblQuestion9Possible.Text = "";

            for (int x = 1; x < question9.Length; x++)
            {
                lblQuestion9Possible.Text += question9[x] + "\n";
            }

            lblQuestion10.Text = question10[0];
            lblQuestion10Possible.Text = "";

            for (int x = 1; x < question10.Length; x++)
            {
                lblQuestion10Possible.Text += question10[x] + "\n";
            }



        }



        private void btnMemo_Click(object sender, EventArgs e)
        {
            Checkit();
        }

        private void btnSetTest_Click(object sender, EventArgs e)
        {
            possibleAnswersAndQuestion();
        }
      
        

        private void txtQuestion1Correct1_TextChanged_1(object sender, EventArgs e)
        {
            if (!(txtQuestion1Correct1.Text.Contains("A") || txtQuestion1Correct1.Text.Contains("B") || txtQuestion1Correct1.Text.Contains("C") || txtQuestion1Correct1.Text.Contains("D") || txtQuestion1Correct1.Text == null || txtQuestion1Correct1.Text.Contains("a") || txtQuestion1Correct1.Text.Contains("b") || txtQuestion1Correct1.Text.Contains("c") || txtQuestion1Correct1.Text.Contains("d") || txtQuestion1Correct1.Text == ""))
            {
                txtQuestion1Correct1.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuestion2Correct2_TextChanged_1(object sender, EventArgs e)
        {
            if (!(txtQuestion2Correct2.Text.Contains("A") || txtQuestion2Correct2.Text.Contains("B") || txtQuestion2Correct2.Text.Contains("C") || txtQuestion2Correct2.Text.Contains("D") || txtQuestion2Correct2.Text == null || txtQuestion2Correct2.Text.Contains("a") || txtQuestion2Correct2.Text.Contains("b") || txtQuestion2Correct2.Text.Contains("c") || txtQuestion2Correct2.Text.Contains("d") || txtQuestion2Correct2.Text == ""))
            {
                txtQuestion2Correct2.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuestion3Correct3_TextChanged_1(object sender, EventArgs e)
        {
            if (!(txtQuestion3Correct3.Text.Contains("A") || txtQuestion3Correct3.Text.Contains("B") || txtQuestion3Correct3.Text.Contains("C") || txtQuestion3Correct3.Text.Contains("D") || txtQuestion3Correct3.Text == null || txtQuestion3Correct3.Text.Contains("a") || txtQuestion3Correct3.Text.Contains("b") || txtQuestion3Correct3.Text.Contains("c") || txtQuestion3Correct3.Text.Contains("d") || txtQuestion3Correct3.Text == ""))
            {
                txtQuestion3Correct3.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuestion4Correct4_TextChanged_1(object sender, EventArgs e)
        {
            if (!(txtQuestion4Correct4.Text.Contains("A") || txtQuestion4Correct4.Text.Contains("B") || txtQuestion4Correct4.Text.Contains("C") || txtQuestion4Correct4.Text.Contains("D") || txtQuestion4Correct4.Text == null || txtQuestion4Correct4.Text.Contains("a") || txtQuestion4Correct4.Text.Contains("b") || txtQuestion4Correct4.Text.Contains("c") || txtQuestion4Correct4.Text.Contains("d") || txtQuestion4Correct4.Text == ""))
            {
                txtQuestion4Correct4.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuestion5Correct5_TextChanged_1(object sender, EventArgs e)
        {
            if (!(txtQuestion5Correct5.Text.Contains("A") || txtQuestion5Correct5.Text.Contains("B") || txtQuestion5Correct5.Text.Contains("C") || txtQuestion5Correct5.Text.Contains("D") || txtQuestion5Correct5.Text == null || txtQuestion5Correct5.Text.Contains("a") || txtQuestion5Correct5.Text.Contains("b") || txtQuestion5Correct5.Text.Contains("c") || txtQuestion5Correct5.Text.Contains("d") || txtQuestion5Correct5.Text == ""))
            {
                txtQuestion5Correct5.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuestion6Correct6_TextChanged_1(object sender, EventArgs e)
        {
            if (!(txtQuestion6Correct6.Text.Contains("A") || txtQuestion6Correct6.Text.Contains("B") || txtQuestion6Correct6.Text.Contains("C") || txtQuestion6Correct6.Text.Contains("D") || txtQuestion6Correct6.Text == null || txtQuestion6Correct6.Text.Contains("a") || txtQuestion6Correct6.Text.Contains("b") || txtQuestion6Correct6.Text.Contains("c") || txtQuestion6Correct6.Text.Contains("d") || txtQuestion6Correct6.Text == ""))
            {
                txtQuestion6Correct6.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuestion7Correct7_TextChanged_1(object sender, EventArgs e)
        {
            if (!(txtQuestion7Correct7.Text.Contains("A") || txtQuestion7Correct7.Text.Contains("B") || txtQuestion7Correct7.Text.Contains("C") || txtQuestion7Correct7.Text.Contains("D") || txtQuestion7Correct7.Text == null || txtQuestion7Correct7.Text.Contains("a") || txtQuestion7Correct7.Text.Contains("b") || txtQuestion7Correct7.Text.Contains("c") || txtQuestion7Correct7.Text.Contains("d") || txtQuestion7Correct7.Text == ""))
            {
                txtQuestion7Correct7.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuestion8Correct8_TextChanged_1(object sender, EventArgs e)
        {
            if (!(txtQuestion8Correct8.Text.Contains("A") || txtQuestion8Correct8.Text.Contains("B") || txtQuestion8Correct8.Text.Contains("C") || txtQuestion8Correct8.Text.Contains("D") || txtQuestion8Correct8.Text == null || txtQuestion8Correct8.Text.Contains("a") || txtQuestion8Correct8.Text.Contains("b") || txtQuestion8Correct8.Text.Contains("c") || txtQuestion8Correct8.Text.Contains("d") || txtQuestion8Correct8.Text == ""))
            {
                txtQuestion8Correct8.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuestion9Correct9_TextChanged_1(object sender, EventArgs e)
        {
            if (!(txtQuestion9Correct9.Text.Contains("A") || txtQuestion9Correct9.Text.Contains("B") || txtQuestion9Correct9.Text.Contains("C") || txtQuestion9Correct9.Text.Contains("D") || txtQuestion9Correct9.Text == null || txtQuestion9Correct9.Text.Contains("a") || txtQuestion9Correct9.Text.Contains("b") || txtQuestion9Correct9.Text.Contains("c") || txtQuestion9Correct9.Text.Contains("d") || txtQuestion9Correct9.Text == ""))
            {
                txtQuestion9Correct9.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuestion10Correct10_TextChanged_1(object sender, EventArgs e)
        {
            if (!(txtQuestion10Correct10.Text.Contains("A") || txtQuestion10Correct10.Text.Contains("B") || txtQuestion10Correct10.Text.Contains("C") || txtQuestion10Correct10.Text.Contains("D") || txtQuestion10Correct10.Text == null || txtQuestion10Correct10.Text.Contains("a") || txtQuestion10Correct10.Text.Contains("b") || txtQuestion10Correct10.Text.Contains("c") || txtQuestion10Correct10.Text.Contains("d") || txtQuestion10Correct10.Text == ""))
            {
                txtQuestion10Correct10.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        ////////////////
        ////////////////
        ////////////////
        private void txtUserAnswer1_TextChanged(object sender, EventArgs e)
        {
            if (!(txtUserAnswer1.Text.Contains("A") || txtUserAnswer1.Text.Contains("B") || txtUserAnswer1.Text.Contains("C") || txtUserAnswer1.Text.Contains("D") || txtUserAnswer1.Text == null || txtUserAnswer1.Text.Contains("a") || txtUserAnswer1.Text.Contains("b") || txtUserAnswer1.Text.Contains("c") || txtUserAnswer1.Text.Contains("d") || txtUserAnswer1.Text == ""))
            {
                txtUserAnswer1.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserAnswer2_TextChanged(object sender, EventArgs e)
        {
            if (!(txtUserAnswer2.Text.Contains("A") || txtUserAnswer2.Text.Contains("B") || txtUserAnswer2.Text.Contains("C") || txtUserAnswer2.Text.Contains("D") || txtUserAnswer2.Text == null || txtUserAnswer2.Text.Contains("a") || txtUserAnswer2.Text.Contains("b") || txtUserAnswer2.Text.Contains("c") || txtUserAnswer2.Text.Contains("d") || txtUserAnswer2.Text == ""))
            {
                txtUserAnswer2.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserAnswer3_TextChanged(object sender, EventArgs e)
        {
            if (!(txtUserAnswer3.Text.Contains("A") || txtUserAnswer3.Text.Contains("B") || txtUserAnswer3.Text.Contains("C") || txtUserAnswer3.Text.Contains("D") || txtUserAnswer3.Text == null || txtUserAnswer3.Text.Contains("a") || txtUserAnswer3.Text.Contains("b") || txtUserAnswer3.Text.Contains("c") || txtUserAnswer3.Text.Contains("d") || txtUserAnswer3.Text == ""))
            {
                txtUserAnswer3.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserAnswer4_TextChanged(object sender, EventArgs e)
        {
            if (!(txtUserAnswer4.Text.Contains("A") || txtUserAnswer4.Text.Contains("B") || txtUserAnswer4.Text.Contains("C") || txtUserAnswer4.Text.Contains("D") || txtUserAnswer4.Text == null || txtUserAnswer4.Text.Contains("a") || txtUserAnswer4.Text.Contains("b") || txtUserAnswer4.Text.Contains("c") || txtUserAnswer4.Text.Contains("d") || txtUserAnswer4.Text == ""))
            {
                txtUserAnswer4.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserAnswer5_TextChanged(object sender, EventArgs e)
        {
            if (!(txtUserAnswer5.Text.Contains("A") || txtUserAnswer5.Text.Contains("B") || txtUserAnswer5.Text.Contains("C") || txtUserAnswer5.Text.Contains("D") || txtUserAnswer5.Text == null || txtUserAnswer5.Text.Contains("a") || txtUserAnswer5.Text.Contains("b") || txtUserAnswer5.Text.Contains("c") || txtUserAnswer5.Text.Contains("d") || txtUserAnswer5.Text == ""))
            {
                txtUserAnswer5.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserAnswer6_TextChanged(object sender, EventArgs e)
        {
            if (!(txtUserAnswer6.Text.Contains("A") || txtUserAnswer6.Text.Contains("B") || txtUserAnswer6.Text.Contains("C") || txtUserAnswer6.Text.Contains("D") || txtUserAnswer6.Text == null || txtUserAnswer6.Text.Contains("a") || txtUserAnswer6.Text.Contains("b") || txtUserAnswer6.Text.Contains("c") || txtUserAnswer6.Text.Contains("d") || txtUserAnswer6.Text == ""))
            {
                txtUserAnswer6.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserAnswer7_TextChanged(object sender, EventArgs e)
        {
            if (!(txtUserAnswer7.Text.Contains("A") || txtUserAnswer7.Text.Contains("B") || txtUserAnswer7.Text.Contains("C") || txtUserAnswer7.Text.Contains("D") || txtUserAnswer7.Text == null || txtUserAnswer7.Text.Contains("a") || txtUserAnswer7.Text.Contains("b") || txtUserAnswer7.Text.Contains("c") || txtUserAnswer7.Text.Contains("d") || txtUserAnswer7.Text == ""))
            {
                txtUserAnswer7.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserAnswer8_TextChanged(object sender, EventArgs e)
        {
            if (!(txtUserAnswer8.Text.Contains("A") || txtUserAnswer8.Text.Contains("B") || txtUserAnswer8.Text.Contains("C") || txtUserAnswer8.Text.Contains("D") || txtUserAnswer8.Text == null || txtUserAnswer8.Text.Contains("a") || txtUserAnswer8.Text.Contains("b") || txtUserAnswer8.Text.Contains("c") || txtUserAnswer8.Text.Contains("d") || txtUserAnswer8.Text == ""))
            {
                txtUserAnswer8.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserAnswer9_TextChanged(object sender, EventArgs e)
        {
            if (!(txtUserAnswer9.Text.Contains("A") || txtUserAnswer9.Text.Contains("B") || txtUserAnswer9.Text.Contains("C") || txtUserAnswer9.Text.Contains("D") || txtUserAnswer9.Text == null || txtUserAnswer9.Text.Contains("a") || txtUserAnswer9.Text.Contains("b") || txtUserAnswer9.Text.Contains("c") || txtUserAnswer9.Text.Contains("d") || txtUserAnswer9.Text == ""))
            {
                txtUserAnswer9.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserAnswer10_TextChanged(object sender, EventArgs e)
        {
            if (!(txtUserAnswer10.Text.Contains("A") || txtUserAnswer10.Text.Contains("B") || txtUserAnswer10.Text.Contains("C") || txtUserAnswer10.Text.Contains("D") || txtUserAnswer10.Text == null || txtUserAnswer10.Text.Contains("a") || txtUserAnswer10.Text.Contains("b") || txtUserAnswer10.Text.Contains("c") || txtUserAnswer10.Text.Contains("d") || txtUserAnswer10.Text == ""))
            {
                txtUserAnswer10.Text = "";
                MessageBox.Show("Please enter only A - D", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/karatasyakup");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/yakupkrg35/");
        }
    }
    
    
}
