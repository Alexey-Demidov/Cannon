using UnityEngine;

public interface IEffect
{
    void MakeEffect();
}
public class Effects : MonoBehaviour
{
    [SerializeField] public ShotEffect   shotEffect;
    [SerializeField] public ReloadEffect reloadEffect;
}
