using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 14f; //Скорость поворота платформы вокруг своей оси
    void Update() //Вызывается каждый кадр
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) //Проверка на касание экрана пальцем
        {
            Vector3 rotation = Input.GetTouch(0).deltaPosition; //получение изменения позиции пальца
            transform.Rotate(0,rotation.x * _speed * Time.deltaTime,0); //Поворот платформы вокруг своей оси
        }
    }
}
