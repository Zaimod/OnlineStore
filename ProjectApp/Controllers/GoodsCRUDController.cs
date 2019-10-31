using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectApp.Models;

namespace ProjectApp.Controllers
{
    [Route("api/[products]")]
    [ApiController]
    public class GoodsCRUDController : ControllerBase
    {
        private readonly Context context;

        public GoodsCRUDController(Context context)
        {
            this.context = context;
        }

        // GET: api/GoodsCRUD
        [HttpGet]
        public IEnumerable<Goods> Get()
        {
            return context.Goods.ToList();
        }

        // GET: api/GoodsCRUD/5
        [HttpGet("{id}")]
        public Goods Get(int id)
        {
            Goods goods = context.Goods.FirstOrDefault(x => x.id == id);
            return goods;
        }

        // PUT: api/GoodsCRUD/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Goods goods)
        {
            if (ModelState.IsValid)
            {
                context.Update(goods);
                context.SaveChanges();

                return Ok(goods);
            }
            return BadRequest(ModelState);
        }

        // POST: api/GoodsCRUD
        [HttpPost]
        public IActionResult Post([FromBody]Goods goods)
        {
            if (ModelState.IsValid)
            {
                context.Goods.Add(goods);
                context.SaveChanges();
                return Ok(goods);
            }
            return BadRequest(ModelState);
        }

        // DELETE: api/GoodsCRUD/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Goods goods = context.Goods.FirstOrDefault(x => x.id == id);
            if (goods != null)
            {
                context.Goods.Remove(goods);
                context.SaveChanges();
            }
            return Ok(goods);
        }
    }
}