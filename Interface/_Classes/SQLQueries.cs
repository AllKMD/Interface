using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Interface._Classes
{
    public class SQLQueries
    {
        private int sqlUserid;
        SqlConnection con;
        

        public SQLQueries()
        {

            con = new SqlConnection(@"Server=mssql5.webio.pl,2401;Database=dawidhost_quickAlle;Uid=dawidhost_maciek;Password=asfoihPass1#;");
        }
        public void createUser(string userLogin)//dodaje uzytkownika do bazy
        {
            con.Open();
            SqlCommand insertCommand;
            string commandString = @"INSERT INTO Users(userlogin)
                                    VALUES('" + userLogin + "');";

            insertCommand = new SqlCommand(commandString, con);
            insertCommand.ExecuteNonQuery();
            con.Close();
        }
        public int getUserid(string userLogin)//zwraca id uzytkownika
        {
            con.Open();
            SqlCommand insertCommand; int returnVal = -1;
            string commandString = @"SELECT userid FROM Users WHERE userlogin='" + userLogin + "';";

            insertCommand = new SqlCommand(commandString, con);
            SqlDataReader reader = insertCommand.ExecuteReader();
            while (reader.Read())
            {
                returnVal = Convert.ToInt32(reader["userid"]);
            }
            reader.Close();
            con.Close();
            return returnVal;

        }
        public string getUserName(int userId)//zwraca nazwe uzytkownika
        {
            con.Open();
            SqlCommand insertCommand; string returnVal = "NOT_FOUND";
            string commandString = @"SELECT userlogin FROM Users WHERE userid=" + Convert.ToString(userId) + ";";

            insertCommand = new SqlCommand(commandString, con);
            SqlDataReader reader = insertCommand.ExecuteReader();
            while (reader.Read())
            {
                returnVal = Convert.ToString(reader["userlogin"]);
            }
            reader.Close();
            con.Close();
            return returnVal;
        }
        public List<feedbackTemplateStruct> getFeedbackTemplates(int userid)//pobiera szablony komentarzy uzytkonika
        {
            con.Open();
            List<feedbackTemplateStruct> list = new List<feedbackTemplateStruct>();

            SqlCommand selectCommand; feedbackTemplateStruct temp;
            string commandString = @"SELECT * FROM FeedbackTemplates
                                        WHERE userid=" + Convert.ToString(userid) + ";";
            selectCommand = new SqlCommand(commandString, con);
            SqlDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                temp = new feedbackTemplateStruct();
                temp.userid = Convert.ToInt32(reader["userid"]);
                temp.type = Convert.ToInt32(reader["type"]);
                temp.templateid = Convert.ToInt32(reader["templateid"]);
                temp.content = Convert.ToString(reader["content"]);
                temp.header = Convert.ToString(reader["header"]);

                list.Add(temp);
            }
            reader.Close();
            con.Close();
            return list;
        }
        public void addFeedbackTemplate(feedbackTemplateStruct temp)//dodaje szablon
        {
            con.Open();
            SqlCommand insertCommand;
            string commandString = @"INSERT INTO FeedbackTemplates(userid,content,header,type)
                                    VALUES(" + Convert.ToString(temp.userid) + ",'"
                                            + Convert.ToString(temp.content) + "','"
                                            + Convert.ToString(temp.header) + "',"
                                            + Convert.ToString(temp.type) + ");";

            insertCommand = new SqlCommand(commandString, con);
            insertCommand.ExecuteNonQuery();
            con.Close();
        }
        public void deleteFeedbackTemplate(int templateId)//usuwa szablon
        {
            con.Open();
            SqlCommand insertCommand;
            string commandString = @"DELETE FeedbackTemplates 
                                         WHERE templateid=" + Convert.ToString(templateId) + ";";

            insertCommand = new SqlCommand(commandString, con);
            insertCommand.ExecuteNonQuery();
            con.Close();
        }
        public void modifyFeedbackTemplate(feedbackTemplateStruct temp)//modyfikuje szablon
        {
            con.Open();
            SqlCommand insertCommand;
            string commandString = @"UPDATE FeedbackTemplates
                                         SET header='"+temp.header+"', content='"+temp.content+"', type="+Convert.ToString(temp.type)+" WHERE templateid=" + temp.templateid + ";";


            insertCommand = new SqlCommand(commandString, con);
            insertCommand.ExecuteNonQuery();
            con.Close();
        }

    }
}