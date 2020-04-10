// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Microsoft.AspNetCore.Components.WebAssembly.DevServer.Server
{
    // This project is a CLI tool, so we don't expect anyone to reference it
    // as a runtime library. As such we consider it reasonable to mark the
    // following method as public purely so the E2E tests project can invoke it.

    /// <summary>
    /// Intended for framework test use only.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Intended for framework test use only.
        /// </summary>
        public static IHost BuildWebHost(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureHostConfiguration(config =>
                {
                    var applicationPath = args.SkipWhile(a => a != "--applicationpath").Skip(1).FirstOrDefault();
                    var applicationDirectory = Path.GetDirectoryName(applicationPath);
                    var name = Path.ChangeExtension(applicationPath, ".StaticWebAssets.xml");

                    var inMemoryConfiguration = new Dictionary<string, string>
                    {
                        [WebHostDefaults.EnvironmentKey] = "Development",
                        ["Logging:LogLevel:Microsoft"] = "Warning",
                        ["Logging:LogLevel:Microsoft.Hosting.Lifetime"] = "Information",
                        [WebHostDefaults.StaticWebAssetsKey] = name,
                    };

                    config.AddInMemoryCollection(inMemoryConfiguration);
                    config.AddJsonFile(Path.Combine(applicationDirectory, "blazor-devserversettings.json"), optional: true, reloadOnChange: true);
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStaticWebAssets();
                    webBuilder.UseStartup<Startup>();
                }).Build();
    }
}
