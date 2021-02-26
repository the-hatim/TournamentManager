using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Data;
using System.Configuration;
using TrackerUI;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textfiles)
        {
            if(database)
            {
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if(textfiles)
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
