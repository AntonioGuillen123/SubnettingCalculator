using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using Subnetting_Calculator;
using Subnetting_Calculator.Shared;

namespace Subnetting_Calculator.Pages
{
    public partial class Index
    {
        static private int subnetNumber = 3;
		static private int? size;
        static private double? totalHost;

        private void CheckHosts()
        {
			totalHost = size != null ? (size * subnetNumber) + (2 * subnetNumber) : null;

			Console.WriteLine(totalHost);
        }
    }
}