using UnityEngine;
using UnityEngine.UI;

public class BalloonSpriteProvider : MonoBehaviour
{
    public Sprite[] sprites; // Индекс = BalloonColor

    private Image _balloonImage;

    public Sprite GetSprite(BalloonColor color) {
        return sprites[(int)color];
    }

    private void Start() {
        _balloonImage = GetComponent<Image>();
    }

    private void UpdateBalloon(BalloonColor color) {
        _balloonImage.sprite = GetSprite(color);
    }
}