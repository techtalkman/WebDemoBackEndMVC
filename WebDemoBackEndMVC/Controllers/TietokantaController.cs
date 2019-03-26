using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDemoBackEndMVC.Models;

namespace WebDemoBackEndMVC.Controllers
{
    /// <summary>
    /// API-kutsut
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TietokantaController : ControllerBase
    {
        public List<MyyntikiellotAzure> GetAll()
        {
            TukesAContext context = new TukesAContext();
            List<MyyntikiellotAzure> kiellot = context.MyyntikiellotAzure.ToList();
            return kiellot;
        }


        [Route("{key}")]
        public MyyntikiellotAzure GetSingle(int key)
        {
            try
            {
                TukesAContext context = new TukesAContext();
                MyyntikiellotAzure tuote = context.MyyntikiellotAzure.Find(key);
                return tuote;
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost]
        public string PostCreateNew([FromBody] MyyntikiellotAzure tuote)
        {
            TukesAContext context = new TukesAContext();
            context.MyyntikiellotAzure.Add(tuote);
            context.SaveChanges();

            return tuote.Id.ToString();
        }


        [HttpPut]
        [Route("{key}")]
        public string PutEdit(int key, [FromBody] MyyntikiellotAzure newData)
        {

            try
            {
                TukesAContext context = new TukesAContext();
                MyyntikiellotAzure tuote = context.MyyntikiellotAzure.Find(key);

                if (tuote != null)
                {
                    tuote.Tuotenimi = newData.Tuotenimi;
                    tuote.Malli = newData.Malli;
                    tuote.Vaaranlaji = newData.Vaaranlaji;

                    context.SaveChanges();
                    return "OK";
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return "NOT FOUND";
        }


        [HttpDelete]

        [Route("{key}")]

        public string DeleteSingle(int key)

        {
            try
            {
                TukesAContext context = new TukesAContext();
            MyyntikiellotAzure tuote = context.MyyntikiellotAzure.Find(key);

                if (tuote != null)
                {
                    context.MyyntikiellotAzure.Remove(tuote);
                    context.SaveChanges();
                    return "DELETED";
                }
            }
            catch (Exception) { }

            return "NOT FOUND";
        }
    }
}