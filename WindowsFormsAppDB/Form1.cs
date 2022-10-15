using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace WindowsFormsAppDB

{
    public partial class Form1 : Form
    {
        public static int ThreadS = 0, Value = 0;
        double time;
        DataTable g_totalTable;
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            g_totalTable = this.GetUser().Tables[0];
            g_totalTable = this.ToTableMilliseconds(g_totalTable);
            InitializeComponent();
        }

        public DataSet GetUser()//DB 연동 함수
        {
         
            string connectString = string.Format("Server={0};Database={1};Uid ={2};Pwd={3};",
            "192.168.245.1", "agv_db", "root", "1234");
            string sql = "select * from agv_table";
            DataSet ds = new DataSet();
            using (MySqlConnection conn = new MySqlConnection(connectString))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds);
            }
            return ds;
        }
      
        void timer()
        {
            while (true)
            {
                Thread.Sleep(100);
                time += 0.1;
                time = Math.Round(time, 3);
                lbTime.Text = time.ToString();
            }
        }

        Thread PlayThread, TimerThread;
        private void btn_play_Click(object sender, EventArgs e)
        {
            PlayThread = new Thread(PlayFunc);
            PlayThread.Start();
            PlayThread.IsBackground = true;
            TimerThread = new Thread(timer);
            TimerThread.Start();
            TimerThread.IsBackground=true;
        }

        void ChangColor(PictureBox a,  int b)
        {
             if(b == 0)
            {
                a.BackColor = Color.Red;
            }
            else
            {
                a.BackColor = Color.Green;
            }
          //  a.BackColor = b ? Color.Red : Color.Green;
        }

        void Sleep(int i, int Count, int Speed)
        {
            DataTable dt = this.g_totalTable;
            if (i == Count)
            {
                MessageBox.Show("끝 입니다.");
            }
            else
            {
                Int64 TotalT = (Int64)(dt.Rows[Count-1][4])-(Int64)(dt.Rows[i - 1][4]);
                TotalTime.Text = (TotalT.ToString());
                 Int64 strT1 = (Int64)(dt.Rows[i][4]);
                Int64 strT2 = (Int64)(dt.Rows[i - 1][4]);

                Int64 sleep = strT1 - strT2;
                Time.Text = sleep.ToString() + "m/s";

                Thread.Sleep(((int)sleep)/Speed);
            }
        }
        void ChangeUI(int i, int Count, int Speed)
        {
            DataTable dt = this.g_totalTable;
 
            X.Text = Convert.ToString(dt.Rows[i - 1][1]);
            Y.Text = Convert.ToString(dt.Rows[i - 1][2]);
            S.Text = Convert.ToString(dt.Rows[i - 1][3]);
           
            ChangColor(BF, (int)dt.Rows[i - 1][5]);
            ChangColor(BB, (int)dt.Rows[i - 1][6]);
            ChangColor(BR, (int)dt.Rows[i - 1][7]);
            ChangColor(BL, (int)dt.Rows[i - 1][8]);

            Start.Text = Convert.ToString(dt.Rows[i - 1][9]);
            Stop.Text = Convert.ToString(dt.Rows[i - 1][10]);
            EMR.Text = Convert.ToString(dt.Rows[i - 1][11]);
            Now.Text = i.ToString();

            Sleep(i, Count, Speed);
        }

        void PlayFunc() //play 버튼 누르면 실행
        {
            DataTable dt = this.g_totalTable;
            DataRow lastRow = dt.Rows[dt.Rows.Count - 1];

            int Count = Convert.ToInt32(lastRow[0]);//row 갯수
            Total.Text = Count.ToString();
            trackBar1.Maximum = Count;
            time = 0;
            Value = trackBar1.Value; 
            int Speed = Convert.ToInt32(textBox.Text);
            for (int i = Value + 1; i <= Count; i++)
            {
                ChangeUI(i, Count,Speed);
                if (trackBar1.Value >= i)
                {
                    trackBar1.Value--;
                }
                trackBar1.Value++;
            }
        }   

        public DataTable ToTableMilliseconds(DataTable table)// ms로 변환해주는 함수
        {
            DataTable newTable = table.Clone();
            newTable.Columns[4].DataType = typeof(Int64);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                long ms_time = ((DateTimeOffset)((DateTime)table.Rows[i].ItemArray[4])).ToUnixTimeMilliseconds();
                DataRow row = newTable.NewRow();
                int cnt = table.Rows[i].ItemArray.Count();

                for (int j = 0; j < cnt; j++)
                {
                    if (j != 4)
                    {
                        row.SetField(j, table.Rows[i].ItemArray[j]);
                    }
                }
                row.SetField(4, ms_time);
                newTable.Rows.Add(row);
            }
            return newTable;
        }

        private void btn_insert(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.g_totalTable;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DataTable dt = this.g_totalTable;
            DataRow lastRow = dt.Rows[dt.Rows.Count - 1];
            int Count = Convert.ToInt32(lastRow[0]);//row 갯수
            trackBar1.Maximum = Count - 1;

            //PlayStop();
            int i = trackBar1.Value;
            Value = trackBar1.Value;
            int Speed = Convert.ToInt32(textBox.Text);
            i++;
            PlayThread.Abort();
            PlayThread = new Thread(PlayFunc);
            PlayThread.IsBackground = true;
            PlayThread.Start();
            ChangeUI(i, Count, Speed);  
        }
   
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            ThreadS++;      
            PlayThread.Abort();
            TimerThread.Abort();
        }
    }
}