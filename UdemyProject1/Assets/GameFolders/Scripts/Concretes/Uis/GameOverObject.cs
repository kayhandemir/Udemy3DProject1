using UnityEngine;
using UdemyProject1.Managers;

namespace UdemyProject1.Uis
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject _gameOverPanel;
        private void Awake()
        {
            if (_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(false);
            }
        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOver;
        }
        public void HandleOnGameOver()
        {
            if (!_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(true);
            }
        }
    }
}

