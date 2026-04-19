using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    [SerializeField] private GameObject _background;
    [SerializeField] private GameObject _deathPanel;
    [SerializeField] private GameObject _deathMenu;
    [SerializeField] private Heart _heart;

    private bool _isAddLife = false;
    public void AddHeart() {
        _heart.AddLife();
        _deathPanel.SetActive(false);
        _background.SetActive(false);
        Debug.Log(Time.timeScale = 1);
    }
    public void Death() {
        _background.SetActive(true);
        
        if (!_isAddLife) {
            ActivePanel();
            _isAddLife = true;
        }
        else {
            ActiveMenu();
        }
    }

    public void ActiveMenu() {
        if (_deathPanel.activeSelf) {
            _deathPanel.SetActive(false);
        }
        _deathMenu.SetActive(true);
        Debug.Log(Time.timeScale = 0);
    }

    private void ActivePanel() {
        _deathPanel.SetActive(true);
        Debug.Log(Time.timeScale = 0);
    }


}
