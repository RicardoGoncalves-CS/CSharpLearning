using Newtonsoft.Json;

namespace Serialization;

public class SerialiserJson : ISerialiser
{
    public void Serialise<T>(T item, string toPath)
    {
        string jsonString = JsonConvert.SerializeObject(item, Formatting.Indented);
        File.WriteAllText(toPath, jsonString);
    }



    public T Deserialise<T>(string fromPath)
    {
        string jsonString = File.ReadAllText(fromPath);
        return JsonConvert.DeserializeObject<T>(jsonString);
    }
}
