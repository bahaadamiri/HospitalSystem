using System.Data;
using System.Data.SQLite;
namespace HospitalSystem


{
    public partial class Form1 : Form
    {
        //database variables
        SQLiteConnection con = new SQLiteConnection("Data Source=hospital_table.db;Version=3;");
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt;
        SQLiteDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void insert_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO patients (name,natID,bloodTyp,gender,residence)" + "VALUES (@name,@natID,@bloodTyp,@gender,@residence)";

            cmd.Parameters.AddWithValue("name", nameBox.Text);
            cmd.Parameters.AddWithValue("natID", natIDBox.Text);
            cmd.Parameters.AddWithValue("bloodTyp", bloodBox.Text);
            cmd.Parameters.AddWithValue("gender", (male.Checked) ? 1 : 0);
            cmd.Parameters.AddWithValue("residence", resBox.Text);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected == 0)
                MessageBox.Show("Error");
            else
                MessageBox.Show("Successfully Inserted");

            con.Close();


        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}