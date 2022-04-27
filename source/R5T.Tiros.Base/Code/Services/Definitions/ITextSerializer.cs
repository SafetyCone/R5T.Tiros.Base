using System;
using System.IO;

using R5T.T0064;


namespace R5T.Tiros
{
    [ServiceDefinitionMarker]
    public interface ITextSerializer<T> : IServiceDefinition
    {
        T Deserialize(TextReader reader);

        void Serialize(TextWriter writer, T value);
    }
}
