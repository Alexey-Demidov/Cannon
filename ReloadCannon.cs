using UnityEngine;

public class ReloadCannon : CannonComponents
{
    [SerializeField] private Cannon   _cannon;
    [SerializeField] private Animator _animateReload;
    public override void Execute()
    {
        _animateReload.SetTrigger("start reload");
    }
    public override void Disable() => this.enabled = false;
    public override void Enable() => this.enabled = true;
    public void EndReload() => _cannon.SwitchToAiming(); // вызов при окончании анимации перезарядки
}
