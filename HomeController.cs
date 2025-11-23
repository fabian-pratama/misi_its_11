using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello, welcome to my API!";
        }

        [HttpGet("hai")]

        public string Hai([FromQuery] string nama)
        {
            return "Hello, " + nama + "!";
        }

        [HttpGet("simple-user")]

        public object SimpleUser()
        {
            return new
            {
                Id = 1,
                Nama = "Lorem Ipsum",
                Username = "Cuki"
            };
        }

        [HttpGet("jsontest/product-summary")]

        public object ProductSummary()
        {
            return new 
            {
                id = 1,
                Nama = "arfan",
                Username = "arfan",
                HomeAddres = "wangon",

                Role = new string[]
                {
                    "admin",
                    "user"
                },

                MakananTermahal = new
                {
                    Id = 1,
                    Nama = "Nasi Uduk",
                    Harga = 15000
                },

                MakananTermurah = new
                {
                    Id = 2,
                    Nama = "Nasi Kuning",
                    Harga = 8000
                },

                DaftarMakanan = new object[]
                {
                    new { Id = 1, Nama = "Nasi Uduk" },
                    new { Id = 2, Nama = "Nasi Kuning" },
                    new { Id = 3, Nama = "Lontong" }
                }

            };
        }

        [HttpGet("jsontest/product-grouped")]

        public object ProductGrouped()
        {
            return new
            {
                Elektronik = new object[]
                {
                    new {id = 1, nama = "Keyboard"},
                    new {id = 2, nama = "Mouse"}
                },

                ATK = new object[]
                {
                    new {id = 3, nama = "Pulpen"},
                    new {id = 4, nama = "Buku"}
                }
            };
        }

        [HttpGet("jsontest/summary")]

        public object Summary()
        {
            // Produk termahal
            var produkTermahal = new
            {
                id = 4,
                nama = "Laptop",
                harga = 8000000
            };

            // Produk termurah
            var produkTermurah = new
            {
                id = 1,
                nama = "Pensil",
                harga = 2000
            };

            // List produk
            var daftarProduk = new[]
            {
                new { id = 1, nama = "Pensil" },
                new { id = 2, nama = "Buku" }
            };

            // Response utama
            var response = new
            {
                totalProduk = 12,
                produkTermahal = produkTermahal,
                produkTermurah = produkTermurah,
                daftarProduk = daftarProduk
            };

            return Ok(response);
        }

    }
}
