using UnityEngine;

public class Touch : MonoBehaviour
{
    private Animator _anim;
    private PopManager _popManager;

    private void Start() {
        _anim = GetComponentInChildren<Animator>();
        _popManager = FindFirstObjectByType<PopManager>();
    }

    private void OnMouseDown() {
        _anim.enabled = true;
        _popManager.ChekAdd(transform.GetComponent<Stats>().Color);
        Sound.Instance.PlaySound();

        Debug.Log(transform.GetComponent<Stats>().Color);
    }
}
