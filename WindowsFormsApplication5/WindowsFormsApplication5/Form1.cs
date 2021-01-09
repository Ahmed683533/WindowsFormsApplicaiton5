using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Csharp_TIC_TAC_TOE : Form
    {
        public Csharp_TIC_TAC_TOE()
        {
            InitializeComponent();
        }

        private void Csharp_TIC_TAC_TOE_Load(object sender, EventArgs e)
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Click += new System.EventHandler(btn_click);
                }
            }
        }
        int XorO = 0;
        public void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            { 
            if (XorO % 2 == 0)
            {
                btn.Text = "X";
                btn.ForeColor = Color.Blue;
                label1.Text = "O turn now";
                    getTheWinner();
                }
            else
            {
                btn.Text = "O";
                btn.ForeColor = Color.Red;
                label1.Text = "X turn now";
                    getTheWinner();
                }

            XorO++;
        }
    }
        bool win = false;


        public void getTheWinner()
        {
            if (!button1.Text.Equals("") && button1.Text.Equals(button2.Text) && button1.Text.Equals(button3.Text))
            {
                winEffect(button1, button2, button3);
                win = true;
            }
            if (!button4.Text.Equals("") && button4.Text.Equals(button5.Text) && button4.Text.Equals(button6.Text))
            {
                winEffect(button4, button5, button6);
                win = true;
            }
            if (!button7.Text.Equals("") && button7.Text.Equals(button8.Text) && button7.Text.Equals(button9.Text))
            {
                winEffect(button7, button8, button9);
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button4.Text) && button1.Text.Equals(button7.Text))
            {
                winEffect(button1, button4, button7);
                win = true;
            }
            if (!button2.Text.Equals("") && button2.Text.Equals(button5.Text) && button2.Text.Equals(button8.Text))
            {
                winEffect(button2, button5, button8);
                win = true;

            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button6.Text) && button3.Text.Equals(button9.Text))
            {
                winEffect(button3, button6, button9);
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button5.Text) && button1.Text.Equals(button9.Text))
            {
                winEffect(button1, button5, button9);
                win = true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button5.Text) && button3.Text.Equals(button7.Text))
            {
                winEffect(button3, button5, button7);
                win = true;
            }
            if (AllBtnLength() == 9 && win == false)
            {
                label1.Text = "No Winner";
            }

        }
        public int AllBtnLength()
        {
            int allTextButtonsLength = 0;
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    allTextButtonsLength += c.Text.Length;
                }
            }
            return allTextButtonsLength;
        }

        public void winEffect(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Green;
            b2.BackColor = Color.Green;
            b3.BackColor = Color.Green;

            b1.ForeColor = Color.White;
            b2.ForeColor = Color.White;
            b3.ForeColor = Color.White;

            label1.Text = b1.Text + " Win";
        }

        private void buttonpartie_Click(object sender, EventArgs e)
        {
            XorO = 0;
            win = false;
            label1.Text = "Play";
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.BackColor = Color.White;
                }
            }
        
    }
    }
}
            
        
    




    

    

  
                
                
                    
                
            
        

   
        
    

