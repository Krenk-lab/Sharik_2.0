using UnityEngine;

public class BalloonSpriteProvider : MonoBehaviour
{
    public Sprite[] sprites; // Индекс = BalloonColor

    // Получить спрайт по значению enum
    public Sprite GetSprite(BalloonColor color) {
        return sprites[(int)color];
    }
}