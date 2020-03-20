using System.Net;
using System.Collections.Specialized;
using System.Text;
using System;


namespace LoggerCore
{
    public class SlackLogger : FileBaseLogger
    {
        public SlackLogger(string channel, LogOutput logOutput) : base(channel, logOutput)
        {

        }

        protected override void SubClassLog(string msg)
        {
            
            var data = new NameValueCollection();

            data["token"] = "write your token";
            data["channel"] = "write your channel name";
            data["text"] = msg;

            var client = new WebClient();
            var response = client.UploadValues("https://slack.com/api/chat.postMessage", "POST", data);
            string responseInString = Encoding.UTF8.GetString(response);
            Console.WriteLine(responseInString);
            
            /*
            if (logOutput == LogOutput.OutputToSlackChannel)
            {
                var client = new RestClient("write your webhook --> made via PostMan");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", "{\n\n\t\"text\":\"" + msg + "\"\n}", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
            }
            */

        }
    }
}