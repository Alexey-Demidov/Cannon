using UnityEngine;

public class ShotCannon : CannonComponents
{
    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private Transform  _pointOfShot;

    [SerializeField] private Effects _effects;

    private ShotParametrs _shotParametrs;
    private Rigidbody  _projectileRigidbody;
    private GameObject _projectile;

    public void Start() => _shotParametrs = new ShotParametrs(_effects.shotEffect, 100f);
    
    public override void Execute()
    {
        _projectile = Instantiate(_projectilePrefab, _pointOfShot);

        if(_projectile.TryGetComponent<Rigidbody>(out _projectileRigidbody))
        {
            _projectileRigidbody.AddRelativeForce(new Vector3(-ShotParametrs.forceZ, _shotParametrs.forceY, 0));
            _projectileRigidbody.transform.parent = null;
            _shotParametrs.effect.MakeEffect();
        }
    }

    public override void Disable() => this.enabled = false;
    public override void Enable() => this.enabled = true;
}

public class ShotParametrs
{
    public ShotParametrs(IEffect effect, float forceY = 100f)
    {
        this.effect = effect;
        this.forceY = forceY;
    }
    public static float forceZ { get; set; }

    public float forceY { get; set; }

    public IEffect effect { get; set; }
}
