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
    public partial class Old : Form
    {
        public static List<string> column = new List<string>();//save file name
        public Old()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {/*To Enable Buttons*/
            Sum.Enabled = true;
            Min.Enabled = true;
            Max.Enabled = true;
            Avg.Enabled = true;
            Count.Enabled = true;

            if (string.IsNullOrEmpty(selected_item.SelectedText)) //to be button get index disable when load gradeview
                button1.Enabled = true ;
            else
                button1.Enabled =false;
            string fun = selected_item.SelectedItem.ToString();
            /*if (fun.Substring(fun.Length - 6, 6) == "String" || fun.Substring(fun.Length - 4, 4) == "Char")
            {   Sum.Enabled = false;
                Min.Enabled = false;
                Max.Enabled = false;
                Avg.Enabled = false;
                Count.Enabled = true;
            }
            else
            {
                Sum.Enabled = true;
                Min.Enabled = true;
                Max.Enabled = true;
                Avg.Enabled = true;;
                Count.Enabled = true; 
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilesName.SelectedText)) //to be disable if not select item
               Loads.Enabled = true;  
            else
               Loads.Enabled = false;
        }

        private void Old_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selected_item.SelectedText)) //to be button add disable when load gradeview
            {
                Sum.Enabled = false;
                Min.Enabled = false;
                Max.Enabled = false;
                Avg.Enabled = false;
                Count.Enabled = false;
            }
            else
            {
                Sum.Enabled = true;
                Min.Enabled = true;
                Max.Enabled = true;
                Avg.Enabled = true;
                Count.Enabled = true;

            }
            if (string.IsNullOrEmpty(FilesName.SelectedText)) //to be button load disable when load gradeview
                Loads.Enabled = false;
            else
                Loads.Enabled = true;

            if (string.IsNullOrEmpty(selected_item.SelectedText)) //to be button get index disable when load gradeview
                button1.Enabled = false;
            else
                button1.Enabled = true;
            FileStream f = new FileStream("Files_name.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);
            while (sr.Peek() != -1)
            {
                string Obj = (string)sr.ReadLine();
                FilesName.Items.Add(Obj);
            }
            sr.Close();
            f.Close();
            if (FilesName.Items.Count == 0)
                MessageBox.Show("No Files yet");
                
        }

        private void Loads_Click(object sender, EventArgs e)
        {
          
            selected_item.Items.Clear(); //clear all data from combo box 
             string s = FilesName.SelectedItem.ToString() +".xml"; //take file name from combobox and load it
            XmlReader file = XmlReader.Create(s, new XmlReaderSettings());
            DataSet Ds = new DataSet();
            Ds.ReadXml(file);
            dataGridView1.DataSource = Ds.Tables[0];
            int col = dataGridView1.ColumnCount, temp= dataGridView1.ColumnCount;
            for (int j = 0; j < col ; j++)
            {
                string ColName = dataGridView1.Columns[j].HeaderText; //get name of columan put it in file
                selected_item.Items.Add(ColName);
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            string s = selected_item.SelectedItem.ToString();//get the name of column want to do function 
            int index = dataGridView1.Columns[s].Index; //get the index of th column
            MessageBox.Show(index.ToString());
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            string Checkint = "" , Checkdouble = "", Checklfloat = "" , Checklonglong = "";
            string s = selected_item.SelectedItem.ToString(); //get the name of column want to do function 
            if (s.Length > 3)
            {
                 Checkint = s.Substring(s.Length - 3, 3);   // Get Int
            }
            if (s.Length > 6)
            {
                 Checkdouble = s.Substring(s.Length - 6, 6); // Get Double
            }
            if (s.Length > 5)
            {
                 Checklfloat = s.Substring(s.Length - 5, 5); // Get Float
            }
            if (s.Length > 9)
            {
                Checklonglong = s.Substring(s.Length - 9, 9);// Get LongLong
            }
            XmlDocument doc = new XmlDocument();
            doc.Load("Functions.xml");
            XmlNodeList Row = doc.GetElementsByTagName("Functions");
            bool Flag = false;
            for (int i  = 0; i < Row.Count;i++)
            {
                XmlNodeList child = Row[i].ChildNodes;
                for (int j = 0; j < child.Count; j++)
                {
                    if (child[j].Name == Sum.Text)
                    {
                        XmlNodeList Sums = child[j].ChildNodes;
                        for (int c = 0; c < Sums.Count; c++)
                        {
                            if (Sums[c].InnerText == Checkint)
                            {
                                Flag = true;
                                break;
                            }
                            if (Sums[c].InnerText == Checkdouble)
                            {
                                Flag = true;
                                break;
                            }
                            if (Sums[c].InnerText == Checklonglong)
                            {
                                Flag = true;
                                break;
                            }
                            if (Sums[c].InnerText == Checklfloat)
                            {
                                Flag = true;
                                break;
                            }
                        }// For Loop To Check DataType
                    } // Check Of Function TagName
                }// For Loop To Get Function TagName
            }
            if (Flag)
            {

                int sum = 0;
                int rows = dataGridView1.RowCount - 1;
                int index = dataGridView1.Columns[s].Index; //get the index of th column
                for (int i = 0; i < rows; ++i)
                {
                    string val = dataGridView1.Rows[i].Cells[index].Value.ToString();
                    bool isAlpha = true;
                    /*To Check If Content Have Char*/
                    for (int j = 0; j < val.Length; j++)
                        if (val[j] >= '0' && val[j] <= '9')
                            continue;
                        else
                            isAlpha = false;

                    if (isAlpha)
                    {
                        sum += Int32.Parse(val);
                    }
                    else
                    {
                        MessageBox.Show("Error Type of Data ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sum = 0;
                        break;
                    }
                }
                SumRes.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Error Operations Choose Another columns","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.RowCount-1;
            //MessageBox.Show("The Count of Data is  "+rows.ToString());
            CountRes.Text = rows.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Max_Click(object sender, EventArgs e)
        {
            string Checkint = "", Checkdouble = "", Checklfloat = "", Checklonglong = "";
            string s = selected_item.SelectedItem.ToString(); //get the name of column want to do function 
            if (s.Length > 3)
            {
                Checkint = s.Substring(s.Length - 3, 3);   // Get Int
            }
            if (s.Length > 6)
            {
                Checkdouble = s.Substring(s.Length - 6, 6); // Get Double
            }
            if (s.Length > 5)
            {
                Checklfloat = s.Substring(s.Length - 5, 5); // Get Float
            }
            if (s.Length > 9)
            {
                Checklonglong = s.Substring(s.Length - 9, 9);// Get LongLong
            }
            XmlDocument doc = new XmlDocument();
            doc.Load("Functions.xml");
            XmlNodeList Row = doc.GetElementsByTagName("Functions");
            bool Flag = false;
            for (int i = 0; i < Row.Count; i++)
            {
                XmlNodeList child = Row[i].ChildNodes;
                for (int j = 0; j < child.Count; j++)
                {
                    if (child[j].Name == Max.Text)
                    {
                        XmlNodeList MX = child[j].ChildNodes;
                        for (int c = 0; c < MX.Count; c++)
                        {
                            if (MX[c].InnerText == Checkint)
                            {
                                Flag = true;
                                break;
                            }
                            if (MX[c].InnerText == Checkdouble)
                            {
                                Flag = true;
                                break;
                            }
                            if (MX[c].InnerText == Checklonglong)
                            {
                                Flag = true;
                                break;
                            }
                            if (MX[c].InnerText == Checklfloat)
                            {
                                Flag = true;
                                break;
                            }
                        }// For Loop To Check DataType
                    } // Check Of Function TagName
                }// For Loop To Get Function TagName
            }

            if (Flag)
            {
                int max = 0;
                int rows = dataGridView1.RowCount - 1;
                int index = dataGridView1.Columns[s].Index; //get the index of th column
                for (int i = 0; i < rows; ++i)
                {
                    string val = dataGridView1.Rows[i].Cells[index].Value.ToString();
                    bool isAlpha = true;
                    /*To Check If Content Have Char*/
                    for (int j = 0; j < val.Length; j++)
                        if (val[j] >= '0' && val[j] <= '9')
                            continue;
                        else
                            isAlpha = false;

                    if (isAlpha)
                    {
                        int valu = Int32.Parse(val);
                        if (valu > max)
                            max = valu;
                    }
                    else
                    {
                        MessageBox.Show("Error Type of Data ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        max = 0;
                        break;
                    }
                }

                MaxRes.Text = max.ToString();
            }
            else
            {
                MessageBox.Show("Error Operations Choose Another Columns", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Min_Click(object sender, EventArgs e)
        {
            string Checkint = "", Checkdouble = "", Checklfloat = "", Checklonglong = "";
            string s = selected_item.SelectedItem.ToString(); //get the name of column want to do function 
            if (s.Length > 3)
            {
                Checkint = s.Substring(s.Length - 3, 3);   // Get Int
            }
            if (s.Length > 6)
            {
                Checkdouble = s.Substring(s.Length - 6, 6); // Get Double
            }
            if (s.Length > 5)
            {
                Checklfloat = s.Substring(s.Length - 5, 5); // Get Float
            }
            if (s.Length > 9)
            {
                Checklonglong = s.Substring(s.Length - 9, 9);// Get LongLong
            }
            XmlDocument doc = new XmlDocument();
            doc.Load("Functions.xml");
            XmlNodeList Row = doc.GetElementsByTagName("Functions");
            bool Flag = false;
            for (int i = 0; i < Row.Count; i++)
            {
                XmlNodeList child = Row[i].ChildNodes;
                for (int j = 0; j < child.Count; j++)
                {
                    if (child[j].Name == Min.Text)
                    {
                        XmlNodeList mn = child[j].ChildNodes;
                        for (int c = 0; c < mn.Count; c++)
                        {
                            if (mn[c].InnerText == Checkint)
                            {
                                Flag = true;
                                break;
                            }
                            if (mn[c].InnerText == Checkdouble)
                            {
                                Flag = true;
                                break;
                            }
                            if (mn[c].InnerText == Checklonglong)
                            {
                                Flag = true;
                                break;
                            }
                            if (mn[c].InnerText == Checklfloat)
                            {
                                Flag = true;
                                break;
                            }
                        }// For Loop To Check DataType
                    } // Check Of Function TagName
                }// For Loop To Get Function TagName
            }



            if (Flag)
            {
                int min = 1000000000;
                int rows = dataGridView1.RowCount - 1;
                int index = dataGridView1.Columns[s].Index; //get the index of th column
                for (int i = 0; i < rows; ++i)
                {
                    string val = dataGridView1.Rows[i].Cells[index].Value.ToString();
                 
                    
                    bool isAlpha = true;
                    /*To Check If Content Have Char*/
                    for (int j = 0; j < val.Length; j++)
                        if (val[j] >= '0' && val[j] <= '9')
                            continue;
                        else
                            isAlpha = false;
                    if (isAlpha)
                    {
                        int valu = Int32.Parse(val);
                        if (valu < min)
                            min = valu;
                    }
                    else
                    {
                        MessageBox.Show("Error Type of Data ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        min = 0;
                        break;
                    }

                }
                MinRes.Text = min.ToString();
            }
            else
            {
                MessageBox.Show("Error Operations Choose Another Columns", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Avg_Click(object sender, EventArgs e)
        {
            string Checkint = "", Checkdouble = "", Checklfloat = "", Checklonglong = "";
            string s = selected_item.SelectedItem.ToString(); //get the name of column want to do function 
            if (s.Length > 3)
            {
                Checkint = s.Substring(s.Length - 3, 3);   // Get Int
            }
            if (s.Length > 6)
            {
                Checkdouble = s.Substring(s.Length - 6, 6); // Get Double
            }
            if (s.Length > 5)
            {
                Checklfloat = s.Substring(s.Length - 5, 5); // Get Float
            }
            if (s.Length > 9)
            {
                Checklonglong = s.Substring(s.Length - 9, 9);// Get LongLong
            }
            XmlDocument doc = new XmlDocument();
            doc.Load("Functions.xml");
            XmlNodeList Row = doc.GetElementsByTagName("Functions");
            bool Flag = false;
            for (int i = 0; i < Row.Count; i++)
            {
                XmlNodeList child = Row[i].ChildNodes;
                for (int j = 0; j < child.Count; j++)
                {
                    if (child[j].Name == Avg.Text)
                    {
                        XmlNodeList avg = child[j].ChildNodes;
                        for (int c = 0; c < avg.Count; c++)
                        {
                            if (avg[c].InnerText == Checkint)
                            {
                                Flag = true;
                                break;
                            }
                            if (avg[c].InnerText == Checkdouble)
                            {
                                Flag = true;
                                break;
                            }
                            if (avg[c].InnerText == Checklonglong)
                            {
                                Flag = true;
                                break;
                            }
                            if (avg[c].InnerText == Checklfloat)
                            {
                                Flag = true;
                                break;
                            }
                        }// For Loop To Check DataType
                    } // Check Of Function TagName
                }// For Loop To Get Function TagName
            }

            if (Flag)
            {
                double sum = 0;
                double rows = dataGridView1.RowCount - 1;
                int index = dataGridView1.Columns[s].Index; //get the index of th column
                for (int i = 0; i < rows; ++i)
                {
                    string val = dataGridView1.Rows[i].Cells[index].Value.ToString();
                    /*To Check If Content Have Char*/
                    bool isAlpha = true;
                    for (int j = 0; j < val.Length; j++)
                        if (val[j] >= '0' && val[j] <= '9')
                            continue;
                        else
                            isAlpha = false;
                    if (isAlpha)
                    {
                        sum += Int32.Parse(val);
                    }
                    else
                    {
                        MessageBox.Show("Error Type of Data ", "Erorr", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                        sum = 0;
                        break;
                    }
                }

                double avg = sum / rows;
                AvgRes.Text = avg.ToString();
            }
            else
            {
                MessageBox.Show("Error Operations Choose Another Columns", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void selected_item_Click(object sender, EventArgs e)
        {
            SumRes.Text = "0";
            AvgRes.Text = "0";
            MaxRes.Text = "0";
            MinRes.Text = "0";
            CountRes.Text = "0";
        }

        private void Old_FormClosing(object sender, FormClosingEventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
