using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int count = 0; count <= 5; count++)

            {
                HttpClient client = new HttpClient();

                var yeURL = "https://api.kanye.rest";

                var yeResponse = client.GetStringAsync(yeURL).Result;

                var yeObject = JObject.Parse(yeResponse);

                Console.WriteLine($"kayne says: {yeObject["quote"]}");


                HttpClient client1 = new HttpClient();

                var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

                var ronResponse = client1.GetStringAsync(ronURL).Result;

                var ronObject = JArray.Parse(ronResponse);

                Console.WriteLine($"Ron says: {ronObject[0]}");

                Console.WriteLine(ronObject[0]);

                Console.WriteLine();
            }

            
        }
    }
}
