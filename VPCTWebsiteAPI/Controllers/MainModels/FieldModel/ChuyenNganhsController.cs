﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Models.MainModels.FieldModel;
using VPCT.Repositories.Infrastructure;

namespace VPCTWebsiteAPI.Controllers.MainModels.FieldModel
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuyenNganhsController(IUnitOfWork context) : ControllerBase
    {

        // GET: api/ChuyenNganhs
        [HttpGet]
        public ActionResult<IEnumerable<ChuyenNganh>> GetChuyenNganh()
        {
            return context.ChuyenNganhRepository.GetAll().Include(x => x.LinhVuc).ToList();
        }

        // GET: api/ChuyenNganhs/5
        [HttpGet("{id}")]
        public ActionResult<ChuyenNganh> GetChuyenNganh(int id)
        {
            var chuyenNganh = context.ChuyenNganhRepository.GetAll().Include(x => x.LinhVuc).FirstOrDefault(x => x.Id == id);

            if (chuyenNganh == null)
            {
                return NotFound();
            }

            return chuyenNganh;
        }

        [HttpGet("GetChuyenNganhByLinhVuc/{linhVucId}")]
        public ActionResult<IEnumerable<ChuyenNganh>> GetChuyenNganhByLinhVuc(int linhVucId)
        {
            var l = context.ChuyenNganhRepository.SearchChuyenNganhByLinhVucId(linhVucId).Include(x => x.LinhVuc).ToList();

            if (l.Count == 0)
            {
                return NotFound();
            }

            return l;
        }

        // PUT: api/ChuyenNganhs/5
        [HttpPut("{id}")]
        public IActionResult PutChuyenNganh(int id, ChuyenNganh chuyenNganh)
        {
            if (id != chuyenNganh.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.ChuyenNganhRepository.Update(chuyenNganh);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChuyenNganhExists(chuyenNganh.Id))
                    {
                        return NotFound();
                    }
                }
                return NoContent();
            }

            return BadRequest(ModelState);
        }

        // POST: api/ChuyenNganhs
        [HttpPost]
        public ActionResult<ChuyenNganh> PostChuyenNganh(ChuyenNganh chuyenNganh)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.ChuyenNganhRepository.Create(chuyenNganh);
            context.SaveChanges();

            return CreatedAtAction("GetChuyenNganh", new { id = chuyenNganh.Id }, chuyenNganh);
        }

        // DELETE: api/ChuyenNganhs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteChuyenNganh(int id)
        {
            try
            {
                var chuyenNganh = context.ChuyenNganhRepository.Find(id);
                if (chuyenNganh == null)
                {
                    return NotFound();
                }

                context.ChuyenNganhRepository.Delete(chuyenNganh);
                context.SaveChanges();

                return NoContent();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Foreign key constraint violation: Cannot delete this entity due to related records in other tables.");
            }
        }

        private bool ChuyenNganhExists(int id)
        {
            return (context.ChuyenNganhRepository.GetAll()?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
