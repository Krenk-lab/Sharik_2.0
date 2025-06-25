using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopManager : MonoBehaviour
{
    [SerializeField] private BalloonColor _color;
    private BalloonSpriteProvider balloonSpriteProvider;
    private Heart _heart;
    private Score _score;

    public void ChekAdd(BalloonColor color) {
        if(color == _color) {
            _score.AddScore();
        }
        else {
            _heart.LoseLife();
        }
    }
    public bool ValidatePop(BalloonColor color) {
        if (color == _color)
            return true;
        return false;
    }

    private void Start() {
        _score = FindAnyObjectByType<Score>();
        _heart = FindAnyObjectByType<Heart>();
    }

    private void RandomColor() {
        balloonSpriteProvider.GetSprite(_color);
    }

}
