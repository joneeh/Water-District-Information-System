using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Water_District_Information_System
{
    public partial class loginWindow : Form
    {
        string sqlConnection = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;

        public static string first_name { get; set; }
        public static string last_name { get; set; }
        public static string position { get; set; }
        public static string user_type { get; set; }

        public loginWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            logInUser();
        }

        //Function for parameterized user login
        public void logInUser()
        {
            string query = "SELECT [username],[first_name],[last_name],[position],[user_type] FROM [dbo].[user_details] WHERE username = @username AND password = @password";
            using (SqlConnection sqlcon = new SqlConnection(sqlConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                {
                    cmd.Parameters.AddWithValue("@username", usernameField.Text);
                    cmd.Parameters.AddWithValue("@password", passwordField.Text);
                    sqlcon.Open();
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dtItem = new DataTable();
                        adp.Fill(dtItem);

                        if (dtItem.Rows.Count > 0)
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                //Get queried details
                                first_name = dr.GetValue(0).ToString();
                                last_name = dr.GetValue(2).ToString();
                                position = dr.GetValue(3).ToString();
                                user_type = dr.GetValue(4).ToString();

                                //Show WDIS Main Window Form
                                var waterDistrictInformationSystem = new waterDistrictInformationSystem();
                                waterDistrictInformationSystem.Show();

                                //Hides Login Window Form
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("User does not Exist");
                        }
                    }
                    sqlcon.Close();
                }
            }
        }

        private void loginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
