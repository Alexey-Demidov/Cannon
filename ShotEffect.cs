using UnityEngine;

public class ShotEffect : MonoBehaviour, IEffect
{
    [SerializeField] private ParticleSystem _explosionEffect;
    [SerializeField] private ParticleSystem _smokeEffect;
    [SerializeField] private AudioSource    _shotSound;
    public void MakeEffect()
    {
        _smokeEffect.Play();
        _shotSound.Play();
        _explosionEffect.Play();
    }
}
