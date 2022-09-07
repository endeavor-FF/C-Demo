using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary_CSharpTest;
using Newtonsoft.Json;

namespace Winform_CSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Class1 x = new Class1();

        private void button1_Click(object sender, EventArgs e)
        {

            string sRetValue = x.CallPid();
            var obj = JsonConvert.DeserializeObject<MessageTag>(sRetValue);
            textBox1.Text = obj.sRet01;
            textBox2.Text = obj.sRet02;
            textBox3.Text = obj.sRet03;
            textBox4.Text = obj.sRet04;
            textBox5.Text = obj.sRet05;
            textBox6.Text = obj.sRet06;
            textBox7.Text = obj.sRet07;
            textBox8.Text = obj.sRet08;
            textBox9.Text = obj.sRet09;
            textBox10.Text = obj.sRet10;

            List<Student> TheComd = JsonConvert.DeserializeObject<List<Student>>(obj.FYXData);

            DataTable ds = null;
            ds = ExtensionMethods.ToDataTable(TheComd); //把List转成DataTable ,如果绑定list,grid无法排序。

            dataGridView1.DataSource = ds;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
