using System.Collections;
using UnityEngine;

public class SpawnBalloons : MonoBehaviour
{
    [SerializeField] private GameObject[] _balloons;

    [Header("Ширина области спавна")]
    [SerializeField] private float _left;
    [SerializeField] private float _right;

    [Header("Пауза между шариками")]
    [SerializeField] private float _minPause = 1f;
    [SerializeField] private float _maxPause = 1.5f;

    //[Header("Количество слотов по X")]
    //[SerializeField] private int _slots = 5;

    private void Start() {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn() {
        while (true) {
            float x = Random.Range(_left + 0.2f, _right - 0.2f); // с небольшим отступом от краёв

            Vector3 spawnPos = transform.position;
            spawnPos.x = x;

            // Случайный шарик
            GameObject prefab = _balloons[Random.Range(0, _balloons.Length)];
            Instantiate(prefab, spawnPos, Quaternion.identity);

            // Пауза
            float pause = Random.Range(_minPause, _maxPause);
            yield return new WaitForSeconds(pause);
        }
    }
}