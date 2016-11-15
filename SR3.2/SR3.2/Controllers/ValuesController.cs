using SR3._2.Models.Device;
using SR3._2.Models.Interfaces;
using System.Collections.Generic;
using System.Web.Http;


namespace SR3._2.Controllers
{
    public class ValuesController : ApiController
    {
        IDictionary<int, AbstractDevice> SmartHome;
        
        // GET api/values
        //public IEnumerable<AbstractDevice> Get()
        //{
        //    return new List<AbstractDevice> {   
        //    new TV { state = true , Volume = 45, Chennel = 33 },
        //    new Boiler {state = true, Temp = 15},
        //    new Conditioner { state = true, Temp = 20 },
        //    new Fridge { state = true, Temp = 5 },
        //    new MC {state = true , Volume = 45, Chennel = 33},
        //};
        //}
        // GET api/values/5
        //[Route("api/values/tv")]
        //public List<AbstractDevice> Gettv()
        //{
        //    return ;
        //}
        //[Route("api/values/vol")]
        //public int Getvol()
        //{
        //    return ((IVolume)SmartHome).IncreaseVolume();
        //}

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [Route("api/values/incr")]
        public void PutIncrease (int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
