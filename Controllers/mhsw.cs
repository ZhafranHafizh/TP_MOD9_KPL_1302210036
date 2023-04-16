using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Reflection;

namespace tpmodul9_1302210036.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mhsw : ControllerBase
    {
        public static List<Mahasiswa> _data = new List<Mahasiswa>
        {
            new Mahasiswa("Zhafran Hafizh", "1302210036"),
            new Mahasiswa("Risjad Shidqi", "1302213045"),
            new Mahasiswa("Ashar Syahbudi", "1302210070"),
            new Mahasiswa("Surya Aulia", "1302210084"),
            new Mahasiswa("Gifari Juliandri", "1302210087"),
        };
        // GET: api/<Mahasiswa>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return _data;
        }

        // GET api/<Mahasiswa>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            return _data[id];
        }

        // POST api/<Mahasiswa>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            _data.Add(value);
        }
        // DELETE api/<Mahasiswa>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            _data.RemoveAt(id);
        }
    }
}