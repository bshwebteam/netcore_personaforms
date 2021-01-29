using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using netcore_personaforms.Domain;
using netcore_personaforms.Persistence;

namespace netcore_personaforms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnobController : ControllerBase
    {

        private readonly DataContext _context;
        public KnobController(DataContext context)
        {
            this._context = context;

        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T_SKUList>>> Get()
        {
            var values = await _context.T_SKUList.ToListAsync();
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T_SKUList>> Get(int id)
        {
            var value = await _context.T_SKUList.FindAsync(id);
            return value;
        }

        // GET api/values/5
        [HttpGet("modelNumb/{modelNumb}")]
        public async Task<ActionResult<IEnumerable<T_SKUList>>> GetByModelNumb(string modelNumb)
        {
            var values = await _context.T_SKUList.Where(e => e.modelNum.StartsWith(modelNumb)).Take(20).ToListAsync();
            return values;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

