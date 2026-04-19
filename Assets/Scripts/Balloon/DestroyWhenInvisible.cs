using UnityEngine;

public class DestroyWhenInvisible : MonoBehaviour
{

    [SerializeField] private bool _isVisible = false;

    private void OnBecameVisible() {
        _isVisible = true;
    }

    private void OnBecameInvisible() {
        if (_isVisible) 
            Destroy(transform.gameObject);
    }
}
