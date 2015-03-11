using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using Resolver.Controllers;

namespace Resolver.App_Start
{
    public class DatabaseConnectionContext
    {
        
        public MongoDatabase database;


        /// <summary>
        /// DatabaseConnectionContext
        /// Contains method to connect to mongodb
        /// </summary>
        public DatabaseConnectionContext()
        {
            try 
            { 
                //Implement client to connect to server
                var client = new MongoClient(Resolver.Properties.Settings.Default.Server);
                //Establish connection with server
                MongoServer server = client.GetServer();
                //Establish a conext to connect to database
                database = server.GetDatabase(Resolver.Properties.Settings.Default.RootDatabase);
                //Check if thread and platform collection exist, if not create   
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
               
            }
        }

        // TODO create method to return resolver thread objects from database
        


    }
}