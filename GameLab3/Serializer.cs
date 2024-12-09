using System.IO;
using Newtonsoft.Json;

public static class Serializer
{
    public static void SaveGame(object gameState, string filePath)
    {
        var json = JsonConvert.SerializeObject(gameState);
        File.WriteAllText(filePath, json);
    }

    public static T LoadGame<T>(string filePath)
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
        return default;
    }
}
