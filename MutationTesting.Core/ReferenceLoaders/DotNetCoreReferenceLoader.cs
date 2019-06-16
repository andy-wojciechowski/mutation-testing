using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace MutationTesting.Core.ReferenceLoaders
{
    /// <summary>
    /// This class will load all assemblies from project references in a .NET core project file
    /// </summary>
    public class DotNetCoreReferenceLoader : IReferenceLoader
    {
        public IList<AssemblyDefinition> LoadReferencesForProject(string projectFile, string binFolderPath)
        {
            var projectDocument = XDocument.Load(projectFile);
            if (projectDocument.Root.Attribute("Sdk") == null)
                throw new InvalidOperationException("The project file given is not a .NET core project");

            var projectReferenceElements = (from element in projectDocument.Descendants("ProjectReference")
                                            select element).ToList();

            var projectReferenceNames = projectReferenceElements.Select(GetReferenceName).ToList();

            return projectReferenceNames.Select(x => LoadAssembly(x, binFolderPath)).ToList();
        }

        private string GetReferenceName(XElement projectReferenceElement)
        {
            var includeValue = projectReferenceElement.Attribute("Include").Value;
            var projFileName = includeValue.Split('/').Single(x => x.EndsWith(".csproj") || x.EndsWith(".vbproj"));
            var matchObj = Regex.Match(projFileName, "(.*).(.*)");
            return matchObj.Groups[0].Value;
        }

        private AssemblyDefinition LoadAssembly(string assemblyName, string binFolderPath)
        {
            return AssemblyDefinition.ReadAssembly($"{binFolderPath}/{assemblyName}.dll");
        }
    }
}
