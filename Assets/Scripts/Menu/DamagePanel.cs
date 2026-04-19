using UnityEngine;

public class DamagePanel : MonoBehaviour
{
    private Animator _animator;

    public void PlayDamage() {
        if (!_animator.enabled) {
            _animator.enabled = true;
        }
        else {
            _animator.Play("DamagePanel", 0, 0f);
        }
    }

    void Start() {
        _animator = GetComponent<Animator>();
        _animator.enabled = false;
    }
}
