using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int ScoreValue { get; set; } = 0;
    private TextMeshProUGUI _scoreText;

    public void AddScore() {
        ScoreValue++;
        Progress.Instance.AddRecord(ScoreValue);
        UpdateText();
    }

    void Start() {
        _scoreText = GetComponentInChildren<TextMeshProUGUI>();
        UpdateText();
    }

    private void UpdateText() {
        _scoreText.text = ScoreValue.ToString();
    }
}
