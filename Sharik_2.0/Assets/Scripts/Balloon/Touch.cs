using UnityEngine;

public class Touch : MonoBehaviour
{
    private Animator _anim;
    private PopManager popManager;

    private void Start() {
        _anim = GetComponentInChildren<Animator>();
        popManager = FindAnyObjectByType<PopManager>();
    }

    private void OnMouseDown() {
        _anim.enabled = true;
        popManager.ChekAdd(transform.GetComponent<Stats>().Color);

        Debug.Log(transform.GetComponent<Stats>().Color);
    }
}
