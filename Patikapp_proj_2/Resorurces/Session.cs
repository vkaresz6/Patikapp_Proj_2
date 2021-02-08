using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikapp_proj_2.Resorurces
{
    public static class Session
    {
        public static void setSession(String Username, int pharmacy, String PharmacyName)
        {
            isLogged = true;
        }
        public static String Username { get; set; }
        public static int User_id { get; set; }

        public static String PharmacyName { get; set; }
        public static int pharmacy { get; set; }

        public static bool isLogged;
    }
}
