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
            //�ǰe��H
            var toUserID = "Uc8472802ca87e59285e5ed47786dfb09";
            //Channel Access Token
            var token = @"Fxf60h6Q82EeS6GWGpWiGYs8i0k+T4FIclx8M/jHju9MoEFCKWIwcif0fJHEBDE1/SvcP/Zu20ak3/mALuBREBmRHzv5Rl/K+4Mgf6OWNf8v9xmmJkYDhIYEAAJS/fJ4ycUq76kML3GBbW3TUsQzOgdB04t89/1O/w1cDnyilFU=";
            //create bot instance
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);
            //send message
            bot.PushMessage(toUserID, "Hello test");
            bot.PushMessage(toUserID, 1, 2);
            bot.PushMessage(toUserID, new Uri("https://i.imgur.com/v87f0Gy.png"));

            //LineBot Helper
            LineBot.LineBotHelper LineBotHelper = new LineBot.LineBotHelper(
                    "�A��Channel ID", "�A��Channel Secret", "�A��MID");

            //�o�e�T��
            var ret = LineBotHelper.SendMessage(
                new List<string>() { �o�e��HID }, �o�e�T��);

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
