using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    [Header("Image")]
    [SerializeField] private Sprite _heartImage;
    [SerializeField] private Sprite _deathImage;

    [Header("Object")]
    [SerializeField] private Image _heart1;
    [SerializeField] private Image _heart2;
    [SerializeField] private Image _heart3;

    [Header("Life")]
    [Range(0, 3)]
    [SerializeField] private int _value;

    private DamagePanel _damagePanel;

    public void AddLife() {
        _value++;
    }

    public void LoseLife() {
        _value--;
        _damagePanel.PlayDamage();
    }

    private void Start() {
        _damagePanel = FindObjectOfType<DamagePanel>();
    }

    private void Update() {
        SwitchImage();
    }

    private void SwitchImage() {
        switch (_value) {
            case 0:
                _heart1.sprite = _deathImage;
                _heart2.sprite = _deathImage;
                _heart3.sprite = _deathImage;
                break;
            case 1:
                _heart1.sprite = _heartImage;
                _heart2.sprite = _deathImage;
                _heart3.sprite = _deathImage;
                break;
            case 2:
                _heart1.sprite = _heartImage;
                _heart2.sprite = _heartImage;
                _heart3.sprite = _deathImage;
                break;
            case 3:
                _heart1.sprite = _heartImage;
                _heart2.sprite = _heartImage;
                _heart3.sprite = _heartImage;
                break;
            default:
                break;
        }
    }
}
