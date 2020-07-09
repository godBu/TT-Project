using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace mvc_app.Models
{
    public class MovieRepository
    {
        private string connectionString = @"User ID = sa;Password = 6yrtDfngiL93Bg;Initial catalog= Movies;Data Source=localhost, 1433;  ";

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }


        public IEnumerable<Movie> GetAllMovies()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"EXEC MovieViewAll";
                dbConnection.Open();
                return dbConnection.Query<Movie>(sQuery);
            }
        }


        public Movie GetByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM MovieModel WHERE MovieID=@Id";
                dbConnection.Open();
                return dbConnection.Query<Movie>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }


        public void Add(Movie newMovie)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO MovieModel(MovieID, Title, Genre, Rating, IMDbscore) VALUES(@MovieID, @Title, @Genre, @Rating, @IMDbscore)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, newMovie);
            }
        }


        public void UpdateMovies(Movie newMovie)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"EXEC MovieUpdate @MovieID = @MovieID, @Title = @Title, @Genre = @Genre, @Rating = @Rating, @IMDbScore = @IMDbScore";
                dbConnection.Open();
                dbConnection.Query(sQuery, newMovie);
            }
        }


        public void DeleteByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"EXEC DeleteMovieByID @MovieID=@id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = id });
            }
        }
    }
}