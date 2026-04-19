using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmericanAirlinesApi.Data;
using AmericanAirlinesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmericanAirlinesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VoosController(AppDbContext context) : ControllerBase
    {
        public readonly AppDbContext _context = context;
        
        [HttpPost("voos")]
        public IActionResult CriarVoo(Voo voo)
        {
            var aeronave = _context.Aeronaves.Find(voo.AeronaveId);
            if (aeronave == null)
            return NotFound(new {Mensagem = "Aeronave não encontrada."});

            var vooEmTransito = _context.Voos
            .Any(v => v.AeronaveId == voo.AeronaveId && v.Status == "Em Voo");

            if (vooEmTransito)
            return Conflict(new{ Mensagem = "Aeronave indisponível, encontra-se em trânsito."});

            _context.Voos.Add(voo);
           _context.SaveChanges();
           return Ok(voo);
        }
        [HttpPatch("voos/{id}/status")]
        public IActionResult AtualizarStatus(int id, [FromBody] string novoStatus)
        {
           var voo = _context.Voos.Find(id);
           if (voo == null)
               return NotFound(new { Mensagem = "Voo não encontrado." });

           if ((voo.Status == "Finalizado" || voo.Status == "Cancelado") && novoStatus == "Em Voo")
           {
               return BadRequest(new { Mensagem = "Regra de negócio: Voo finalizado ou cancelado não pode voltar para 'Em Voo'." });
           }

           voo.Status = novoStatus;
           _context.SaveChanges();

               return Ok(new { Mensagem = "Status atualizado com sucesso.", Voo = voo });
        }
    }
}