using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    [SerializeField] private Button _audioButton;

    [SerializeField] private Sprite _mute;
    [SerializeField] private Sprite _volume;

    private AudioSource _sound;

    public void OnSound() {       
        _sound.mute = !Progress.Instance.IsOnSound();
        ChangingSprite();
    }

    private void Start() {
        _sound = GetComponent<AudioSource>();
        ChangingSprite();
    }

    private void ChangingSprite() {
        if (_sound.mute) {
            _audioButton.GetComponent<Image>().sprite = _mute;
        }
        else {
            _audioButton.GetComponent<Image>().sprite = _volume;
        }

    }
}
