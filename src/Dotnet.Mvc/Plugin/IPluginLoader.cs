﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Dotnet.Mvc.Plugin
{
    public interface IPluginLoader
    {
        IEnumerable<IPluginStartup> LoadEnablePlugins(IServiceCollection serviceCollection);
        IEnumerable<PluginInfo> GetPlugins();
        void DisablePlugin(string pluginId);
        void EnablePlugin(string pluginId);
        IEnumerable<Assembly> GetPluginAssemblies();
        string PluginFolderName();
    }
}
