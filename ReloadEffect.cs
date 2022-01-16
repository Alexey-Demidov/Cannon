using UnityEngine;

public class ReloadEffect : MonoBehaviour, IEffect
{
    [SerializeField] private ParticleSystem _reloadEffect;
    [SerializeField] private AudioSource    _reloadSound;
    public void MakeEffect()
    {
        _reloadEffect.Play();
        _reloadEffect.Play();
    }
}