using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private GameObject[] parts;
    [SerializeField] private Material dangerMaterial;
    [SerializeField] private string _tag_name = "Dangerous_Sector";
    /// <summary>
    /// Настраивает платформу
    /// </summary>
    public void RandomizePlatform()
    {
        DisableSectors();
        SetDangerousSectors();
    }
    /// <summary>
    /// Случайным образом выключает сектора платформы
    /// </summary>
    void DisableSectors()
    {
        int numberOfDisabled = Random.Range(2, 6);
        for (int i = 0; i < numberOfDisabled; i++)
        {
            int disabledIndex = Random.Range(0, parts.Length);
            if (parts[disabledIndex].activeSelf) parts[disabledIndex ].SetActive(false);
            else i--;
        }
    }
    /// <summary>
    /// Случайным образом выбирает опасные сектора платформы
    /// </summary>
    void SetDangerousSectors()
    {
        int numberOfDangerous = Random.Range(0, 3);
        for (int i = 0; i < numberOfDangerous; i++)
        {
            int dangerousIndex = Random.Range(0, parts.Length);
            if (parts[dangerousIndex].activeSelf)
            {
                Danger(parts[dangerousIndex]);
            }
            else i--;
        }
    }
    /// <summary>
    /// Меняет тэг и материал сектора платформы
    /// </summary>
    /// <param name="sector"></param>
    void Danger(GameObject sector)
    {
        sector.tag = _tag_name;
        sector.GetComponent<Renderer>().material = dangerMaterial;
    }
}
