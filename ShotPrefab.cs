using UnityEngine;

// Управление поведением префаба пушечного ядра

[RequireComponent(typeof(Rigidbody))]
public class ShotPrefab : MonoBehaviour
{
    // сохраняем твердое тело объекта для возмоности расширения игровой логики
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, 3f);
    }

    
}
