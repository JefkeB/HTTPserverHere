/*
 manages the registry keys to change to be able to start the webserver from the file explorer
 * 
    [HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Directory\shell\IISExpressWebServer]
    @="Web Sever Here"

    [HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Directory\shell\IISExpressWebServer\command]
    @="C:\\Program Files (x86)\\IIS Express\\iisexpress.exe /path:\"%1\" /port:8080 /systray:true"
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace HTTPserverHere
{
    class Registry
    {
    }
}
