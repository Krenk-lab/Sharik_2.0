using System.Collections;
using UnityEngine;

public class SpawnBalloons : MonoBehaviour
{
    [SerializeField] private GameObject _cloud;

    [SerializeField] private float _left;
    [SerializeField] private float _right
        
        ;

    [SerializeField] private float _pause = 1f;

    private GameObject _tempObj;

    private void Start() {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn() {
        Vector3 vector3 = transform.position;

        while (true) {
            vector3.x = Random.Range(_left, _right);

            _tempObj =Instantiate(_cloud, vector3, Quaternion.identity);

            yield return new WaitForSeconds(_pause);
        }
    }
}
