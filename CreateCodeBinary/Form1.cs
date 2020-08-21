using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCodeBinary
{
    public partial class Form1 : Form
    {
        List<List<Button>> matrix;
        List<string> lstInput;
        List<TextBox> lstTextBox;
        List<List<string>> codeBinary = new List<List<string>>();
        List<string> lstTest = new List<string>() { "0.25", "0.21", "0.19", "0.16", "0.15", "0.04" };
        List<string> h1 = new List<string>(){ "STT", "pi", "qi", "Binary", "li", "Binary Code" };

        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        public List<TextBox> LstTextBox { get => lstTextBox; set => lstTextBox = value; }
        public List<string> LstInput { get => lstInput; set => lstInput = value; }
        public List<List<string>> CodeBinary { get => codeBinary; set => codeBinary = value; }

        public Form1()
        {
            InitializeComponent();
        }

        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0,0) };
            for (int i = 0; i < int.Parse(tbxCount.Text); i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < 6; j++) 
                {
                    Button btn = new Button() { Width = Define.WidthBtn, Height = Define.HeightBtn };
                    
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y);
                    
                    panelTable.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                    if (j == 0)
                        btn.Text = ("a" + i);

                    if (j == 1)
                        btn.Text = GetValueTextBox()[i];

                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, oldBtn.Location.Y + Define.HeightBtn) };
            }
            LoadContent();
        }

        List<string> Get_CodeBinary(string num, int count)
        {
            CodeBinary = new List<List<string>>();
            List<string> lstNum = new List<string>();
            
            float number = float.Parse(num);

            while (lstNum.Count < count)
            {
                number = number * 2;
                if (number < 1)
                {
                    lstNum.Add("0");
                }
                else
                {
                    lstNum.Add("1");
                    number = number - 1;
                }
            }
            CodeBinary.Add(lstNum);
            lstNum = new List<string>();
            
            return lstNum;
        }

        void LoadContent()
        {
            for (int i = 0; i < int.Parse(tbxCount.Text); i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == 2)
                    {
                        if (i == 0)
                            Matrix[0][j].Text = "0";
                        else
                            Matrix[i][j].Text = (Convert.ToDouble(Matrix[i-1][j].Text) + Convert.ToDouble(GetValueTextBox()[i-1])).ToString();
                    } 
                    else if (j == 4)
                    {
                        Matrix[i][j].Text = Math.Ceiling((-Math.Log(Convert.ToDouble(Matrix[i][1].Text), 2))).ToString();
                    }
                    else if (j == 5)
                    {
                        Get_CodeBinary(Matrix[i][2].Text, int.Parse(Matrix[i][4].Text));
                        foreach (List<string> item in CodeBinary)
                        {
                            for (int t = 0; t < item.Count; t++)
                                Matrix[i][j].Text = string.Concat(Matrix[i][j].Text, item[t]);
                        }
                    }
                }
            }
        }

        void LoadInput()
        {
            LstTextBox = new List<TextBox>();
            
            TextBox oldInput = new TextBox() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < int.Parse(tbxCount.Text); i++)
            {
                TextBox input = new TextBox() { Width = 100, Height = 30 };
                input.Location = new Point(oldInput.Location.X, oldInput.Location.Y);
                panelInput.Controls.Add(input);

                LstTextBox.Add(input);

                oldInput = new TextBox() { Location = new Point(0, input.Location.Y + 30) };
            }
        }

        List<string> GetValueTextBox()
        {
            LstInput = new List<string>();
            foreach (TextBox item in LstTextBox)
                LstInput.Add(item.Text);
            return LstInput;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (tbxCount.Text == string.Empty)
                MessageBox.Show("Input number on field, Please!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else LoadInput();
        }

        int checkNull()
        {
            int check = 1;
            for (int i = 0; i < LstInput.Count; i++)
            {
                if (lstInput[i] == string.Empty)
                    check = 0;
            }
            return check;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            GetValueTextBox();
            if (checkNull() == 0)
                MessageBox.Show("Input full on field, Please!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else LoadMatrix();
        }

    }
}
