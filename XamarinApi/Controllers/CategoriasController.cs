using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XamarinApi.DTO;
using XamarinApi.Model;

namespace XamarinApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {

        private readonly ApplicationDbContext context;
        public CategoriasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> Get()
        {
            return await context.Categorias.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(CategoriaDTO categoria)
        {
            var dto = new Categoria();
            dto.Nombre = categoria.Nombre;
            dto.Descripcion = categoria.Descripcion;
            dto.BHabilitado = categoria.BHabilitado;
            dto.Foto = categoria.Foto;

            context.Add(dto);
            await context.SaveChangesAsync();
            return Ok();
        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(CategoriaDTO categoria, int id)
        {
            if (categoria.IddCategoria != id)
            {
                return BadRequest("El id no coincide");
            }

            var existe = await context.Categorias.AnyAsync(x => x.IddCategoria == id);
            if (!existe)
            {
                return NotFound("El id no coincide");
            }

            context.Update(categoria);
            await context.SaveChangesAsync();
            return Ok();
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Categorias.AnyAsync(x => x.IddCategoria == id);
            if (!existe)
            {
                return NotFound("El id no coincide");
            }

            context.Remove(new Autor() { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
