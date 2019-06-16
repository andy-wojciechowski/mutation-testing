using MutationTesting.Core.Mutators;
using MutationTesting.Core.ReferenceLoaders;
using MutationTesting.Core.TestRunners;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutationTesting.Core
{
    public class MutationRunner
    {
        private IList<IMutator> Mutators { get; }
        private ITestRunner TestRunner { get; }
        private IReferenceLoader ReferenceLoader { get; }

        public MutationRunner(IList<IMutator> mutators, ITestRunner testRunner, IReferenceLoader referenceLoader)
        {
            Mutators = mutators;
            TestRunner = testRunner;
            ReferenceLoader = referenceLoader;
        }

        public void RunMutators()
        {
            throw new NotImplementedException();
        }
    }
}
