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

namespace Haloween_Challenge
{
    public partial class FilmDetails : Form
    {
        private string connectionStringClient = "Server=127.0.0.1;Database=sakila;Uid=client;Pwd=$3cr3t3t";
        private string connectionStringStaff = "Server=127.0.0.1;Database=sakila;Uid=staff;Pwd=$up3r$3cr3t";
        Films _selectedFilm;

        public FilmDetails(Films selectedFilm)
        {
            // ToDo: BONUS points: Don’t write any code to access the database in this class.
            //EXTRA BONUS points: Show actors in the film.
            List<Films> films = new List<Films>();
            MySqlConnection con = new MySqlConnection(connectionStringClient);

            InitializeComponent();
            _selectedFilm = selectedFilm;

            string sql = $"select f.title, f.description, f.length, f.rating, c.name as name, l.name as namel from sakila.film as f inner join film_category as fc on f.film_id = fc.film_id inner join category as c on c.category_id = fc.category_id inner join language as l on f.language_id = l.language_id where f.film_id = {selectedFilm.film_id}";

            films = con.Query<Films>(sql).ToList();
            Films film = films.FirstOrDefault();

            DescriptionLabel.Text = film.description;
            TitleLabel.Text = film.title;
            CategoryLabel.Text = film.name;
            LanguajeLabel.Text = film.namel;
            RatingLabel.Text = film.rating;
            DurationLabel.Text = film.length;
        }
    }
}
