﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFService_2Way_125;

namespace ServerChatApp_125_RidwanNurFaizin
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostobjek = null;
            try
            {
                hostobjek = new ServiceHost(typeof(ServiceCallback));
                hostobjek.Open();

                Console.WriteLine("Server On, Ready to Use");
                Console.ReadLine();

                hostobjek.Close();
            }
            catch (Exception ex)
            {
                hostobjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
