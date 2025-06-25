using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI _scoreText;
    private int _score = 0;

    public void AddScore() {
        _score++;
        UpdateText();
    }

    void Start() {
        _scoreText = GetComponentInChildren<TextMeshProUGUI>();
        UpdateText();
    }

    private void UpdateText() {
        _scoreText.text = _score.ToString();
    }
}
