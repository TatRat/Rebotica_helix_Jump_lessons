using System.IO;
using UnityEngine;

public class LoadJSON : MonoBehaviour
{
    /// <summary>
    /// Загрузка данных из json
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T LoadingJSON<T>(string path)
    {
        if (File.Exists(path))
        {
            return JsonUtility.FromJson<T>(File.ReadAllText(path));
        }
        else return default(T);
    }
}
