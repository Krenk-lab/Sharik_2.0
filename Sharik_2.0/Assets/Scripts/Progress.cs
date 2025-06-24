using UnityEngine;
using YG;

public class Progress : MonoBehaviour
{
    public int Record { get; private set; }
    public bool Mute { get; private set; }

    public static Progress Instance;

    public bool SwitchMute() {
        Mute = !Mute;
        YG2.saves.IsMute = Mute;
        YG2.SaveProgress();
        return Mute;
    }
    public void SaveRecord() {
        YG2.saves.Record = Record;
        YG2.SaveProgress();
    }

    private void Awake() {
        if (Instance == null) {
            YG2.StickyAdActivity(true);
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
        Mute = YG2.saves.IsMute;
    }
}
