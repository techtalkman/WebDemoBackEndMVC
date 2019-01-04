using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDemoBackEndMVC.Models;

namespace WebRekisteri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TietokantaController : ControllerBase
    {
        public List<Myyntikiellot> GetAll()
        {
            TukesContext context = new TukesContext();
            List<Myyntikiellot> kiellot = context.Myyntikiellot.ToList();
            return kiellot;
        }


        [Route("{key}")]
        public Myyntikiellot GetSingle(int key)
        {
            TukesContext context = new TukesContext();
            Myyntikiellot tuote = context.Myyntikiellot.Find(key);
            return tuote;
        }


        [HttpPost]
        public string PostCreateNew([FromBody] Myyntikiellot tuote)
        {
            TukesContext context = new TukesContext();
            context.Myyntikiellot.Add(tuote);
            context.SaveChanges();

            return tuote.Id.ToString();
        }


        [HttpPut]
        [Route("{key}")]
        public string PutEdit(int key, [FromBody] Myyntikiellot newData)
        {
            TukesContext context = new TukesContext();
            Myyntikiellot tuote = context.Myyntikiellot.Find(key);

            if (tuote != null)
            {
                tuote.Tuotenimi = newData.Tuotenimi;
                tuote.Malli = newData.Malli;
                tuote.Vaaranlaji = newData.Vaaranlaji;
                
                context.SaveChanges();
                return "OK";
            }

            return "NOT FOUND";
        }


        [HttpDelete]

        [Route("{key}")]

        public string DeleteSingle(int key)

        {
            TukesContext context = new TukesContext();
            Myyntikiellot tuote = context.Myyntikiellot.Find(key);

            if (tuote != null)
            {
                context.Myyntikiellot.Remove(tuote);
                context.SaveChanges();
                return "DELETED";
            }

            return "NOT FOUND";
        }
    }
}