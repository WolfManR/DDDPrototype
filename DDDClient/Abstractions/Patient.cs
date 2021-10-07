using System.Collections.Generic;

namespace DDDClient.Abstractions
{
    internal abstract record Patient(int Id, string Name)
    {
        public IList<ILabor> Analizes { get; } = new List<ILabor>();
    }
}