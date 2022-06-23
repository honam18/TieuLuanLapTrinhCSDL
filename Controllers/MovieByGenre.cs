using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TieuLuanLapTrinhCSDL.Models;

namespace TieuLuanLapTrinhCSDL.Controllers
{
    class MovieByGenre
    {
        public MovieByGenre(string movieID, string genre)
        {
            this.MovieID = movieID;
            this.Genre = genre;
        }
        public MovieByGenre(DataRow row)
        {
            this.MovieID = row["idPhim"].ToString();
            this.Genre = row["idTheLoai"].ToString();
        }
        public string MovieID { get; set; }

        public string Genre { get; set; }
        public static List<Genre> GetListGenreByMovieID(string id)
        {
            List<Genre> genreList = new List<Genre>();
            DataTable data = DataProvider.ExecuteQuery("EXEC USP_GetListGenreByMovie @idPhim", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Genre genre = new Genre(item);
                genreList.Add(genre);
            }
            return genreList;
        }

        public static void InsertMovie_Genre(string movieID, List<Genre> genreList)
        {
            foreach (Genre item in genreList)
            {
                string command = string.Format("INSERT dbo.PhanLoaiPhim (idPhim, idTheLoai) VALUES  ('{0}','{1}')", movieID, item.ID);
                DataProvider.ExecuteNonQuery(command);
            }
        }

        public static void UpdateMovie_Genre(string movieID, List<Genre> genreList)
        {
            DataProvider.ExecuteNonQuery("DELETE dbo.PhanLoaiPhim WHERE idPhim = '" + movieID + "'");
            foreach (Genre item in genreList)
            {
                string command = string.Format("INSERT dbo.PhanLoaiPhim (idPhim, idTheLoai) VALUES  ('{0}','{1}')", movieID, item.ID);
                DataProvider.ExecuteNonQuery(command);
            }
        }

        public static void DeleteMovie_GenreByMovieID(string movieID)
        {
            DataProvider.ExecuteNonQuery("DELETE dbo.PhanLoaiPhim WHERE idPhim = '" + movieID + "'");
        }
    }
}
