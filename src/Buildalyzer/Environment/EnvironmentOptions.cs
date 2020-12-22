﻿using System.Collections.Generic;

namespace Buildalyzer.Environment
{
    public class EnvironmentOptions
    {
        /// <summary>
        /// Indicates a preferences towards the build environment to use.
        /// The default is a preference for the .NET Core SDK.
        /// </summary>
        public EnvironmentPreference Preference { get; set; } = EnvironmentPreference.Core;

        /// <summary>
        /// The default targets to build.
        /// </summary>
        public List<string> TargetsToBuild { get; } = new List<string> { "Clean", "Build" };

        /// <summary>
        /// Indicates that a design-time build should be performed.
        /// The default value is <c>true</c>.
        /// </summary>
        /// <remarks>
        /// See https://github.com/dotnet/project-system/blob/master/docs/design-time-builds.md.
        /// </remarks>
        public bool DesignTime { get; set; } = true;

        /// <summary>
        /// Runs the restore target prior to any other targets using the MSBuild <c>restore</c> switch.
        /// </summary>
        /// <remarks>
        /// See https://github.com/Microsoft/msbuild/pull/2414.
        /// </remarks>
        public bool Restore { get; set; } = true;

        /// <summary>
        /// The full path to the <c>dotnet</c> executable you want to use for the build when building
        /// projects using the .NET Core SDK. Defaults to <c>dotnet</c> which will look in folders
        /// specified in the path environment variable.
        /// </summary>
        /// <remarks>
        /// Set this to something else to customize the .NET Core runtime you want to use (I.e., preview versions).
        /// </remarks>
        public string DotnetExePath { get; set; } = "dotnet";

        /// <summary>
        /// The global MSBuild properties to set.
        /// </summary>
        public IDictionary<string, string> GlobalProperties { get; } = new Dictionary<string, string>();

        /// <summary>
        /// Environment variables to set.
        /// </summary>
        public IDictionary<string, string> EnvironmentVariables { get; } = new Dictionary<string, string>();

        /// <summary>
        /// Additional MSBuild command-line arguments to use.
        /// </summary>
        public IList<string> Arguments { get; } = new List<string>();
    }
}