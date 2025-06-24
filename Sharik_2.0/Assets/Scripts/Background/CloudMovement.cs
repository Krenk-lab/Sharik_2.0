using UnityEngine;

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

    [Header("Balloons in background")]
    [SerializeField] private bool _isBalloons = true;

    private void Start() {
        _miniBalloons.gameObject.SetActive(_isBalloons);
    }

    void Update() {
        _cloud1.material.mainTextureOffset += new Vector2(_animationSpeedCloud1 * Time.deltaTime, 0);
        _cloud2.material.mainTextureOffset += new Vector2(_animationSpeedCloud2 * Time.deltaTime, 0);
        _cloud3.material.mainTextureOffset += new Vector2(_animationSpeedCloud3 * Time.deltaTime, 0);
        if (_isBalloons) {          
            _miniBalloons.material.mainTextureOffset += new Vector2(0, _animationSpeedBalloons * Time.deltaTime);
        }

    }
}
