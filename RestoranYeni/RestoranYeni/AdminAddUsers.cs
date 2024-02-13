using CafeShopManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestoranYeni
{
    public partial class AdminAddUsers : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\restoran.mdf;Integrated Security=True;Connect Timeout = 30");

        public AdminAddUsers()
        {
            InitializeComponent();
            displayAddUsersData();
        }


        public void displayAddUsersData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = usersData.usersListData();

            dataGridView1.DataSource = listData;
        }

        public bool emptyFields()
        {
            if (adminAddUsers_username.Text == "" || adminAddUsers_password.Text == ""
                || adminAddUsers_role.Text == "" || adminAddUsers_status.Text == ""
                || adminAddUsers_imageView.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
        {

            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();


                        string selectUsern = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand checkUsern = new SqlCommand(selectUsern, connect))
                        {
                            checkUsern.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                            DataTable table = new DataTable();
                            adapter.Fill(table);


                            if (table.Rows.Count >= 1)
                            {
                                string usern = adminAddUsers_username.Text.Substring(0, 1).ToUpper() + adminAddUsers_username.Text.Substring(1);
                                MessageBox.Show(usern + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, profile_image, role, status, date_reg)" +
                                    "VALUES(@usern, @pass, @image, @role, @status, @date)";
                                DateTime today = DateTime.Today;

                                string path = Path.Combine(@"C:\Users\Admin\Desktop\İleri Nesne Tabanlı Programlama Ödev\RestoranYeni\RestoranYeni\User_Directory\"
                                 + adminAddUsers_username.Text.Trim() + ".jpg");

                                string directroyPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directroyPath))
                                {
                                    Directory.CreateDirectory(directroyPath);

                                }
                                File.Copy(adminAddUsers_imageView.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", today);
                                    cmd.ExecuteNonQuery();
                                    clearFields();
                                    MessageBox.Show("Başarılı", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    displayAddUsersData();  
                                }

                              

                            }


                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }


        private int id = 0;

        private void adminAddUsers_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png|*.jpg;*.png)";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    adminAddUsers_imageView.ImageLocation = imagePath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            //  userData.ID = (int)reader["id"];
            // userData.Username = reader["username"].ToString();
            // userData.Password = reader["password"].ToString();
            //  userData.Role = reader["role"].ToString();
            //  userData.Status = reader["status"].ToString();
            // userData.Image = reader["profile_image"].ToString();
            // userData.DateRegistered = reader["date_reg"].ToString();

            id = (int)row.Cells[0].Value;
            adminAddUsers_username.Text = row.Cells[1].Value.ToString();
            adminAddUsers_password.Text = row.Cells[2].Value.ToString();
            adminAddUsers_role.Text = row.Cells[3].Value.ToString();
            adminAddUsers_status.Text = row.Cells[4].Value.ToString();
            string imagePath = row.Cells[5].Value.ToString();




            //burada kütüphane çalışıyor veya çalışmıyor kütüphane sanırsam artık auto düzenliyor 
            
        //    try
        //    {
         //       if (imagePath != null)
         //       {
         //           adminAddUsers_imageView.Image=Image.FromFile(imagePath);
         //       }
          //      else
          //      {
            //        adminAddUsers_imageView.Image = null;
           //     }
        //    }catch  (Exception ex)
        //    {
         //       MessageBox.Show("no image ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }




            // burada sıkıntı var 
             //       if (imagePath != null)
          //  {
          //      adminAddUsers_imageView.Image = Image.FromFile(imagePath);
           // }
        //    else
          //  {
          //     adminAddUsers_imageView.Image = null;
          //  }











        }

        private void adminAddUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure want to update" + adminAddUsers_username.Text.Trim()
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    

                if(result==DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE users SET username =@usern,password=@pass, role=@role, status=@status WHERE id= @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {

                                cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();
                                MessageBox.Show("Updated Succesfully", "Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                displayAddUsersData();
                            }







                        }
                        catch (Exception ex)
                        {
                         
                            MessageBox.Show("Connection Failed"+ ex,"error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                



            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void clearFields()
        {
            adminAddUsers_username.Text = "";
            adminAddUsers_password.Text = "";
            adminAddUsers_role.SelectedIndex = -1;
            adminAddUsers_status.SelectedIndex = -1;
            adminAddUsers_imageView.Image = null;
        }

        
        private void adminAddUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        
        private void adminAddUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure want to delete" + adminAddUsers_username.Text.Trim()
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM users WHERE id=@id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {

                               
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();
                                MessageBox.Show("Deleted Succesfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayAddUsersData();
                            }







                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Connection Failed" + ex, "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }




            }
        }
    }
















}

