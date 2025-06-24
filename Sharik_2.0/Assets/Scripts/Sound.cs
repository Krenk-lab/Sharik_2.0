using UnityEngine;
using YG;

public class Sound : MonoBehaviour
{
    public static Sound Instance;
    
    private AudioSource _sound;

    public void OnSound() {       
        _sound.mute = Progress.Instance.SwitchMute();
    }

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

    private void Start() {
        _sound = GetComponent<AudioSource>();
        _sound.mute = YG2.saves.IsMute;
    }
}
