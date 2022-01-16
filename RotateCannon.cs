using UnityEngine;

public class RotateCannon : CannonComponents
{
    private float _rotationX;   
    private float _rotationY;   

    [Header("Ускорение вращения. Установка из инспектора.")]
    [Range(1, 10)] [SerializeField] private float _acceleration = 1;  

    [Header("Максимальные и минимальные углы поворота. Установка из инспектора.")]
    [Range(10, 40)] [SerializeField] private float _maxRotationX = 25;
    [Range(10, 40)] [SerializeField] private float _minRotationX = -25;
    [Range(10, 40)] [SerializeField] private float _maxRotationY = 25;
    [Range(10, 40)] [SerializeField] private float _minRotationY = -26;

    public override void Execute()
    {
        _rotationX += Input.GetAxis("Mouse X") *    _acceleration;
        _rotationY += Input.GetAxis("Mouse Y") * (- _acceleration);  

        ValidateAngles();

        transform.rotation = Quaternion.Euler(0, _rotationX, _rotationY);
    }
    public override void Disable() => this.enabled = false;
    public override void Enable() => this.enabled = true;

    private void ValidateAngles()   
    {
        if (_rotationX > _maxRotationX)
            _rotationX = _maxRotationX;
        else if (_rotationX < _minRotationX)
            _rotationX = _minRotationX;

        if (_rotationY > _maxRotationY)
            _rotationY = _maxRotationY;
        else if (_rotationY < _minRotationY)
            _rotationY = _minRotationY;
    }
}
