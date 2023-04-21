using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class dbHandler
    {
       static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=realestate;";
      
        MySqlConnection connection;
        public dbHandler() {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public int insertProperty(JObject propertyJson)
        {
            int i = -1;
            var cons = "INSERT INTO `broker`( `name`, `address`, `value`, `type`)" +
                " VALUES ('"+propertyJson.GetValue("name").ToString()+ "','"+propertyJson.GetValue("address").ToString()+ "','"+propertyJson.GetValue("value").ToString()+"','"+propertyJson.GetValue("type").ToString()+"')";
           i =  new MySqlCommand(cons,connection).ExecuteNonQuery();
            return i;
        }

        public void populateListing(FlowLayoutPanel f,JObject userdata)
        {
            MySqlCommand cmd = new MySqlCommand("select * from broker",connection);
            MySqlDataReader rd = cmd.ExecuteReader();
            JObject data;
            while (rd.Read())
            {
                data = new JObject();
                data.Add("id",rd.GetValue(0).ToString());
                data.Add("name", rd.GetValue(1).ToString());
                data.Add("address", rd.GetValue(2).ToString());
                data.Add("value", rd.GetValue(3).ToString());
                data.Add("image", rd.GetValue(4).ToString());
                data.Add("type", rd.GetValue(5).ToString());
                
                f.Controls.Add(new marketCard(data,userdata));
            }
            rd.Close();
        }

        public int buyproperty(marketCard m)
        {
            int t = -1;
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `owner`(`uemail`, `upass`, `pid`) VALUES ('"+m.uemail+"','"+m.upass+"',"+m.id+")", connection);
            t = cmd.ExecuteNonQuery();
            return t;
        }

        public JArray getOwnedProperty(JObject userData)
        {
            JArray jArray = new JArray();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM broker where id = ( SELECT pid FROM `owner` WHERE uemail = '"+userData.GetValue("email").ToString()+"' AND upass ='"+ userData.GetValue("email").ToString() + "')",connection);
            MySqlDataReader rd = cmd.ExecuteReader();

            JObject data;
                while (rd.Read())
                {

                    data = new JObject();
                    data.Add("id", rd.GetValue(0).ToString());
                    data.Add("name", rd.GetValue(1).ToString());
                    data.Add("address", rd.GetValue(2).ToString());
                    data.Add("value", rd.GetValue(3).ToString());
                    data.Add("image", rd.GetValue(4).ToString());
                    data.Add("type", rd.GetValue(5).ToString()); 
               // MessageBox.Show(data.ToString());
               jArray.Add(JToken.Parse(data.ToString()));            
            }

           // MessageBox.Show(jArray.ToString());

          return jArray;
        }

        public void sendFeedback(JObject data)
        {


        }

        public void close()
        {
            connection.Close();
        }
    }
}
