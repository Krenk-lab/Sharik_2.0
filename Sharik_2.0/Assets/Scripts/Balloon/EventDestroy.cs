using UnityEngine;

public class EventDestroy : MonoBehaviour
{
    public void Destroy() {
        Destroy(transform.parent.gameObject);
    }
}
