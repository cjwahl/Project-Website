using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Timers;
using System.Web;
using System.Windows.Forms;
using Twilio;

namespace MyProject_Website.Models
{
    public class InsertInfo
    {
        public static void InsertText(string message, string time)
        {
            var cs = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO SMS_Messages (Message, Date) VALUES (@message, @time)", connection);
                    cmd.Parameters.Add("@message", SqlDbType.VarChar, 160);
                    cmd.Parameters.Add("@time", SqlDbType.VarChar, 20);
                    cmd.Parameters["@message"].Value = message;
                    cmd.Parameters["@time"].Value = time;

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debugger.Log(9, "Error", ex.ToString());
                }
            }
        }
    }

    public class Text
    {
        public static void SetTimer()
        {
            var aTimer = new System.Timers.Timer(15000);
            aTimer.Elapsed += CheckText;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        public static void CheckText(object source, ElapsedEventArgs e)
        {
            var textDump = GetTextContent();

            foreach (var item in textDump)
            {
                if (item.time >= DateTime.Now.AddSeconds(-30) && item.time <= DateTime.Now)
                {
                    MessageBox.Show(item.message);

                    var cs = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

                    using (SqlConnection connection = new SqlConnection(cs))
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("DELETE FROM SMS_Messages WHERE Message = @message", connection);
                            command.Parameters.Add("@message", SqlDbType.VarChar, 160);
                            command.Parameters["@message"].Value = item.message;
                            command.CommandType = CommandType.Text;

                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Debugger.Log(9, "Error", ex.ToString());
                        }
                    }
                }
            }
        }

        public Text(DataRow row)
        {
            this.time = DateTime.Parse(row["Date"].ToString());
            this.message = row["Message"].ToString();
        }

        public static IEnumerable<Text> GetTextContent()
        {
            var cs = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            var Dbdata = new List<Text>();

            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM SMS_Messages", connection);

                    SqlDataReader dbReader = command.ExecuteReader();
                    DataSet DBset = new DataSet();
                    DataTable DBtable = new DataTable();

                    DBtable.Load(dbReader);

                    foreach (DataRow row in DBtable.Rows)
                    {
                        Dbdata.Add(new Text(row));
                    }
                }
                catch (Exception ex)
                {
                    Debugger.Log(9, "Error", ex.ToString());
                }
            }
            return Dbdata;
        }

        public string message { get; set; }

        public DateTime time { get; set; }

        public int phoneNumber { get; set; }
    }
}