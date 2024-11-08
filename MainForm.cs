using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EQRental
{
    public partial class MainForm : Form
    {
        private bool isCobEquTypeFilled = false;
        private bool isCobHireFromFilled = false;
        private bool isCobReturnToFilled = false;

        private System.Windows.Forms.SortOrder sortOrder = System.Windows.Forms.SortOrder.Ascending;
        private int sortColumn = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //点击事件-列表排序
            listRentRec.ColumnClick += ListRentRec_ColumnClick;
            //初始化还回时间为NULL
            dateTimePickerReturn.Checked = false;
            dateTimePickerReturn.CustomFormat = " ";
        }

        //加载设备种类下拉列表方法
        private void ComboBox1_Click(object sender, EventArgs e)
        {
            string query = "SELECT TypeName FROM EquipmentType";
            SQL.FillComboBoxWithQuery(cobEquType, query);
            isCobEquTypeFilled = true;

        }

        //加载来源店下拉列表方法
        private void cobHireFrom_Click(object sender, EventArgs e)
        {
            string query = "SELECT BranchName FROM Branch";
            SQL.FillComboBoxWithQuery(cobHireFrom, query);
            isCobHireFromFilled = true;
        }

        //加载还回店下拉列表方法
        private void cobReturnTo_Click(object sender, EventArgs e)
        {
            string query = "SELECT BranchName FROM Branch";
            SQL.FillComboBoxWithQuery(cobReturnTo, query);
            isCobReturnToFilled = true;
        }

        //展示所有订单方法
        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Rent_Rec";
            SQL.FillListViewWithQuery(listRentRec, query);
        }

        //按条件搜索方法
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string typeName = cobEquType.Text;
            DateTime? startTime = dateTimePickerStart.Checked ? (DateTime?)dateTimePickerStart.Value : null;
            DateTime? timeReturn = dateTimePickerReturn.Checked ? (DateTime?)dateTimePickerReturn.Value : null;
            string hireFrom = cobHireFrom.Text;
            string returnTo = cobReturnTo.Text;
            string customerEmail = txtEmail.Text;

            SQL.FillListViewWithSearch(listRentRec, typeName, startTime, timeReturn, hireFrom, returnTo, customerEmail);
        }

        //把还回时间改为空值
        private void dateTimePickerReturn_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerReturn.Checked)
            {
                dateTimePickerReturn.CustomFormat = "yyyy/MM/dd";
            }
            else
            {
                dateTimePickerReturn.CustomFormat = " ";
            }
        }

        //判断检查框是否被勾选
        private void dateTimePickerReturn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                dateTimePickerReturn.Checked = false;
            }
        }

        //列表排序方法
        private void ListRentRec_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                sortOrder = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                sortOrder = sortOrder == System.Windows.Forms.SortOrder.Ascending ? System.Windows.Forms.SortOrder.Descending : System.Windows.Forms.SortOrder.Ascending;
            }

            listRentRec.ListViewItemSorter = new ListViewItemComparer(e.Column, sortOrder);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            // 获取文本框和下拉列表的值
            string equipmentType = txtBookEquType.Text.Trim();
            string branchName = cobBookBranch.Text.Trim();

            // 构建查询
            string query = "SELECT EquipmentID, TypeName, BranchName, purchaseDate " +
                           "FROM Equipment " +
                           "WHERE available = 1 ";

            if (!string.IsNullOrEmpty(equipmentType))
            {
                query += "AND TypeName LIKE @TypeName ";
            }
            if (!string.IsNullOrEmpty(branchName))
            {
                query += "AND BranchName LIKE @BranchName ";
            }

            query += "ORDER BY purchaseDate DESC";

            // 创建数据库连接和命令
            using (SqlConnection con = new SqlConnection(@"Data Source=AS-LAPTOP\SQLEXPRESS;Database=EQRental;User Id=gz56;Password=753698;"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // 添加参数
                if (!string.IsNullOrEmpty(equipmentType))
                {
                    cmd.Parameters.AddWithValue("@TypeName", "%" + equipmentType + "%");
                }
                if (!string.IsNullOrEmpty(branchName))
                {
                    cmd.Parameters.AddWithValue("@BranchName", "%" + branchName + "%");
                }

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // 清空列表视图
                        listBookResult.Items.Clear();

                        // 读取查询结果并添加到列表视图中
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["EquipmentID"].ToString());
                            item.SubItems.Add(reader["TypeName"].ToString());
                            item.SubItems.Add(reader["BranchName"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["purchaseDate"]).ToString("yyyy-MM-dd"));
                            listBookResult.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error：" + ex.Message);
                }
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void cobBookBranch_Click(object sender, EventArgs e)
        {
            string query = "SELECT BranchName FROM Branch";
            SQL.FillComboBoxWithQuery(cobBookBranch, query);
        }

        private void txtBookEmail_TextChanged(object sender, EventArgs e)
        {
            // 获取邮箱地址
            string email = txtBookEmail.Text.Trim();

            // 构建查询
            string query = "SELECT fname, sname, phone FROM Customer WHERE Email = @Email";

            // 创建数据库连接和命令
            using (SqlConnection con = new SqlConnection(@"Data Source=AS-LAPTOP\SQLEXPRESS;Database=EQRental;User Id=gz56;Password=753698;"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // 添加参数
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 填充文本框
                            txtBookFname.Text = reader["fname"].ToString();
                            txtBookLname.Text = reader["sname"].ToString();
                            txtBookPhone.Text = reader["phone"].ToString();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error：" + ex.Message);
                }
            }
        }

        private void txtBookPhone_TextChanged(object sender, EventArgs e)
        {
            // 获取电话
            string phone = txtBookPhone.Text.Trim();

            // 构建查询
            string query = "SELECT fname, sname, email FROM Customer WHERE phone = @phone";

            // 创建数据库连接和命令
            using (SqlConnection con = new SqlConnection(@"Data Source=AS-LAPTOP\SQLEXPRESS;Database=EQRental;User Id=gz56;Password=753698;"))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // 添加参数
                cmd.Parameters.AddWithValue("@phone", phone);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 填充文本框
                            txtBookFname.Text = reader["fname"].ToString();
                            txtBookLname.Text = reader["sname"].ToString();
                            txtBookEmail.Text = reader["email"].ToString();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error：" + ex.Message);
                }
            }
        }

        private void listBookResult_DoubleClick(object sender, EventArgs e)
        {
            if (listBookResult.SelectedItems.Count > 0)
            {
                // 获取选中的设备 ID
                string equipmentID = listBookResult.SelectedItems[0].SubItems[0].Text;

                // 检查设备是否已经存在于 listCart 中
                foreach (ListViewItem item in listCart.Items)
                {
                    if (item.SubItems[0].Text == equipmentID)
                    {
                        MessageBox.Show("It has already been added.");
                        return;
                    }
                }

                // 构建查询
                string query = "SELECT Equipment.EquipmentID, Equipment.TypeName, Equipment.BranchName, EquipmentType.ratePerHour " +
                               "FROM Equipment " +
                               "JOIN EquipmentType ON Equipment.TypeName = EquipmentType.TypeName " +
                               "WHERE Equipment.EquipmentID = @EquipmentID";

                // 创建数据库连接和命令
                using (SqlConnection con = new SqlConnection(@"Data Source=AS-LAPTOP\SQLEXPRESS;Database=EQRental;User Id=gz56;Password=753698;"))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // 添加参数
                    cmd.Parameters.AddWithValue("@EquipmentID", equipmentID);

                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 创建 ListViewItem 并填充查询结果
                                ListViewItem item = new ListViewItem(reader["EquipmentID"].ToString());
                                item.SubItems.Add(reader["TypeName"].ToString());
                                item.SubItems.Add(reader["BranchName"].ToString());
                                item.SubItems.Add(reader["ratePerHour"].ToString());

                                // 将结果添加到 listCart
                                listCart.Items.Add(item);
                            }
                            else
                            {
                                MessageBox.Show("404 Not Found :( ");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error：" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a equipment");
            }


        }

        private bool isAllSelected = false; // 用于跟踪选择状态

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (isAllSelected)
            {
                // 取消选择所有项
                foreach (ListViewItem item in listCart.Items)
                {
                    item.Checked = false;
                }
                isAllSelected = false; // 更新选择状态
            }
            else
            {
                // 选择所有项
                foreach (ListViewItem item in listCart.Items)
                {
                    item.Checked = true;
                }
                isAllSelected = true; // 更新选择状态
            }
        }

        private void btnCartDelete_Click(object sender, EventArgs e)
        {
            // 创建一个列表，用于存储要删除的项
            List<ListViewItem> itemsToDelete = new List<ListViewItem>();

            // 遍历 listCart 中的所有项
            foreach (ListViewItem item in listCart.Items)
            {
                // 如果项被选中，则添加到 itemsToDelete 列表中
                if (item.Checked)
                {
                    itemsToDelete.Add(item);
                }
            }

            // 从 listCart 中删除所有被选中的项
            foreach (ListViewItem item in itemsToDelete)
            {
                listCart.Items.Remove(item);
            }

            // 更新 isAllSelected 标志变量
            isAllSelected = false;
        }

        // 用于验证邮箱格式的辅助方法
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidPhone(string phone)
        {
            try
            {
                string pattern = @"^[0-9\-]+$";
                // 使用正则表达式进行匹配
                Regex regex = new Regex(pattern);
                return regex.IsMatch(phone);
            }
            catch
            {
                return false;
            }
        }

        private void btnBookSubmit_Click(object sender, EventArgs e)
        {
            // 1. 检查输入字段
            string email = txtBookEmail.Text.Trim();
            string phone = txtBookPhone.Text.Trim();
            string fname = txtBookFname.Text.Trim();
            string lname = txtBookLname.Text.Trim();

            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email.");
                return;
            }

            if (string.IsNullOrEmpty(phone) || !IsValidPhone(phone))
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

            if (string.IsNullOrEmpty(fname))
            {
                MessageBox.Show("Please enter a first name.");
                return;
            }

            if (string.IsNullOrEmpty(lname))
            {
                MessageBox.Show("Please enter a last name.");
                return;
            }

            // 4. 检查日期和时间
            DateTime startDateTime;
            if (dtpStartDate.Checked && dtpStartTime.Checked)
            {
                startDateTime = dtpStartDate.Value.Date + dtpStartTime.Value.TimeOfDay;
            }
            else if (dtpStartDate.Checked && !dtpStartTime.Checked)
            {
                startDateTime = dtpStartDate.Value.Date + DateTime.Now.TimeOfDay;
            }
            else if (!dtpStartDate.Checked && dtpStartTime.Checked)
            {
                startDateTime = DateTime.Now.Date + dtpStartTime.Value.TimeOfDay;
            }
            else
            {
                startDateTime = DateTime.Now;
            }

            // 6. 检查客户是否存在
            using (SqlConnection con = new SqlConnection(@"Data Source=AS-LAPTOP\SQLEXPRESS;Database=EQRental;User Id=gz56;Password=753698;"))
            {
                con.Open();
                SqlCommand checkCustomerCmd = new SqlCommand("SELECT COUNT(*) FROM Customer WHERE Email = @Email", con);
                checkCustomerCmd.Parameters.AddWithValue("@Email", email);
                int customerCount = (int)checkCustomerCmd.ExecuteScalar();

                if (customerCount == 0)
                {
                    // 插入新客户
                    SqlCommand insertCustomerCmd = new SqlCommand("INSERT INTO Customer (Email, fname, sname, phone) VALUES (@Email, @Fname, @Lname, @Phone)", con);
                    insertCustomerCmd.Parameters.AddWithValue("@Email", email);
                    insertCustomerCmd.Parameters.AddWithValue("@Fname", fname);
                    insertCustomerCmd.Parameters.AddWithValue("@Lname", lname);
                    insertCustomerCmd.Parameters.AddWithValue("@Phone", phone);
                    insertCustomerCmd.ExecuteNonQuery();
                }

                bool hasCheckedItems = false;
                foreach (ListViewItem item in listCart.Items)
                {
                    if (item.Checked)
                    {
                        hasCheckedItems = true;
                        break;
                    }
                }

                if (!hasCheckedItems)
                {
                    MessageBox.Show("Please select at least one item.");
                    return;
                }

                // 开始事务
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    foreach (ListViewItem item in listCart.Items)
                    {
                        if (item.Checked)
                        {
                            string equipmentID = item.SubItems[0].Text;
                            string branchName = item.SubItems[2].Text;

                            // 7. 更新设备状态
                            //if (startDateTime.Date <= DateTime.Now.Date)
                            //{
                            SqlCommand updateEquipmentCmd = new SqlCommand("UPDATE Equipment SET available = 0 WHERE EquipmentID = @EquipmentID", con, transaction);
                            updateEquipmentCmd.Parameters.AddWithValue("@EquipmentID", equipmentID);
                            updateEquipmentCmd.ExecuteNonQuery();
                            //}

                            // 8. 插入 Rental 表
                            SqlCommand insertRentalCmd = new SqlCommand("INSERT INTO Rental (startTime, hireFrom, CustomerEmail) OUTPUT INSERTED.RentalID VALUES (@StartTime, @HireFrom, @CustomerEmail)", con, transaction);
                            insertRentalCmd.Parameters.AddWithValue("@StartTime", startDateTime);
                            insertRentalCmd.Parameters.AddWithValue("@HireFrom", branchName);
                            insertRentalCmd.Parameters.AddWithValue("@CustomerEmail", email);
                            int rentalID = (int)insertRentalCmd.ExecuteScalar();

                            // 9. 插入 rentEquipment 表
                            SqlCommand insertRentEquipmentCmd = new SqlCommand("INSERT INTO rentEquipment (rEquipmentID, rRentalID, returnTime, returnTo) VALUES (@EquipmentID, @RentalID, NULL, NULL)", con, transaction);
                            insertRentEquipmentCmd.Parameters.AddWithValue("@EquipmentID", equipmentID);
                            insertRentEquipmentCmd.Parameters.AddWithValue("@RentalID", rentalID);
                            insertRentEquipmentCmd.ExecuteNonQuery();

                            // 10. 删除 listCart 中的行
                            listCart.Items.Remove(item);
                        }
                    }

                    // 提交事务
                    transaction.Commit();
                    MessageBox.Show("Booking submitted successfully.");
                }
                catch (Exception ex)
                {
                    // 回滚事务
                    transaction.Rollback();
                    MessageBox.Show("Error during booking submission: " + ex.Message);
                }
            }

            // 11. 调用 btnBookSearch_Click 方法
            btnBookSearch_Click(sender, e);

        }

        private void btnReturnSearch_Click(object sender, EventArgs e)
        {
            // 获取输入值
            string rentalID = txtReturnRentalID.Text.Trim();
            string equipmentID = txtReturnEquID.Text.Trim();
            string email = txtReturnEmail.Text.Trim();
            string phone = txtReturnPhone.Text.Trim();

            // 检查是否至少有一个输入值
            //if (string.IsNullOrEmpty(rentalID) && string.IsNullOrEmpty(equipmentID) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(phone))
            //{
            //    MessageBox.Show("Please enter at least one search criterion.");
            //    return;
            //}

            // 构建查询参数
            int? rentalIDParam = string.IsNullOrEmpty(rentalID) ? (int?)null : int.Parse(rentalID);
            int? equipmentIDParam = string.IsNullOrEmpty(equipmentID) ? (int?)null : int.Parse(equipmentID);
            string emailParam = string.IsNullOrEmpty(email) ? null : email;
            string phoneParam = string.IsNullOrEmpty(phone) ? null : phone;

            // 创建数据库连接和命令
            using (SqlConnection con = new SqlConnection(@"Data Source=AS-LAPTOP\SQLEXPRESS;Database=EQRental;User Id=gz56;Password=753698;"))
            using (SqlCommand cmd = new SqlCommand("Return_Query", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // 添加参数
                cmd.Parameters.AddWithValue("@rRentalID", rentalIDParam ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@rEquipmentID", equipmentIDParam ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", emailParam ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@phone", phoneParam ?? (object)DBNull.Value);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // 清空 listViewReturnResult
                        listViewReturnResult.Items.Clear();

                        if (reader.HasRows)
                        {
                            // 读取查询结果并添加到 listViewReturnResult 中
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["rRentalID"].ToString());
                                item.SubItems.Add(reader["rEquipmentID"].ToString());
                                item.SubItems.Add(reader["TypeName"].ToString());
                                item.SubItems.Add(reader["hireFrom"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["startTime"]).ToString("yyyy-MM-dd HH:mm"));
                                item.SubItems.Add(reader["ratePerHour"].ToString());
                                item.SubItems.Add(reader["RentHours"].ToString());
                                item.SubItems.Add(reader["Cost"].ToString());
                                item.SubItems.Add(reader["CustomerEmail"].ToString());
                                item.SubItems.Add(reader["phone"].ToString());
                                listViewReturnResult.Items.Add(item);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No results found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during search: " + ex.Message);
                }
            }

        }

        private void cobReturnBranch_Click(object sender, EventArgs e)
        {
            string query = "SELECT BranchName FROM Branch";
            SQL.FillComboBoxWithQuery(cobReturnBranch, query);
        }

        private void timepickReturn_ValueChanged(object sender, EventArgs e)
        {
            // 获取输入值
            string rentalID = txtReturnRentalID.Text.Trim();
            string equipmentID = txtReturnEquID.Text.Trim();
            string email = txtReturnEmail.Text.Trim();
            string phone = txtReturnPhone.Text.Trim();
            DateTime returnTime = timepickReturn.Value;

            // 检查是否至少有一个输入值
            //if (string.IsNullOrEmpty(rentalID) && string.IsNullOrEmpty(equipmentID) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(phone))
            //{
            //    MessageBox.Show("Please enter at least one search criterion.");
            //    return;
            //}

            // 构建查询参数
            int? rentalIDParam = string.IsNullOrEmpty(rentalID) ? (int?)null : int.Parse(rentalID);
            int? equipmentIDParam = string.IsNullOrEmpty(equipmentID) ? (int?)null : int.Parse(equipmentID);
            string emailParam = string.IsNullOrEmpty(email) ? null : email;
            string phoneParam = string.IsNullOrEmpty(phone) ? null : phone;

            // 创建数据库连接和命令
            using (SqlConnection con = new SqlConnection(@"Data Source=AS-LAPTOP\SQLEXPRESS;Database=EQRental;User Id=gz56;Password=753698;"))
            using (SqlCommand cmd = new SqlCommand("Return_Query", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // 添加参数
                cmd.Parameters.AddWithValue("@rRentalID", rentalIDParam ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@rEquipmentID", equipmentIDParam ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", emailParam ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@phone", phoneParam ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@returnTime", returnTime);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // 清空 listViewReturnResult
                        listViewReturnResult.Items.Clear();

                        if (reader.HasRows)
                        {
                            // 读取查询结果并添加到 listViewReturnResult 中
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["rRentalID"].ToString());
                                item.SubItems.Add(reader["rEquipmentID"].ToString());
                                item.SubItems.Add(reader["TypeName"].ToString());
                                item.SubItems.Add(reader["hireFrom"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["startTime"]).ToString("yyyy-MM-dd HH:mm"));
                                item.SubItems.Add(reader["ratePerHour"].ToString());
                                item.SubItems.Add(reader["RentHours"].ToString());
                                item.SubItems.Add(reader["Cost"].ToString());
                                item.SubItems.Add(reader["CustomerEmail"].ToString());
                                item.SubItems.Add(reader["phone"].ToString());
                                listViewReturnResult.Items.Add(item);
                            }
                        }
                        //else
                        //{
                        //    MessageBox.Show("No results found.");
                        //}
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during search: " + ex.Message);
                }
            }
        }
        // ItemChecked 事件处理程序
        private void listViewReturnResult_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            CalculateTotalCost();
        }

        // 计算总花费的方法
        private void CalculateTotalCost()
        {
            decimal totalCost = 0;

            foreach (ListViewItem item in listViewReturnResult.Items)
            {
                if (item.Checked)
                {
                    decimal fee = decimal.Parse(item.SubItems[7].Text);
                    totalCost += fee;
                }
            }

            lbTotalCost.Text = totalCost.ToString("F2");
        }

        private void btbSubmitReturn_Click(object sender, EventArgs e)
        {
            // 检查 cobReturnBranch 的值
            if (string.IsNullOrEmpty(cobReturnBranch.Text.Trim()))
            {
                MessageBox.Show("Please select a branch to return to");
                return;
            }

            string returnBranch = cobReturnBranch.Text.Trim();
            DateTime returnTime = timepickReturn.Checked ? timepickReturn.Value : DateTime.Now;

            // 创建一个列表来存储选中的 EquipmentID
            List<int> selectedEquipmentIDs = new List<int>();

            // 从 listViewReturnResult 中读取被选中的所有行的 EquipmentID (在第二列)
            foreach (ListViewItem item in listViewReturnResult.Items)
            {
                if (item.Checked)
                {
                    int equipmentID = int.Parse(item.SubItems[1].Text);
                    selectedEquipmentIDs.Add(equipmentID);
                }
            }

            if (selectedEquipmentIDs.Count == 0)
            {
                MessageBox.Show("Please select at least one equipment to return");
                return;
            }

            // 创建数据库连接和命令
            using (SqlConnection con = new SqlConnection(@"Data Source=AS-LAPTOP\SQLEXPRESS;Database=EQRental;User Id=gz56;Password=753698;"))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        foreach (int equipmentID in selectedEquipmentIDs)
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE rentEquipment SET returnTime = @ReturnTime, returnTo = @ReturnTo WHERE rEquipmentID = @EquipmentID", con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ReturnTime", returnTime);
                                cmd.Parameters.AddWithValue("@ReturnTo", returnBranch);
                                cmd.Parameters.AddWithValue("@EquipmentID", equipmentID);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // 提交事务
                        transaction.Commit();
                        MessageBox.Show("Returned successfully");
                    }
                    catch (Exception ex)
                    {
                        // 回滚事务
                        transaction.Rollback();
                        MessageBox.Show("Error" + ex.Message);
                    }
                }
            }

            timepickReturn_ValueChanged(sender, e);
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            // 清空根节点的所有子节点
            treeViewSummary.Nodes["TreeRootUniCus"].Nodes.Clear();
            treeViewSummary.Nodes["TreeRootAvgDuration"].Nodes.Clear();
            treeViewSummary.Nodes["TreeRootMostPopularEquType"].Nodes.Clear();
            treeViewSummary.Nodes["TreeRootMonthlyRental"].Nodes.Clear();
            treeViewSummary.Nodes["TreeRootTotalIncByType"].Nodes.Clear();

            // 创建数据库连接
            using (SqlConnection con = new SqlConnection(@"Data Source=AS-LAPTOP\SQLEXPRESS;Database=EQRental;User Id=gz56;Password=753698;"))
            {
                con.Open(); // 打开数据库连接

                // 查询并插入 UniqueCustomerCount_2023
                InsertUniqueCustomerCount(con);

                // 查询并插入 AvgRentalDurationByEquType_2023
                InsertAvgRentalDuration(con);

                // 查询并插入 MostPopularEqu_2023
                InsertMostPopularEqu(con);

                // 查询并插入 MonthlyRentalCounts_2023
                InsertMonthlyRentalCounts(con);

                // 查询并插入 TotalIncomeByEquType_2023
                InsertTotalIncomeByEquType(con);
            }

            // 展开所有根节点
            treeViewSummary.ExpandAll();
            treeViewSummary.Nodes[0].EnsureVisible();
        }

        // 查询并插入 UniqueCustomerCount_2023 的数据
        private void InsertUniqueCustomerCount(SqlConnection con)
        {
            string query = "SELECT BranchName, UniqueCustomerCount FROM UniqueCustomerCount_2023";
            SqlCommand cmd = new SqlCommand(query, con);
            TreeNode rootNode = treeViewSummary.Nodes["TreeRootUniCus"];

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string branchName = reader["BranchName"].ToString();
                    string uniqueCustomerCount = reader["UniqueCustomerCount"].ToString();

                    // 创建 BranchName 节点
                    TreeNode branchNode = new TreeNode(branchName);
                    // 创建 UniqueCustomerCount 节点并添加到 BranchName 节点
                    TreeNode countNode = new TreeNode(uniqueCustomerCount);
                    branchNode.Nodes.Add(countNode);

                    // 将 BranchName 节点添加到根节点
                    rootNode.Nodes.Add(branchNode);
                }
            }
        }
        // 查询并插入 AvgRentalDurationByEquType_2023 的数据
        private void InsertAvgRentalDuration(SqlConnection con)
        {
            string query = "SELECT TypeName, AvgDuration FROM AvgRentalDurationByEquType_2023";
            SqlCommand cmd = new SqlCommand(query, con);
            TreeNode rootNode = treeViewSummary.Nodes["TreeRootAvgDuration"];

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string typeName = reader["TypeName"].ToString();
                    string avgDuration = reader["AvgDuration"].ToString();

                    // 创建 TypeName 节点
                    TreeNode typeNode = new TreeNode(typeName);
                    // 创建 AvgDuration 节点并添加到 TypeName 节点
                    TreeNode durationNode = new TreeNode(avgDuration);
                    typeNode.Nodes.Add(durationNode);

                    // 将 TypeName 节点添加到根节点
                    rootNode.Nodes.Add(typeNode);
                }
            }
        }

        // 查询并插入 MostPopularEqu_2023 的数据
        private void InsertMostPopularEqu(SqlConnection con)
        {
            string query = "SELECT BranchName, TypeName FROM MostPopularEqu_2023";
            SqlCommand cmd = new SqlCommand(query, con);
            TreeNode rootNode = treeViewSummary.Nodes["TreeRootMostPopularEquType"];

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string branchName = reader["BranchName"].ToString();
                    string typeName = reader["TypeName"].ToString();

                    // 创建 BranchName 节点
                    TreeNode branchNode = new TreeNode(branchName);
                    // 创建 TypeName 节点并添加到 BranchName 节点
                    TreeNode typeNode = new TreeNode(typeName);
                    branchNode.Nodes.Add(typeNode);

                    // 将 BranchName 节点添加到根节点
                    rootNode.Nodes.Add(branchNode);
                }
            }
        }

        // 查询并插入 MonthlyRentalCounts_2023 的数据
        private void InsertMonthlyRentalCounts(SqlConnection con)
        {
            string query = "SELECT Monthly, TotalRentals FROM MonthlyRentalCounts_2023";
            SqlCommand cmd = new SqlCommand(query, con);
            TreeNode rootNode = treeViewSummary.Nodes["TreeRootMonthlyRental"];

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string monthly = reader["Monthly"].ToString();
                    string totalRentals = reader["TotalRentals"].ToString();

                    // 创建 Monthly 节点
                    TreeNode monthNode = new TreeNode(monthly);
                    // 创建 TotalRentals 节点并添加到 Monthly 节点
                    TreeNode rentalsNode = new TreeNode(totalRentals);
                    monthNode.Nodes.Add(rentalsNode);

                    // 将 Monthly 节点添加到根节点
                    rootNode.Nodes.Add(monthNode);
                }
            }
        }

        // 查询并插入 TotalIncomeByEquType_2023 的数据
        private void InsertTotalIncomeByEquType(SqlConnection con)
        {
            string query = "SELECT TypeName, TotalIncome FROM TotalIncomeByEquType_2023";
            SqlCommand cmd = new SqlCommand(query, con);
            TreeNode rootNode = treeViewSummary.Nodes["TreeRootTotalIncByType"];

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string typeName = reader["TypeName"].ToString();
                    string totalIncome = reader["TotalIncome"].ToString();

                    // 创建 TypeName 节点
                    TreeNode typeNode = new TreeNode(typeName);
                    // 创建 TotalIncome 节点并添加到 TypeName 节点
                    TreeNode incomeNode = new TreeNode(totalIncome);
                    typeNode.Nodes.Add(incomeNode);

                    // 将 TypeName 节点添加到根节点
                    rootNode.Nodes.Add(typeNode);
                }
            }
        }

        private void txtReturnRentalID_TextChanged(object sender, EventArgs e)
        {
            string input = txtReturnRentalID.Text;

            // 仅保留数字字符
            string numericInput = new string(input.Where(char.IsDigit).ToArray());

            // 如果过滤后的内容与原内容不一致，则更新文本框内容
            if (numericInput != input)
            {
                txtReturnRentalID.Text = numericInput;

                // 将光标移到文本框的末尾
                txtReturnRentalID.SelectionStart = numericInput.Length;
            }
        }

        private void txtReturnEquID_TextChanged(object sender, EventArgs e)
        {
            string input = txtReturnEquID.Text;

            // 仅保留数字字符
            string numericInput = new string(input.Where(char.IsDigit).ToArray());

            // 如果过滤后的内容与原内容不一致，则更新文本框内容
            if (numericInput != input)
            {
                txtReturnEquID.Text = numericInput;

                // 将光标移到文本框的末尾
                txtReturnEquID.SelectionStart = numericInput.Length;
            }
        }
        // Summary树的事件
        private void treeViewSummary_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Btn_Expend_Click(object sender, EventArgs e)
        {
            // 检查第一个根节点是否已经展开
            if (treeViewSummary.Nodes.Count > 0 && treeViewSummary.Nodes[0].IsExpanded)
            {
                // 如果第一个根节点是展开的，则收起所有节点
                treeViewSummary.CollapseAll();
            }
            else
            {
                // 如果第一个根节点是收起的，则展开所有节点
                treeViewSummary.ExpandAll();
                treeViewSummary.Nodes[0].EnsureVisible();
            }
        }

        private void Btn_SummaryExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Save TreeView Content"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    // 写入TreeView的内容到选定的文件
                    ExportTreeView(treeViewSummary.Nodes, writer);
                }

                MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExportTreeView(TreeNodeCollection nodes, StreamWriter writer, string indent = "")
        {
            foreach (TreeNode node in nodes)
            {
                writer.WriteLine(indent + node.Text);
                if (node.Nodes.Count > 0)
                {
                    ExportTreeView(node.Nodes, writer, indent + "\t");
                }
            }
        }

    }
}
