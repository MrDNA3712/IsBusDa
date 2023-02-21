using Newtonsoft.Json;
using System.Net;

namespace Is_Bus_da
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            get_departure_info(RWS_stop_id,RWS_dir_id);
        }



        // https://v5.bvg.transport.rest/stops/900000037201/departures?direction=900000027305
        public const string RWS_stop_id = "900000037201";
        public const string RWS_dir_id = "900000027305";

        static readonly HttpClient httpClient = new HttpClient();

        public static DepartureInfo[] get_departure_info(string start, string direction = "")
        {
            try
            {
                string uri = String.Format("https://v5.bvg.transport.rest/stops/{0}/departures?direction={1}&duration=600&results=5", start, direction);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string responseBody = reader.ReadToEnd();
                Console.WriteLine(responseBody);
                dynamic liste = JsonConvert.DeserializeObject(responseBody);
                DepartureInfo[] infos = new DepartureInfo[5];
                int i = 0;
                foreach (var item in liste)
                {
                    string destination = (string)item["destination"]["name"];
                    int delay;
                    if (item["delay"] == null)
                    {
                        delay = 0;
                    }
                    else
                    {
                        delay = (int)item["delay"];
                    }
                    DateTime departure = item["plannedWhen"];
                    DateTime actualDeparture = item["when"];
                    string line = item["line"]["name"];
                    DepartureInfo dinfo=new DepartureInfo(line,destination,departure,actualDeparture,delay);
                    infos[i++] = dinfo;
                    if (i == 5)
                    {
                        break;
                    }
                }
                return infos;
            }
            catch (HttpRequestException e)
            {

                throw e;
            }
        }
    }
}