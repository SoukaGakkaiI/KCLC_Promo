using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

    public partial class ClientInput : Form
    {
        public ClientInput()
        {
            InitializeComponent();
        }

        public bool trueclose=false;
        public string IP = "";
        public int Port = 0;
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            IP = maskedTextBox1.Text.Replace(" ", "");
            try
            {
                Port = int.Parse(textBox1.Text);
                this.Close();
                trueclose = true;
            }
            catch
            {
                MessageBox.Show("数字を入れてね");
            }
        }
        string[] datas;
        string bip;
        public void ClientInputSubstitution(string ip,int port)
        {
            datas = ip.Split('.');
            if (datas.Length > 3)
            {
                bip = "";
                for (int i = 0; i < 4; i++)
                {
                    if (datas[i].Length < 3)
                    {
                        datas[i] += " ";
                        if (datas[i].Length < 3)
                        {
                            datas[i] += " ";
                        }
                    }
                    bip += datas[i];
                }
                maskedTextBox1.Text = bip;
            }
            else
            {
                maskedTextBox1.Text = ip;
            }
            textBox1.Text = port.ToString();
        }
    }
