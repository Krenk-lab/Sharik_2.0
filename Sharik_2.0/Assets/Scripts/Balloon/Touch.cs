using UnityEngine;

public class Touch : MonoBehaviour
{
    private Animator anim;

    private void Start() {
        anim = GetComponentInChildren<Animator>();
    }

    private void OnMouseDown() {
        anim.enabled = true;
    }
}
