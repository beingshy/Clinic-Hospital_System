using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.IO;

namespace ClinicManagementDB_DataAccess
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString { get; }

        static clsDataAccessSettings()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
    }
}
