using System;
using Microsoft.CodeAnalysis;

namespace FirstSampleGenerator
{
    [Generator(LanguageNames.CSharp)]
    public partial class SampleGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
        }
    }
}
