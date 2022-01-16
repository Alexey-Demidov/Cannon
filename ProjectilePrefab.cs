using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ShotPrefab : MonoBehaviour
{
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, 3f);
    }    
}
