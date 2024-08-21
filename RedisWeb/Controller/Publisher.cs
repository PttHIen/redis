using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisWeb.Controller
{
    public class Publisher
    {
        static void Main(string[] args)
        {
            var redis = ConnectionMultiplexer.Connect("localhost:6379");
            var pub = redis.GetSubscriber();

            Console.WriteLine("Nhập thông điệp cần gửi (exit để thoát):");

            while (true)
            {
                string message = Console.ReadLine();
                if (message.ToLower() == "exit") break;

                pub.Publish("chat_channel", message);
            }

            Console.WriteLine("Publisher kết thúc.");
        }
    }
}