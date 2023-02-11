using Microsoft.AspNetCore.Mvc;

namespace Week5Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Week5Lecture : ControllerBase
    {

        [HttpPost(Name = "Week5Lecture")]
        public ActionResult<List<Doge>> Post([FromBody] List<Doge> input)
        {
            foreach (Doge doge in input)
            {
                System.Console.WriteLine(doge.Name);
            }

            return Accepted(input);
        }
    }

    public class Doge
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}

        

       
       

        
       
       
