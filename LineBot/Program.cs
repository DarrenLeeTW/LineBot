using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineBot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            //傳送對象
            var toUserID = "Uc8472802ca87e59285e5ed47786dfb09";
            //Channel Access Token
            var token = "";
            //create bot instance
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);
            //send message
            bot.PushMessage(toUserID, "Hello test");
            bot.PushMessage(toUserID, 1, 2);
            bot.PushMessage(toUserID, new Uri("https://i.imgur.com/v87f0Gy.png"));

            //LineBot Helper
            LineBot.LineBotHelper LineBotHelper = new LineBot.LineBotHelper(
                    "你的Channel ID", "你的Channel Secret", "你的MID");

            //發送訊息
            var ret = LineBotHelper.SendMessage(
                new List<string>() { 發送對象ID }, 發送訊息);

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
