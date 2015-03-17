using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;


namespace Resolver.Models
{
    public class Thread
    {


        /// <summary>
        /// Constructor
        /// </summary>
        public Thread()
        {

        }


        public Thread(Models.CreateCaseViewModel viewModel)
        {
            this.viewModel = viewModel;

        }
        /// <summary>
        /// Created Date/Time
        /// </summary>
        public DateTime createdDate { get; set; }

        /// <summary>
        /// creator of case record - caseManager
        /// </summary>
        public String caseManager { get; set; }

        /// <summary>
        /// the title of the case record
        /// </summary>
        public String caseTitle { get; set; }

        /// <summary>
        /// a general description of the case record
        /// </summary>
        public String caseDescription { get; set; }


    }
}