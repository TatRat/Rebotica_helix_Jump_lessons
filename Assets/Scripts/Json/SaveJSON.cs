using System.IO;
using UnityEngine;

public class SaveJSON : MonoBehaviour
{
    /// <summary>
    /// Сохраняет переданный объект с помощью json
    /// </summary>
    /// <param name="path">Путь к файлу сохранения</param>
    /// <param name="obj">Объект, который нужно сохранить</param>
    public static void SavingJSON(string path, object obj)
    {
        File.WriteAllText(path, JsonUtility.ToJson(obj));
    }
}
