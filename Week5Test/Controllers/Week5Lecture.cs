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
                System.Console.WriteLine(returnString(doge.Name));
            }

            return Accepted(input);
        }
        String returnString(string input)
        {
            //Here I log the character at position zero
            System.Diagnostics.Debug.WriteLine(input[0]);
            return input;
        }
    }

    public class Doge
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}

        

       
       

        
       
       
