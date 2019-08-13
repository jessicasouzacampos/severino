using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeverinoAPI.Models
{
  public class Contato
  {
    public Contato()
    {

    }
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
  }


  public class ContatoDao
  {
    
    public List<Contato> getAllContatos()
    {
      return new List<Contato>() {
      new Contato(){Email = "123@.com.br", Id = new Guid(), Nome = "Sr 123"},
      new Contato(){Email = "456@.com.br", Id = new Guid(), Nome = "Sr 456"},
      new Contato(){Email = "789@.com.br", Id = new Guid(), Nome = "Sr 789"},
      new Contato(){Email = "147@.com.br", Id = new Guid(), Nome = "Sr 147"},
      new Contato(){Email = "258@.com.br", Id = new Guid(), Nome = "Sr 258"},
      new Contato(){Email = "369@.com.br", Id = new Guid(), Nome = "Sr 369"},
      new Contato(){Email = "852@.com.br", Id = new Guid(), Nome = "Sr 852"},
      new Contato(){Email = "741@.com.br", Id = new Guid(), Nome = "Sr 741"},
      new Contato(){Email = "963@.com.br", Id = new Guid(), Nome = "Sr 963"}
      };
    }
  }
}
