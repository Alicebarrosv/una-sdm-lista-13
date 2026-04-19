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
    public class ReservasController(AppDbContext context) : ControllerBase
    {
        public readonly AppDbContext _context = context;

        [HttpPost("reservas")]
        public IActionResult CriarReserva(Reserva reserva)
        {
            var voo = _context.Voos.Include(v => v.Aeronave).Include(v => v.Reservas).FirstOrDefault(v => v.Id == reserva.VooId);

            if (voo == null)
               return NotFound("Voo não encontrado");

            if (voo.Reservas.Count >= voo.Aeronave.CapacidadePassageiro)
               return BadRequest("Voo lotado. Não é possível fazer novas reservas");

            if (reserva.Assento.EndsWith("A") || reserva.Assento.EndsWith("F"))
            {
                return Ok(new
                {
                    Mensagem = "Assento na janela reservado",
                    Reserva = reserva
                });                                    
            }
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
            return Ok(reserva);
        }
        
    }
}