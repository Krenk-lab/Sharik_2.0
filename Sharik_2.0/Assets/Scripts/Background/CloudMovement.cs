using UnityEngine;
using UnityEngine.SceneManagement;

public class CloudMovement : MonoBehaviour
{
    [Header("Mesh")]
    [SerializeField] private MeshRenderer _cloud1;
    [SerializeField] private MeshRenderer _cloud2;
    [SerializeField] private MeshRenderer _cloud3;
    [SerializeField] private MeshRenderer _miniBalloons;

    [Header("SpeedAnimation")]
    [SerializeField] private float _animationSpeedCloud1 = 0.01f;
    [SerializeField] private float _animationSpeedCloud2 = 0.01f;
    [SerializeField] private float _animationSpeedCloud3 = 0.01f;
    [SerializeField] private float _animationSpeedBalloons = 0.01f;

    private bool _isBalloons = true;

    void Update() {
        if (!_isBalloons && SceneManager.GetActiveScene().buildIndex == 0) {
            _isBalloons = true;
            _miniBalloons.gameObject.SetActive(_isBalloons);
        }
        else if (_isBalloons && SceneManager.GetActiveScene().buildIndex == 1) {
            _isBalloons = false;
            _miniBalloons.gameObject.SetActive(_isBalloons);
        }

        _cloud1.material.mainTextureOffset += new Vector2(_animationSpeedCloud1 * Time.deltaTime, 0);
        _cloud2.material.mainTextureOffset += new Vector2(_animationSpeedCloud2 * Time.deltaTime, 0);
        _cloud3.material.mainTextureOffset += new Vector2(_animationSpeedCloud3 * Time.deltaTime, 0);

        if (_isBalloons) {
            _miniBalloons.material.mainTextureOffset += new Vector2(0, _animationSpeedBalloons * Time.deltaTime);
        }

    }
}
