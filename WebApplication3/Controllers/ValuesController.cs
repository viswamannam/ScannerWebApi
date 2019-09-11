using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class ValuesController : ApiController
    {
        /* DLL Import with 1st method */
        [DllImport("LScanEssentials.dll")]
        public static extern int LSCAN_InitAPI();
        [DllImport("LScanEssentials.dll")]
        public static extern int LSCAN_ExitAPI();
        [DllImport("LScanEssentials.dll")]
        public static extern int LSCAN_Main_Release(int handler, bool sendToStandby);
        
        [DllImport("LScanEssentials.dll")]
        public static extern int LSCAN_Main_Initialize(int device, bool reset, ref int handle);
        [DllImport("LScanEssentials.dll")]
        public static extern int LSCAN_Main_GetDeviceCount(ref int count);
        // GET api/values
        public IEnumerable<string> Get()
        {
            
            LSCAN_InitAPI();
            int handler = 0;
            int DeviceCount = 0;
            int F1;
            //LScanDeviceInfo deviceinfo = null;
            // LSCAN_ExitAPI();
            int FunctionReturnResult = LSCAN_Main_GetDeviceCount(ref DeviceCount);
            return new string[] { "value1", "value2" };

        }

        // GET api/values/5
        public string Get(int id)
        {
            LSCAN_InitAPI();
            int handler = 0;
            int DeviceCount = 0;
            int F1;
            //LScanDeviceInfo deviceinfo = null;
            // LSCAN_ExitAPI();
            int FunctionReturnResult = LSCAN_Main_GetDeviceCount(ref DeviceCount);
            return DeviceCount.ToString();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
