/*
 manages the registry keys to change to be able to start the webserver from the file explorer
 * 
    [HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Directory\shell\HTTPServerHere]
    @="HTTP Sever Here"

    [HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Directory\shell\HTTPServerHere\command]
    @=<Path to the exe>
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;



namespace HTTPserverHere
{
    class Registry
    {
        const string KeyRoot = @"SOFTWARE\Classes\Directory\shell\";
        const string KeyName = "HTTPServerHere";
        //
        //
        //
        public bool ServeHere_Add(string ExePath)
        {
            try
            {
                using (RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(KeyRoot, true))
                {
                    // open\create key
                    // <KeyRoot>\<KeyName>
                    RegistryKey SubKey = key.CreateSubKey(KeyName);

                    // set values
                    // name in context menu (Default key)
                    SubKey.SetValue("", "HTTP Sever here ...");
                    // path to icon
                    SubKey.SetValue("icon", ExePath);

                    // path to this exe
                    // <KeyRoot>\<KeyName>\command
                    SubKey = SubKey.CreateSubKey("command");
                    SubKey.SetValue("", "\"" + ExePath + "\"" + " \"%1\"");


                    SubKey.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ServeHere_Add failed {0}", ex.Message);
            }

            return false;
        }


        //
        //
        //
        public void ServeHere_Remove()
        {
            try
            {
                using(RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(KeyRoot, true))
                {
                    if(key.OpenSubKey(KeyName) != null)
                    {
                        key.DeleteSubKeyTree(KeyName);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ServeHere_Remove failed {0}", ex.Message);
            }
        }
    }
}
