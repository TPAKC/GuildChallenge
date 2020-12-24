using Microsoft.Office.Core;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GuildChallenge
{
    public partial class Form1 : Form
    {
        Excel.Application ex = new Excel.Application();
        string server, database, uid, password, connectionString, port;
        public Form1()
        {
            InitializeComponent();
             //ex.Workbooks.Open(@"C:\Users\bakay\source\repos\GuildChallenge\GuildChallenge\Resources\Resource.xlsx");
            ex.Workbooks.Open(@"C:\Program Files\GuildChallenge\Resource.xlsx");

            server = "papayafarm-dev.quartsoft.com";
            database = "dev_library";
            uid = "dev_library_readonly";
            password = "oY2 _Haht1Og_7c";
            port = 3310
            string connectionString;
            connectionString = "SERVER=" + server + "; PORT = "+port+";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            SqlConnection mycon = new SqlConnection(connectionString);
            mycon.Open();
            SqlCommand cmd = new SqlCommand("select * from world;", mycon);
            SqlDataReader reader = cmd.ExecuteReader();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alias.Visible = true;
            alias_text.Visible = true;
            level.Visible = true;
            level_text.Visible = true;
            tier.Visible = true;
            tier_text.Visible = true;
            exp.Visible = true;
            exp_text.Visible = true;
            coin.Visible = true;
            coin_text.Visible = true;
            point.Visible = true;
            point_text.Visible = true;

            string id_res = id_text.Text.ToString();
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            for (int i = 2; i <= 720; i++)
            {
                Excel.Range id = sheet.Cells[i, 1] as Excel.Range;
                if (id.Value2.ToString() == id_res)
                {
                    //alias
                    Excel.Range alias = sheet.Cells[i, 2] as Excel.Range;
                    alias_text.Text = alias.Value2.ToString();
                    //level
                    Excel.Range level = sheet.Cells[i, 3] as Excel.Range;
                    level_text.Text = level.Value2.ToString();
                    //tier
                    Excel.Range tier_range = sheet.Cells[i, 4] as Excel.Range;
                    int tier = Convert.ToInt32(tier_range.Value2);
                    tier_text.Text = tier.ToString();
                    //coin
                    Excel.Range coin = sheet.Cells[i, 5] as Excel.Range;
                    coin_text.Text = (Math.Floor(coin.Value2 / 5) * Convert.ToInt32(capacity_text.Text)).ToString();
                    //type
                    Excel.Range type_range = sheet.Cells[i, 6] as Excel.Range;
                    //string type = type_range.Value2.ToString();
                    //time
                    int minutes = Convert.ToInt32(hours_text.Text) + Convert.ToInt32(minutes_text.Text);


                    //1-ый порядок
                    if (tier == 1 || tier == 2) //if (tier == 1 || (tier == 2 && type == "ingredient"))
                        {
                        exp_text.Text = "10";
                        if (minutes < 60) //0,5 - 1h
                        {
                            point_text.Text = "10";
                        }
                        else
                        if (minutes < 120) //1 - 2 h
                        {
                            point_text.Text = "14";
                        }
                        else
                        if (minutes < 240) //2 - 4 h
                        {
                            point_text.Text = "18";
                        }
                        else
                        if (minutes < 360) //4 - 6 h
                        {
                            point_text.Text = "22";
                        }
                    }

                    else
                    //2-ой порядок
                    if (tier == 2)
                    {
                        exp_text.Text = "15";
                        if (minutes < 60) //0,5 - 1h
                        {
                            point_text.Text = "16";
                        }
                        else
                        if (minutes < 120) //1 - 2 h
                        {
                            point_text.Text = "20";
                        }
                        else
                        if (minutes < 240) //2 - 4 h
                        {
                            point_text.Text = "24";
                        }
                        else
                        if (minutes < 360) //4 - 6 h
                        {
                            point_text.Text = "28";
                        }
                    }

                    else
                        //3-ий порядок
                        if (tier <= 4)
                    {
                        exp_text.Text = "20";
                        if (minutes < 60) //0,5 - 1h
                        {
                            point_text.Text = "22";
                        }
                        else
                        if (minutes < 120) //1 - 2 h
                        {
                            point_text.Text = "26";
                        }
                        else
                        if (minutes < 240) //2 - 4 h
                        {
                            point_text.Text = "30";
                        }
                        else
                        if (minutes < 360) //4 - 6 h
                        {
                            point_text.Text = "34";
                        }
                    }
                    else
                        //4-ый порядок
                        if (tier <= 9)
                    {
                        exp_text.Text = "25";
                        if (minutes < 60) //0,5 - 1h
                        {
                            point_text.Text = "28";
                        }
                        else
                        if (minutes < 120) //1 - 2 h
                        {
                            point_text.Text = "32";
                        }
                        else
                        if (minutes < 240) //2 - 4 h
                        {
                            point_text.Text = "36";
                        }
                        else
                        if (minutes < 360) //4 - 6 h
                        {
                            point_text.Text = "40";
                        }
                    }

                            break;
                        }
                    }
        }

        private void Give_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ex.Quit();
        }
    }
}
