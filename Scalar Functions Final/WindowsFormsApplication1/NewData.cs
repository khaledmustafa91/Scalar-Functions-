using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Xml;
using System.IO;

namespace WindowsFormsApplication1
{
    
    public partial class NewData : Form
    {
        public static List<string> Files = new List<string>();//save file name

        public NewData()
        {
            InitializeComponent();
            
        }

        private void NewData_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FileName.Text)) //to be button save disable when load gradeview
                button2.Enabled = false;
            else
                button2.Enabled = true;

            if (string.IsNullOrEmpty(textBox1.Text)) //to be button add disable when load gradeview
                button1.Enabled = false;
            else
                button1.Enabled = true;
            //if (textBox1.Equals(""))
            //    button1.Enabled = false;
            //else
            //    button1.Enabled = true;
            FileStream f = new FileStream("Files_name.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);
            while(sr.Peek() != -1)
            {
                string Obj = (string)sr.ReadLine();
                Files.Add(Obj);
            }
            sr.Close();
            f.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameCol = textBox1.Text, s1 = textBox1.Text;
             NameCol = textBox1.Text+ Data_type.SelectedItem.ToString();
            dataGridView1.Columns.Add(s1, NameCol);
            if(textBox1.Equals(""))
                button1.Enabled = false;
          else
               button1.Enabled = true;
            textBox1.Text = "";

        }

        private void AddData_Click(object sender, EventArgs e)
        {
 
            

        }

        private void Thename_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
       bool Flag = true;
            if (dataGridView1.ColumnCount != 0 && dataGridView1.RowCount > 1 )
            {
                string file = FileName.Text + ".xml"; //take file name from user 
                string Document = FileName.Text;
                int rows = dataGridView1.RowCount;
                int col = dataGridView1.ColumnCount;
               
                if (Files.Count != 0) //check that list of file not empty
                    for (int i = 0; i < Files.Count; i++)
                        if (Files[i] == Document)
                        {
                            Flag = false;
                            break;
                        }
                bool found = true;

                for (int i = 0; i < rows - 1; i++) // check if cell empty
                    for (int j = 0; j < col; j++)
                        if (String.IsNullOrEmpty(dataGridView1.Rows[i].Cells[j].Value as String))
                        {
                            MessageBox.Show("Complete Data Please !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            found = false;
                        }      
                if (found)
                {
                    if (Flag) //if file name don't exist creat new file 
                    {
                        XmlWriter write = XmlWriter.Create(file);
                        write.WriteStartDocument();
                        write.WriteStartElement(Document);
                        for (int i = 0; i < rows - 1; i++)
                        {
                            write.WriteStartElement("Record");
                            for (int j = 0; j < col; j++)
                            {
                                string ColName = dataGridView1.Columns[j].HeaderText; //get name of columan put it in file
                                string s = dataGridView1.Rows[i].Cells[j].Value.ToString(); //get data in each cell
                                write.WriteStartElement(ColName);
                                write.WriteString(s);
                                write.WriteEndElement(); // close Of data

                            }

                            write.WriteEndElement();
                        }
                        write.WriteEndDocument();
                        write.Close();
                        Files.Add(Document); // add the name of fle in list 
                        FileStream f = new FileStream("Files_name.txt", FileMode.Append); //put file nam
                        StreamWriter sw = new StreamWriter(f);
                        sw.WriteLine(Document);
                        sw.Close();
                        f.Close();
                        dataGridView1.Rows.Clear(); //clear all rows in datagridview
                        dataGridView1.Columns.Clear(); //clear all columan in datagridview
                        FileName.Text = String.Empty;
                    }
                    else
                        MessageBox.Show("Enter New File Name ","Invalid File Name",MessageBoxButtons.OK,MessageBoxIcon.Hand); // erorr Message
                                                  // FileName.Text = String.Empty;

                }

            }

            else
                MessageBox.Show("Invalid input data","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Avg_Click(object sender, EventArgs e)
        {

        }

        private void Min_Click(object sender, EventArgs e)
        {

        }

        private void Max_Click(object sender, EventArgs e)
        {

        }

        private void Count_Click(object sender, EventArgs e)
        {

        }

        private void FileName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FileName.Text)&&dataGridView1.ColumnCount != 0) //to be button save disable if textbox empty
                button2.Enabled = false;
            else
                button2.Enabled = true;

        }

  

        private void button3_Click(object sender, EventArgs e)
        {
            Old o = new Old();
            this.Hide();
            o.Show();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) //to be button add disable  if not selected item
                button1.Enabled = false;
            else
                button1.Enabled = true;
            //if (textBox1.Equals(""))
            //    button1.Enabled = false;
            //else
            //    button1.Enabled = true;
        }

        private void NewData_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Hide();
            F.Show();
        }
    }
}
 