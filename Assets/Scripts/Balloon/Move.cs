using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Flight speed")]
    [SerializeField] private float _speed = 1f;

    void Update()
    {
        transform.position += new Vector3(0, _speed * Time.deltaTime);
    }
}
