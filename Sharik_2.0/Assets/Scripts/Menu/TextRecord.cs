using TMPro;
using UnityEngine;
using YG;

public class TextRecord : MonoBehaviour
{
    private TextMeshProUGUI _Recordtext;
    
    private void Start() {
        _Recordtext = GetComponent<TextMeshProUGUI>();
        UpdateTextRecord();
    }

    private void UpdateTextRecord() {
        _Recordtext.text = YG2.saves.Record.ToString();
    }
}
