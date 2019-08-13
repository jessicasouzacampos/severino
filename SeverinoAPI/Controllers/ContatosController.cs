using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SeverinoAPI.Models;

namespace SeverinoAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ContatosController : ControllerBase
  {

    public Contato _contatoAnterior = new Contato
    {
      Nome = "Jim",
      Email = "jim1@gmail.com",
      Id = new Guid()
    };


    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
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

    /// <summary>
    /// Segue abaixo o Json para testar essa Action
    /// 
    /// [{ op: "replace",  "path": "/Email", value: "jessica.campos@live.com" },{ op: "replace",  "path": "/Nome", value: "Jessica Campos" }]
    /// 
    /// </summary>
    /// <param name="novoContato"></param>
    /// <returns></returns>
    // PATCH api/values/5
    [HttpPatch]
    public IActionResult Patch([FromBody] JsonPatchDocument<Contato> novoContato)
    {
      if (novoContato != null)
      {        

        novoContato.ApplyTo(_contatoAnterior, ModelState);

        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState);
        }

        return new ObjectResult(_contatoAnterior);
      }
      else
      {
        return BadRequest(ModelState);
      }
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
