using UnityEngine;

public class RotateCannon : CannonComponents
{
    private float _rotationX;   // поворот вверх-вниз 
    private float _rotationY;   // поворот влево-вправо

    [Header("Ускорение вращения. Настройка из редактора.")]
    [Range(1, 10)] [SerializeField] private float _acceleration = 1;  // ускорение поворота

    [Header("Ограничения вращения по углам. Настройка из редактора.")]
    [Range(10, 40)] [SerializeField] private float _maxRotationX = 25;
    [Range(10, 40)] [SerializeField] private float _minRotationX = -25;
    [Range(10, 40)] [SerializeField] private float _maxRotationY = 25;
    [Range(10, 40)] [SerializeField] private float _minRotationY = -26;

    public override void Execute()
    {
        _rotationX += Input.GetAxis("Mouse X") *    _acceleration;
        _rotationY += Input.GetAxis("Mouse Y") * (- _acceleration);  // отрицательным значением _acceleration избавляемся от инверсии

        ValidateAngles();

        transform.rotation = Quaternion.Euler(0, _rotationX, _rotationY);
    }
    public override void Disable() => this.enabled = false;
    public override void Enable() => this.enabled = true;

    private void ValidateAngles()   // не дает выйти за максимальное значение поворота
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
