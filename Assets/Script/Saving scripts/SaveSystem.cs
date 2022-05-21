using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    //Constructor
    public static void SavePlayer(SavingExamplePlayer p_player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        
        string path = Application.persistentDataPath + "/player.tokneneng";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(p_player);

        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("SAVED AT " + path);

    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.tokneneng";
        
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("FILE NOT FOUND. " + path);
            return null;
        }
    }
}
