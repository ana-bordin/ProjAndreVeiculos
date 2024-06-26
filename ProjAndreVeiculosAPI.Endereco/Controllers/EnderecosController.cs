﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Newtonsoft.Json;
using ProjAndreVeiculosAPIEndereco.Data;
using ProjAndreVeiculosAPIEndereco.Services;

namespace ProjAndreVeiculosAPIEndereco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EnderecosController : ControllerBase
    {
        private readonly ProjAndreVeiculosAPIEnderecoContext _context;
        private readonly EnderecoService _enderecoService;


        public EnderecosController(ProjAndreVeiculosAPIEnderecoContext context, EnderecoService enderecoService)
        {
            _context = context;
            _enderecoService = enderecoService;
        }

        public EnderecosController(ProjAndreVeiculosAPIEnderecoContext context)
        {
            _context = context;
        }


        // GET: api/Enderecos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Endereco>>> GetEndereco()
        {
            if (_context.Endereco == null)
            {
                return NotFound();
            }
            return await _context.Endereco.ToListAsync();
        }

        // GET: api/Enderecos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Endereco>> GetEndereco(int id)
        {
            if (_context.Endereco == null)
            {
                return NotFound();
            }
            var endereco = await _context.Endereco.FindAsync(id);

            if (endereco == null)
            {
                return NotFound();
            }

            return endereco;
        }

        // PUT: api/Enderecos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEndereco(int id, Endereco endereco)
        {
            if (id != endereco.Id)
            {
                return BadRequest();
            }

            _context.Entry(endereco).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Enderecos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Endereco>> PostEndereco([FromBody] Endereco endereco)
        {
            if (_context.Endereco == null)
            {
                return Problem("Entity set 'ProjAndreVeiculosAPIEnderecoContext.Endereco' is null.");
            }

            using (var client = new HttpClient())
            {
                string cep = endereco.CEP;
                client.BaseAddress = new Uri("https://viacep.com.br/");
                var response = await client.GetAsync($"ws/{cep}/json/");
                if (response.IsSuccessStatusCode)
                {
                    var stringResult = await response.Content.ReadAsStringAsync();
                    var end = JsonConvert.DeserializeObject<Endereco>(stringResult);

                    _enderecoService.Create(end);

                    _context.Endereco.Add(end);

                    await _context.SaveChangesAsync();
                }
                else
                {
                    return NotFound("Erro ao obter endereço do serviço ViaCEP");
                }
            }

            return CreatedAtAction("GetEndereco", new { id = endereco.Id }, endereco);
        }


        // DELETE: api/Enderecos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEndereco(int id)
        {
            if (_context.Endereco == null)
            {
                return NotFound();
            }
            var endereco = await _context.Endereco.FindAsync(id);
            if (endereco == null)
            {
                return NotFound();
            }

            _context.Endereco.Remove(endereco);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EnderecoExists(int id)
        {
            return (_context.Endereco?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpGet("cep/{cep}")]
        public async Task<ActionResult<Endereco>> ObterEnderecoPorCepAsync(string cep)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://viacep.com.br/");
                var response = await client.GetAsync($"ws/{cep}/json/");
                if (response.IsSuccessStatusCode)
                {
                    var stringResult = await response.Content.ReadAsStringAsync();
                    var endereco = JsonConvert.DeserializeObject<Endereco>(stringResult);
                    return endereco;
                }
                else
                {
                    return NotFound("Erro ao obter endereço do serviço ViaCEP");
                }
            }
        }
    }
}




