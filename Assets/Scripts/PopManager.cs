using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PopManager : MonoBehaviour
{
    [SerializeField] private Image _balloonImage;

    [SerializeField] private BalloonColor _color;

    private BalloonSpriteProvider _balloonSpriteProvider;
    private Heart _heart;
    private Score _score;

    public void ChekAdd(BalloonColor color) {
        if (color == _color) {
            _score.AddScore();
        }
        else {
            _heart.LoseLife();
        }
    }

    private void Start() {
        _score = FindAnyObjectByType<Score>();
        _heart = FindAnyObjectByType<Heart>();
        _balloonSpriteProvider = GetComponent<BalloonSpriteProvider>();
        StartCoroutine(SwitchColor());
    }

    private void RandomColor() {
        BalloonColor color = (BalloonColor)Random.Range(0, 6);
        _color = color;
        _balloonImage.sprite = _balloonSpriteProvider.GetSprite(color);
    }

    private IEnumerator SwitchColor() {
        while (true) {
            RandomColor();
            float pause = Random.Range(2, 6);
            yield return new WaitForSeconds(pause);
        }
    }

}
