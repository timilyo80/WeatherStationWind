using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    static class AppConfiguration
    {
        public static IConfiguration configuration;

        public static string GetValue(string s)
        {
            return "fuckthis";
        }

        private static void initConfig()
        {

        }
    }
}
