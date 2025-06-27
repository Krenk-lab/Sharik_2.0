using UnityEngine;

public class Background : MonoBehaviour
{
    public static Background Instance;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }
}
