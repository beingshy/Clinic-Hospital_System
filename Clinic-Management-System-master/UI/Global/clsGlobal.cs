using ClinicManagementDB_Business;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Global
{
    public static class clsGlobal
    {
        public static clsUser CurrentUser = null;
        public static clsLoginHistory CurrentLoginHistory = null;

        public static bool SaveLoginCredentials(string Username, string Password)
        {
            try
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClinicManagementSystem", "Username", Username, RegistryValueKind.String);
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClinicManagementSystem", "Password", Password, RegistryValueKind.String);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public static bool GetLoginCredentials(ref string Username, ref string Password)
        {
            try
            {
                object rUsername = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClinicManagementSystem", "Username", null);
                object rPassword = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClinicManagementSystem", "Password", null);

                if(rUsername != null && rPassword != null)
                {
                    Username = rUsername.ToString();
                    Password = rPassword.ToString();
                    return true;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        public static bool DeleteLoginCredentials()
        {
            try
            {
                RegistryKey baseRegistryKey = Registry.CurrentUser;

                using(RegistryKey key = baseRegistryKey.OpenSubKey($@"SOFTWARE\ClinicManagementSystem", true))
                {
                    if(key != null)
                    {
                        key.DeleteValue("Username", true);
                        key.DeleteValue("Password", true);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


    }

}
