using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no4
{

    class KodePos
    {
        // Dictionary untuk menyimpan daftar kode pos berdasarkan kelurahan
        private static Dictionary<string, string> kodePosTable = new Dictionary<string, string>
    {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

        // Method untuk mendapatkan kode pos berdasarkan kelurahan
        public static string getKodePos(string? kelurahan)
        {
            // Jika kelurahan null atau kosong, kembalikan pesan error
            if (string.IsNullOrEmpty(kelurahan))
            {
                return "Nama kelurahan tidak boleh kosong.";
            }

            // Cek apakah kelurahan ada dalam Dictionary
            if (kodePosTable.ContainsKey(kelurahan))
            {
                return kodePosTable[kelurahan]; // Kembalikan kode pos jika ditemukan
            }
            else
            {
                return "Kode Pos tidak ditemukan."; // Jika tidak ditemukan, berikan pesan ini
            }
        }
    }
}
