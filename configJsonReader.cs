using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace EvanBot
{
    internal class JsonReader
    {
        public string token { get; set; }
        public string prefix { get; set; }

        public JsonReader()
        {

        }

        public async Task ReadJson()
        {
            using (StreamReader sr = new StreamReader("config.json", new UTF8Encoding(false)))
            {
                string json = await sr.ReadToEndAsync();
                ConfigJSON obj = JsonConvert.DeserializeObject<ConfigJSON>(json);

                this.token = obj.Token;
                this.prefix = obj.Prefix;
            }
        }

    }
}
