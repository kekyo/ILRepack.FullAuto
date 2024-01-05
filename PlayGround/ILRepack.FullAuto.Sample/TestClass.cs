/////////////////////////////////////////////////////////////////////////////////////
//
// ILRepack.FullAuto - Full automatic ILRepack executor on .NET, .NET Core and .NET Framework
// Copyright (c) Kouji Matsui (@kozy_kekyo, @kekyo@mastodon.cloud)
//
// Licensed under MIT: https://opensource.org/licenses/MIT
//
/////////////////////////////////////////////////////////////////////////////////////

using Newtonsoft.Json;
using System;

namespace ILRepack.FullAuto
{
    public class TestClass
    {
        public static string Test()
        {
            var json = JsonConvert.SerializeObject(DateTime.Now);
            return json;
        }
    }
}
