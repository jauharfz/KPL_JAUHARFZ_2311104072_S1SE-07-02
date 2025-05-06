using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_2311104072.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> _mahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("jauharfz", "2311104072"),
            new Mahasiswa("anggap saja anggota", "23111040XX")
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            if (_mahasiswa.Count == 0)
            {
                return NotFound("Tidak ada data mahasiswa");
            }
            return Ok(_mahasiswa);
        }

        [HttpGet("{index}")]
        public IActionResult GetByIndex(int index)
        {
            if (_mahasiswa.Count == 0)
            {
                return NotFound("Tidak ada data mahasiswa");
            }
            else if (index < 0 || index >= _mahasiswa.Count)
            {
                return NotFound("Index tidak valid");
            }
            

            return Ok(_mahasiswa[index]);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Mahasiswa mahasiswa)
        {
            _mahasiswa.Add(mahasiswa);
            return CreatedAtAction(nameof(GetAll), new { count = _mahasiswa.Count }, mahasiswa);
        }

        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            if (_mahasiswa.Count == 0)
            {
                return NotFound("Tidak ada data mahasiswa");
            }
            else if (index < 0 || index >= _mahasiswa.Count)
            {
                return NotFound("Index tidak valid");
            }

            var mhsDelete = _mahasiswa[index];
            _mahasiswa.RemoveAt(index);
            return Ok($"Mahasiswa {mhsDelete.Name} berhasil dihapus");
        }
    }
}