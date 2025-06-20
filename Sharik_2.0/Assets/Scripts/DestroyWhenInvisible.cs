using UnityEngine;

public class DestroyWhenInvisible : MonoBehaviour
{

    [SerializeField] private bool _isVisible = false;

    private void OnBecameVisible() {
        Debug.Log(_isVisible);
        
        _isVisible = true;
    }

    private void OnBecameInvisible() {
        if (_isVisible) {
            Debug.Log("Destroy");
            
            Destroy(transform.gameObject);
        }
    }
}
