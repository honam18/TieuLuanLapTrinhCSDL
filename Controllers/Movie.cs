using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TieuLuanLapTrinhCSDL.Models;

namespace TieuLuanLapTrinhCSDL.Controllers
{
    class Movie
    {
        public Movie(string iD, string name, string desc, float time
            , DateTime starDate, DateTime endDate, string country
            , string director, int yearProduction, byte[] poster)
        {
            this.ID = iD;
            this.Name = name;
            this.Desc = desc;
            this.Time = time;
            this.StartDate = starDate;
            this.EndDate = endDate;
            this.Country = country;
            this.Director = director;
            this.YearProduction = yearProduction;
            this.Poster = poster;
        }
        public Movie(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.Name = row["TenPhim"].ToString();
            this.Desc = row["MoTa"].ToString();
            this.Time = float.Parse(row["ThoiLuong"].ToString());
            this.StartDate = (DateTime)row["NgayKhoiChieu"];
            this.EndDate = (DateTime)row["NgayKetThuc"];
            this.Country = row["SanXuat"].ToString();
            this.Director = row["DaoDien"].ToString();
            this.YearProduction = (int)row["NamSX"];
            if (row["ApPhich"].ToString() == "")
                this.Poster = null;
            else
                this.Poster = (byte[])row["ApPhich"];
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public float Time { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Country { get; set; }
        public int YearProduction { get; set; }
        public string Director { get; set; }
        public byte[] Poster { get; set; }
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static List<Movie> GetListMovieByDate(DateTime date)
        {
            List<Movie> listMovie = new List<Movie>();
            DataTable data = DataProvider.ExecuteQuery("select * from Phim where @Date <= NgayKetThuc", new object[] { date });
            foreach (DataRow row in data.Rows)
            {
                Movie movie = new Movie(row);
                listMovie.Add(movie);
            }
            return listMovie;
        }

        public static List<Movie> GetListMovie()
        {
            List<Movie> listMovie = new List<Movie>();
            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM Phim");
            foreach (DataRow row in data.Rows)
            {
                Movie movie = new Movie(row);
                listMovie.Add(movie);
            }
            return listMovie;
        }

        public static DataTable GetMovie()
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetMovie");
        }

        public static bool InsertMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_InsertMovie @id , @tenPhim , @moTa , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX , @apPhich ", new object[] { id, name, desc, length, startDate, endDate, productor, director, year, image });
            return result > 0;
        }

        public static bool UpdateMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_UpdateMovie @id , @tenPhim , @moTa , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX , @apPhich ", new object[] { id, name, desc, length, startDate, endDate, productor, director, year, image });
            return result > 0;
        }

        public static bool DeleteMovie(string id)
        {
            DataProvider.ExecuteNonQuery("DELETE dbo.PhanLoaiPhim WHERE idPhim = '" + id + "'");
            DataProvider.ExecuteNonQuery("DELETE dbo.DinhDangPhim WHERE idPhim = '" + id + "'");

            MovieByGenre.DeleteMovie_GenreByMovieID(id);
            int result = DataProvider.ExecuteNonQuery("DELETE dbo.Phim WHERE id = '" + id + "'");
            return result > 0;
        }

        public static Movie GetMovieByID(string id)
        {
            Movie movie = null;
            DataTable data = DataProvider.ExecuteQuery("SELECT * FROM dbo.Phim WHERE id = '" + id + "'");
            foreach (DataRow item in data.Rows)
            {
                movie = new Movie(item);
                return movie;
            }
            return movie;
        }
    }
}
