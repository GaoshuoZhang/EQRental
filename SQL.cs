using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EQRental
{
    internal class SQL
    {
        //generates the connection to the database
        public static SqlConnection con = new SqlConnection(@"Data Source=AS-LAPTOP\SQLEXPRESS;Database=EQRental;User Id=gz56;Password=753698;");
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader read;

        public static void executeQuery(string query)
        {
            try
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return;
            }
        }

 
        // Generates an SQL query based on the input
        public static void selectQuery(string query)
        {
            try
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                read = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return;
            }
        }

        public static void FillComboBoxWithQuery(ComboBox comboBox, string query)
        {
            try
            {
                comboBox.Items.Clear();
                selectQuery(query);

                if (read.HasRows)
                {
                    comboBox.Items.Add("");
                    while (read.Read())
                    {

                        comboBox.Items.Add(read[0].ToString());
                    }
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void FillListViewWithQuery(ListView listView, string query)
        {
            try
            {
                listView.Items.Clear();
                selectQuery(query);

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        ListViewItem item = new ListViewItem(read["rRentalID"].ToString());
                        item.SubItems.Add(read["rEquipmentID"].ToString());
                        item.SubItems.Add(read["TypeName"].ToString());
                        item.SubItems.Add(read["startTime"].ToString());
                        item.SubItems.Add(read["returnTime"].ToString());
                        item.SubItems.Add(read["hireFrom"].ToString());
                        item.SubItems.Add(read["returnTo"].ToString());
                        item.SubItems.Add(read["CustomerEmail"].ToString());
                        listView.Items.Add(item);
                    }
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void FillListViewWithSearch(ListView listView, string typeName, DateTime? timeStart, DateTime? timeReturn, string hireFrom, string returnTo, string customerEmail)
        {
            try
            {
                listView.Items.Clear();
                List<string> conditions = new List<string>();

                if (!string.IsNullOrEmpty(typeName))
                {
                    conditions.Add("TypeName = @TypeName");
                }

                if (timeStart.HasValue && timeReturn.HasValue)
                {
                    conditions.Add("startTime >= @StartTime");
                    conditions.Add("returnTime <= @ReturnTime");
                }

                if (!timeStart.HasValue && timeReturn.HasValue)
                {
                    conditions.Add("returnTime <= @ReturnTime");
                }

                if (timeStart.HasValue && !timeReturn.HasValue)
                {
                    conditions.Add("startTime >= @StartTime");
                }

                if (!timeStart.HasValue && !timeReturn.HasValue)
                {
                    conditions.Add("returnTime is NULL");
                }

                if (!string.IsNullOrEmpty(hireFrom))
                {
                    conditions.Add("hireFrom = @HireFrom");
                }

                if (!string.IsNullOrEmpty(returnTo))
                {
                    conditions.Add("returnTo = @ReturnTo");
                }

                if (!string.IsNullOrEmpty(customerEmail))
                {
                    conditions.Add("CustomerEmail = @CustomerEmail");
                }

                string query = "SELECT * FROM Rent_Rec";

                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                SqlCommand command = new SqlCommand(query, con);

                if (!string.IsNullOrEmpty(typeName))
                {
                    command.Parameters.AddWithValue("@TypeName", typeName);
                }

                if (timeStart.HasValue)
                {
                    command.Parameters.AddWithValue("@StartTime", timeStart.Value);
                }

                if (timeReturn.HasValue)
                {
                    command.Parameters.AddWithValue("@ReturnTime", timeReturn.Value);
                }

                if (!string.IsNullOrEmpty(hireFrom))
                {
                    command.Parameters.AddWithValue("@HireFrom", hireFrom);
                }

                if (!string.IsNullOrEmpty(returnTo))
                {
                    command.Parameters.AddWithValue("@ReturnTo", returnTo);
                }

                if (!string.IsNullOrEmpty(customerEmail))
                {
                    command.Parameters.AddWithValue("@CustomerEmail", customerEmail);
                }

                con.Close();
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["rRentalID"].ToString());
                        item.SubItems.Add(reader["rEquipmentID"].ToString());
                        item.SubItems.Add(reader["TypeName"].ToString());
                        item.SubItems.Add(reader["startTime"].ToString());
                        item.SubItems.Add(reader["returnTime"].ToString());
                        item.SubItems.Add(reader["hireFrom"].ToString());
                        item.SubItems.Add(reader["returnTo"].ToString());
                        item.SubItems.Add(reader["CustomerEmail"].ToString());
                        listView.Items.Add(item);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
