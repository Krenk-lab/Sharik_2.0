using TMPro;
using UnityEngine;
using YG;

public class GameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textRecord;
    [SerializeField] private TextMeshProUGUI _textScore;

    private Score _score;

    private void Start() {
        _score = FindObjectOfType<Score>();
        _textScore.text = _score.ScoreValue.ToString();
        _textRecord.text = YG2.saves.Record.ToString();
    }
}
