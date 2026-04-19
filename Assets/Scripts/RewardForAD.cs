using UnityEngine;
using YG;

public class RewardForAD : MonoBehaviour
{
    [SerializeField] private DeathMenu _death;

    public string rewardID;

    // Когда объект с данным классом станет активным, метод OnReward подпишется на событие вознаграждения
    private void OnEnable() {
        YG2.onRewardAdv += OnReward;
    }

    // Необходимо отписывать методы от событий при деактивации объекта
    private void OnDisable() {
        YG2.onRewardAdv -= OnReward;
    }

    // Вызов рекламы за вознаграждение
    public void MyRewardAdvShow(string id) {
        YG2.RewardedAdvShow(rewardID);
    }

    // Метод подписан на событие OnReward (ивент вознаграждения)
    private void OnReward(string id) {
        // Проверяем ID вознаграждения. Если совпадает с тем ID, с которым вызывали рекламу, то вознаграждаем.
        if (id == rewardID) {
            // Получение вознаграждения
            _death.AddHeart();
        }
    }
}
