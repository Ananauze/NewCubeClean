using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _divisionChance = 1f;
    [SerializeField] private float _scaleFactor = 0.5f;

    private Rigidbody _rigidbody;

    public float DivisionChance => _divisionChance;
    public float ScaleFactor => _scaleFactor;
    public Rigidbody RigidbodyComponent => _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        if (_rigidbody == null)
            _rigidbody = gameObject.AddComponent<Rigidbody>();
    }

    public void Initialize(float divisionChance, float scaleFactor)
    {
        _divisionChance = divisionChance;
        _scaleFactor = scaleFactor;
    }
}
