using System.Collections.Generic;

namespace DDDClient.Abstractions
{
    internal abstract record Patient(int Id, string Name, IList<IAnalysis> Analizes);
}