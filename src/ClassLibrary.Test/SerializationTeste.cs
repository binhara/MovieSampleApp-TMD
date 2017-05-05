using System.Collections.Generic;
using ClassLibrary.Data;
using NUnit.Framework;

namespace ClassLibrary.Test
{
    [TestFixture]
    public class SerializationTest
    {
       

        [Test]
        public void Deserialize()
        {
            const string json = @"{
	            ""id"": ""123"",
	            ""title"": ""Godfather"",
	            ""original_title"": ""Godfather"",
	            ""adult"": ""false""
            }";

            var movie = json.ToObject<Movie>();
            Assert.NotNull(movie);
            Assert.AreEqual(123, movie.Id);
            Assert.AreEqual("Godfather", movie.Title);
            Assert.AreEqual("Godfather", movie.OriginalTitle);
            Assert.AreEqual(false, movie.IsAdult);
        }

        [Test]
        public void TestMovieAllGenre()
        {
            var movie = new Movie(){Genres = new List<Genre>()};
            movie.Genres.Add(new Genre() {Id = 1, Name = "Romance"});
            movie.Genres.Add(new Genre() {Id = 1, Name = "Action"});

            Assert.AreEqual("Romance Action ", movie.AllGenres);
        }

        [Test]
        public void TestMovieAllGenreNull()
        {
            var movie = new Movie();
            movie.Genres = null;
            Assert.AreEqual("Genre not found", movie.AllGenres);
        }


        [Test]
        public void TestMoviePosterURL()
        {
            var movie = new Movie(){PosterPath = "1234.jpg"};
            Assert.AreEqual("https://image.tmdb.org/t/p/w500/1234.jpg", movie.PosterUrl);
        }

    }

}
