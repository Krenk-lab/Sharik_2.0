using UnityEngine;
using UnityEngine.UI;

public class ButtonIconSwitcher : MonoBehaviour
{

    [SerializeField] private Sprite _volume;
    [SerializeField] private Sprite _mute;

    private Image _audioButton;

    public void SwitchSprite() {
        Sound.Instance.OnSound();

        if (Progress.Instance.Mute) {
            _audioButton.sprite = _mute;
            Debug.Log("Mute");
        }
        else {
            _audioButton.sprite = _volume;
            Debug.Log("Don't mute");
        }
    }
    private void Start() {
        _audioButton = GetComponent<Image>();
        SwitchSprite();
    }
}
