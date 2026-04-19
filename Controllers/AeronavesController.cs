using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmericanAirlinesApi.Data;
using AmericanAirlinesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmericanAirlinesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AeronavesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AeronavesController(AppDbContext context)
        {
            _context = context;
        }
        
    
    [HttpPost]
    public IActionResult CriarAeronave(Aeronave aeronave)
        {
            _context.Aeronaves.Add(aeronave);
            _context.SaveChanges();
            return Ok(new {Mensagem = "Aeronave cadastrada com sucesso.", Aeronave = aeronave});   
        }
    [HttpGet]
    public IActionResult ListarAeronaves()
    {
        return Ok(_context.Aeronaves.ToList());
    }
}
}