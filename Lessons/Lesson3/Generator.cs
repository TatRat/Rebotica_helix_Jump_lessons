using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private int _maxFloors = 30;
    private float _yOffset = 2f;
    [SerializeField] private GameObject[] floors;
    [SerializeField] private Transform Cylinder;
    [SerializeField] private Transform player;
    private void Awake()
    {
        TransformCylinder();
        GenerateFloors();
        player.position = new Vector3(player.position.x, _maxFloors * 2 + 2, player.position.z);
    }
    /// <summary>
    /// Создание новых платформ на сцене
    /// </summary>
    void GenerateFloors()
    {
        GameObject currentFloor = Instantiate(floors[0], Vector3.zero, Quaternion.identity);
        currentFloor.transform.parent = Cylinder;
        for (int i = 1; i < _maxFloors - 1; i++)
        {
            currentFloor = Instantiate(floors[1], new Vector3(0, i * _yOffset, 0), Quaternion.identity);
            currentFloor.GetComponent<Floor>().RandomizePlatform();
            currentFloor.transform.parent = Cylinder;
        }
        currentFloor = Instantiate(floors[2], new  Vector3(0, _yOffset * (_maxFloors-1),0), Quaternion.identity);
        currentFloor.transform.parent = Cylinder;
    }
    /// <summary>
    /// Задаем позицию и размер цилиндра
    /// </summary>
    void TransformCylinder()
    {
        Cylinder.localScale = new Vector3(Cylinder.localScale.x, _maxFloors * _yOffset, Cylinder.localScale.z);
        Cylinder.position = new Vector3(0, Cylinder.localScale.y, 0);
    }
}
