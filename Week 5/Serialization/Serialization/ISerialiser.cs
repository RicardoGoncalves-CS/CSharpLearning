namespace Serialization;

public interface ISerialiser
{
    void Serialise<T>(T item, string toPath);

    T Deserialise<T>(string fromPath);
}
