namespace jmmodul9.Controllers;

using Microsoft.AspNetCore.Mvc;
using jmmodul9.Models;


  [ApiController]
  [Route("api/[controller]")]
  public class MoviesController : ControllerBase
  {
      // Static list untuk menyimpan data movies (tidak menggunakan database)
      private static List<Movie> _movies = new List<Movie>
      {
          new Movie(
              "The Shawshank Redemption",
              "Frank Darabont",
              new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" },
              "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
          ),
          new Movie(
              "The Godfather",
              "Francis Ford Coppola",
              new List<string> { "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton" },
              "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."
          ),
          new Movie(
              "The Dark Knight",
              "Christopher Nolan",
              new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine" },
              "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
          )
      };

      /// <summary>
      /// GET /api/Movies - Mengembalikan semua movies
      /// </summary>
      /// <returns>List of all movies</returns>
      [HttpGet]
      public ActionResult<IEnumerable<Movie>> GetMovies()
      {
          return Ok(_movies);
      }

      /// <summary>
      /// GET /api/Movies/{id} - Mengembalikan movie berdasarkan index
      /// </summary>
      /// <param name="id">Index of the movie (0-based)</param>
      /// <returns>Movie at specified index</returns>
      [HttpGet("{id}")]
      public ActionResult<Movie> GetMovie(int id)
      {
          if (id < 0 || id >= _movies.Count)
          {
              return NotFound($"Movie with index {id} not found.");
          }

          return Ok(_movies[id]);
      }

      /// <summary>
      /// POST /api/Movies - Menambahkan movie baru
      /// </summary>
      /// <param name="movie">Movie object to add</param>
      /// <returns>Created movie</returns>
      [HttpPost]
      public ActionResult<Movie> PostMovie(Movie movie)
      {
          if (movie == null)
          {
              return BadRequest("Movie cannot be null.");
          }

          // Validasi basic
          if (string.IsNullOrWhiteSpace(movie.Title))
          {
              return BadRequest("Movie title is required.");
          }

          if (string.IsNullOrWhiteSpace(movie.Director))
          {
              return BadRequest("Movie director is required.");
          }

          // Ensure Stars list is not null
          if (movie.Stars == null)
          {
              movie.Stars = new List<string>();
          }

          _movies.Add(movie);

          // Return created movie with its index
          int newIndex = _movies.Count - 1;
          return CreatedAtAction(nameof(GetMovie), new { id = newIndex }, movie);
      }

      /// <summary>
      /// DELETE /api/Movies/{id} - Menghapus movie berdasarkan index
      /// </summary>
      /// <param name="id">Index of the movie to delete (0-based)</param>
      /// <returns>No content if successful</returns>
      [HttpDelete("{id}")]
      public IActionResult DeleteMovie(int id)
      {
          if (id < 0 || id >= _movies.Count)
          {
              return NotFound($"Movie with index {id} not found.");
          }

          var movieToDelete = _movies[id];
          _movies.RemoveAt(id);

          return Ok(new { 
              message = $"Movie '{movieToDelete.Title}' has been deleted successfully.",
              deletedMovie = movieToDelete
          });
      }

      /// <summary>
      /// GET /api/Movies/count - Mengembalikan jumlah total movies
      /// </summary>
      /// <returns>Total count of movies</returns>
      [HttpGet("count")]
      public ActionResult<int> GetMoviesCount()
      {
          return Ok(new { count = _movies.Count });
      }
  }
