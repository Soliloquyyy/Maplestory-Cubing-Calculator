using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitComboBoxes();
        }

        private string[] Items =
        {
            "Weapon",
            "Emblem",
            "Secondary",
            "Shield",
            "Hat",
            "Top",
            "Bottom",
            "Shoes",
            "Gloves",
            "Cape",
            "Belt",
            "Shoulder",
            "Accessories",
            "Heart"
        };
        private Lines CurrentLine = new Weapon();
        private Item CurrentItem = new Item();
        Calculator calc = new Calculator();


        private bool setLine1 = false;
        private bool setLine2 = false;
        private bool setLine3 = false;

        private int[] desiredIndexArr = new int[3]; 


        //Function initComboBoxes
        //Description: initialize all initial combo(dropdown) boxes
        //return null
        private void InitComboBoxes()
        {
            for(int i = 0; i < 14; ++i)
            {
                comboBox1.Items.Add(this.Items[i]);
            }
            comboBox1.Text = "Weapon";
        }

        private void Simulate()
        {
            desiredIndexArr[0] = comboBox2.SelectedIndex;
            desiredIndexArr[1] = comboBox3.SelectedIndex;
            desiredIndexArr[2] = comboBox4.SelectedIndex;
            calc.desiredIndexArr = desiredIndexArr;
            calc.lines = CurrentLine;
            calc.item = CurrentItem;
            double result = calc.Simulate();
            System.Windows.Forms.MessageBox.Show(result.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentItem.setItemType(comboBox1.Text);
            string selectedItem = comboBox1.Text; 
            string[] availLines = CurrentItem.getLines();

            //clearing current comboboxes
            comboBox2.Items.Clear();
            comboBox2.Text = string.Empty;
            comboBox3.Items.Clear();
            comboBox3.Text = string.Empty;
            comboBox4.Items.Clear();
            comboBox4.Text = string.Empty;

            //Switch Case for creating item corresponding objects
            switch (selectedItem) {
                case "Weapon":
                    CurrentLine = new Weapon();
                    break;
                case "Accessories":
                    CurrentLine = new Accessories();
                    break;
                case "Belt":
                    CurrentLine = new Belt();
                    break;
                case "Bottom":
                    CurrentLine = new Bottom();
                    break;
                case "Cape":
                    CurrentLine = new Cape();
                    break;
                case "Emblem":
                    CurrentLine = new Emblem();
                    break;
                case "Gloves":
                    CurrentLine = new Gloves();
                    break;
                case "Hat":
                    CurrentLine = new Hat();
                    break;
                case "Heart":
                    CurrentLine = new Heart();
                    break;
                case "Secondary":
                    CurrentLine = new Secondary();
                    break;
                case "Shield":
                    CurrentLine = new Shield();
                    break;
                case "Shoes":
                    CurrentLine = new Shoes();
                    break;
                case "Shoulder":
                    CurrentLine = new Shoulder();
                    break;
                case "Top":
                    CurrentLine = new Top();
                    break;
            }

            //need different function
            for (int i = 0; i < CurrentLine.AvailLine1.Length; ++i)
            {
                int currentIndex = CurrentLine.AvailLine1[i];
                comboBox2.Items.Add(availLines[currentIndex]);
            }

            for (int i = 0; i < CurrentLine.AvailLine2.Length; ++i)
            {
                int currentIndex = CurrentLine.AvailLine2[i];
                comboBox3.Items.Add(availLines[currentIndex]);
            }

            for (int i = 0; i < CurrentLine.AvailLine3.Length; ++i)
            {
                int currentIndex = CurrentLine.AvailLine3[i];
                comboBox4.Items.Add(availLines[currentIndex]);
            }

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLine1 = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLine2 = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLine3 = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(setLine1 && setLine2 && setLine3)
            {
                Simulate();
            }
            else
            {
                string msg = "Please select the three Lines";
                string title = "Simulation Error";
                MessageBox.Show(msg, title);
            }
        }
    }
}
