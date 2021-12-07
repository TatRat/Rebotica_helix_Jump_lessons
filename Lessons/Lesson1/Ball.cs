using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField] private float jumpVelocity = 6f;
    private Rigidbody _rb;
    private void Awake() //эта функция вызывается после инициализации объектов на сцене
    {
        _rb = GetComponent<Rigidbody>(); //получаем компонент, находящийся на объекте
    }
    private void OnCollisionEnter(Collision other) //вызывается при соприкосновении объекта с другим коллайдером
    {
        if (other.gameObject.CompareTag("platform")) //проверка на наличие тега на объекте
        {
            _rb.velocity = Vector3.up * jumpVelocity; //придание ускорения к объекту 
        }
    }
}
