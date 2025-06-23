using UnityEngine;
using YG;

public class Progress : MonoBehaviour
{
    public int Record { get; private set; }
    public bool SoundOn { get; private set; }

    public static Progress Instance;

    public bool IsOnSound() {
        SoundOn = !SoundOn;
        YG2.saves.IsAudioTrue = SoundOn;
        YG2.SaveProgress();
        return SoundOn;
    }
    public void SaveRecord() {
        YG2.saves.Record = Record;
        YG2.SaveProgress();
    }

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            LoadData();
        }
        else {
            Destroy(gameObject);
        }
    }

    private void LoadData() {
        Record = YG2.saves.Record;
        SoundOn = YG2.saves.IsAudioTrue;
    }
}
