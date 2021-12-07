using UnityEngine;
public class Camera : MonoBehaviour
{
    [SerializeField] private Vector3 dampOffset;
    [SerializeField] private float smooth;
    [SerializeField] private Transform target;
    
    private Vector3 _vel = Vector3.zero;
    private float _lowerPosition;
    private Transform _camera;
    private void Start() //Вызывается при старте сцены
    {
        _lowerPosition = target.position.y; 
        _camera = GetComponent<Transform>();
        _camera.position = target.position + dampOffset;
    }
    void Update()
    {
        _lowerPosition = target.position.y < _lowerPosition ? target.position.y : _lowerPosition; //Находим наименьшую высоту, на которой был игрок
        //Плавное перемещение камеры
        _camera.position = Vector3.SmoothDamp(_camera.position,
            new Vector3(target.position.x, _lowerPosition, target.position.z) + dampOffset, ref _vel, smooth);
    }
}