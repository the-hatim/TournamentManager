using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.Data
{
    public class SqlConnector : IDataConnection
    {

        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">the prize information</param>
        /// <returns>THe prize info,including the unique ID</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {

            model.Id = 1;
            return model;
        }
    }
}
