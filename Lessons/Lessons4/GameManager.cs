using TMPro;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    private string _path;
    [SerializeField] private TMP_Text text;
    [System.Serializable]
    class Data
    {
        public int Level = 0;
    }
    [SerializeField] private Data data;
    private void Start() //Вызывается при старте сцены
    {
        _path = System.IO.Path.Combine(Application.persistentDataPath, "save.json");//Путь к сохранению
        Debug.Log(_path);
        data = LoadJSON.LoadingJSON<Data>(_path); //Загрузка
        text.text = data.Level.ToString(); //Вывод уровня на экран
    }
    private void OnDisable() //Вызывается при отключении объекта
    {
        SaveJSON.SavingJSON(_path, data); //Сохранение данных
    }
    public void NewLevel()//Переход на новый уровень
    {
        data.Level++;
    }
}



