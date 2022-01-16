using UnityEngine;

// Методы для компонентов пушки
public abstract class CannonComponents : MonoBehaviour
{
    public abstract void Enable();
    public abstract void Disable();
    public abstract void Execute();
}
public class Cannon : MonoBehaviour
{
    [SerializeField] private CannonComponents     _reload;
    [SerializeField] private CannonComponents     _shot;
    [SerializeField] private CannonComponents     _rotate;

    [SerializeField] private SetForceBySlider _setForceBySlider;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))  // стрельба
        {
            if (_shot.isActiveAndEnabled)
            {
                _shot.Execute();
                SwitchToReload();
            }              
        }

        if (Input.GetMouseButton(0) && _setForceBySlider.NotDragging)    // вращение (прицеливание)
        {
            _rotate.Execute();
        }
    }
    
    public void SwitchToAiming()
    {
        _rotate.Enable();
        _shot.Enable();
    }

    public void SwitchToReload()
    {
        _rotate.Disable();
        _shot.Disable();

        _reload.Execute();
    }

}
