using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem 
{
    public static void SaveLevel(int level)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Path.Combine(Application.persistentDataPath, "num.level");
        FileStream stream = new FileStream(path, FileMode.Create);
        SceneLevel data = new SceneLevel(level);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static SceneLevel LoadLevel()
    {
        string path = Path.Combine(Application.persistentDataPath, "num.level");
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            SceneLevel data = formatter.Deserialize(stream) as SceneLevel;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("File not found in" + path);
            return null;
        }
    }
    public static void SaveVolume(float music, float sound)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Path.Combine(Application.persistentDataPath, "adjust.volume");
        FileStream stream = new FileStream(path, FileMode.Create);
        VolumeData data = new VolumeData(music,sound);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static VolumeData LoadVolume()
    {
        string path = Path.Combine(Application.persistentDataPath, "adjust.volume");
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            VolumeData data = formatter.Deserialize(stream) as VolumeData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("File not found in" + path);
            return null;
        }
    }
}
