using Mono.Cecil;
using System.Collections.Generic;

namespace MutationTesting.Core.ReferenceLoaders
{
	/// <summary>
	/// The base type for loading project references for a .NET project
	/// </summary>
	public interface IReferenceLoader
	{
		/// <summary>
		/// Loads project references for a given .NET project as Mono.Cecil assemblies
		/// </summary>
		/// <param name="projectFile">a .NET project file</param>
		/// <param name="binFolderPath">the path to a project's bin folder</param>
		/// <returns>a list of loaded Mono.Cecil assemblies</returns>
		IList<AssemblyDefinition> LoadReferencesForProject(string projectFile, string binFolderPath);
	}
}
