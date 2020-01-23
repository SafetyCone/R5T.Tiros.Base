using System;
using System.IO;


namespace R5T.Tiros
{
    public interface ITextSerializer<T>
    {
        T Deserialize(TextReader reader);

        void Serialize(TextWriter writer, T value);
    }
}
