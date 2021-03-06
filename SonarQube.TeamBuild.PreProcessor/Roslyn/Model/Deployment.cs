﻿//-----------------------------------------------------------------------
// <copyright file="Deployment.cs" company="SonarSource SA and Microsoft Corporation">
//   Copyright (c) SonarSource SA and Microsoft Corporation.  All rights reserved.
//   Licensed under the MIT License. See License.txt in the project root for license information.
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SonarQube.TeamBuild.PreProcessor.Roslyn
{

    /// <summary>
    /// XML-serializable data class that contains metadata required to deploy analyzers
    /// </summary>
    public class Deployment
    {
        [XmlArray("NuGetPackages")]
        [XmlArrayItem(Type = typeof(NuGetPackageInfo), ElementName = "NuGetPackage")]
        public List<NuGetPackageInfo> NuGetPackages { get; set; }

        [XmlArray("Plugins")]
        [XmlArrayItem(Type = typeof(Plugin), ElementName = "Plugin")]
        public List<Plugin> Plugins { get; set; }

    }
}
