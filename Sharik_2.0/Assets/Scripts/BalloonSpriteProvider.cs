using UnityEngine;

public class BalloonSpriteProvider : MonoBehaviour
{
    [SerializeField] private Sprite[] _sprites;

    public Sprite GetSprite(BalloonColor color) {

        return _sprites[(int)color];
    }
}