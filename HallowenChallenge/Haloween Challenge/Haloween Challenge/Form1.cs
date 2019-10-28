using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

// @author: Fabio Cardoso
namespace Haloween_Challenge
{
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
            staff.Enabled = false;
            films.Enabled = false;
            LogoutButton.Hide();
            
        }
        private string connectionStringClient = "Server=127.0.0.1;Database=sakila;Uid=client;Pwd=$3cr3t3t";
        private string connectionStringStaff = "Server=127.0.0.1;Database=sakila;Uid=staff;Pwd=$up3r$3cr3t";

        private void FindButton_Click(object sender, EventArgs e)
        {
            // ToDO: BONUS points: Match whole word search.

            MySqlConnection con = new MySqlConnection(connectionStringClient);

            List<Films> films = new List<Films>();

            String sql = $"SELECT film_id, title FROM sakila.film where title like '%{SearchTextBox.Text}%'";

            films = con.Query<Films>(sql).ToList();

            FilmsListBox.DataSource = films;
            FilmsListBox.DisplayMember = "title";

            SearchBox.Text = string.Empty;

           // con.Close;
        }
        
        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FilmsListBox_DoubleClick(object sender, EventArgs e)
        {
            Films selectedFilm = FilmsListBox.SelectedItem as Films;
            FilmDetails filmDetails = new FilmDetails(selectedFilm);

            DialogResult result = filmDetails.ShowDialog(this);

            filmDetails.Dispose();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserTextBox.Text))
            {
                MessageBox.Show("Enter the user name!");

            }
            else if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Enter the Password!");

            }
            else if (UserTextBox.Text == ("guest") && PasswordTextBox.Text == ("£123"))
            {
                films.Enabled = true;
                LoginButton.Hide();
                LogoutButton.Show();
                UserTextBox.Enabled = false;
                PasswordTextBox.Enabled = false;
            }
            else if ((UserTextBox.Text == ("Mike")) || (UserTextBox.Text == ("Jon")) && PasswordTextBox.Text == ("£456"))
            {
                films.Enabled = true;
                staff.Enabled = true;
                LoginButton.Hide();
                LogoutButton.Show();
                UserTextBox.Enabled = false;
                PasswordTextBox.Enabled = false;
                pictureStaff.Hide();

            }
            else
            {
                WrongText.Text = "Wrong credentials";
                UserTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
            }
            
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text == ("guest") && PasswordTextBox.Text == ("£123"))
            {
                films.Enabled = false;
                LogoutButton.Hide();
                LoginButton.Show();
                UserTextBox.Enabled = true;
                PasswordTextBox.Enabled = true;
            }
            else if ((UserTextBox.Text == ("Mike")) || (UserTextBox.Text == ("Jon")) && PasswordTextBox.Text == ("£456"))
            {
                films.Enabled = false;
                staff.Enabled = false;
                LogoutButton.Hide();
                LoginButton.Show();
                UserTextBox.Enabled = true;
                PasswordTextBox.Enabled = true;
                pictureStaff.Show();
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionStringStaff);

            string sql = $"update staff set email = '{EmailTextBox.Text}' where staff_id = (select staff_id from staff where username = '{UserTextBox.Text}'";

            var rowsAfected = con.Execute(sql);

            if (rowsAfected == 1)
            {
                MessageBox.Show("Email has ben Updated", "User MAnager", MessageBoxButtons.OK);
            }

        }
    }
}
