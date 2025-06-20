using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    [SerializeField] private float _force = 0.5f;

    void FixedUpdate() {
        transform.position += new Vector3(Time.deltaTime * _force, 0);
    }
}
