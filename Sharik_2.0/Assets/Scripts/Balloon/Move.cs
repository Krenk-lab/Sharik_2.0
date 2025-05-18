using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _force = 150;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rb.velocity = new Vector2(0, Time.fixedDeltaTime * _force);
    }
}
