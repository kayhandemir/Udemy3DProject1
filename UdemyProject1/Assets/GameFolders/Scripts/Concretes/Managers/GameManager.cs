using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UdemyProject1.Abstracts.Utilities;

namespace UdemyProject1.Managers
{
    public class GameManager :SingletonObject<GameManager>
    {
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;
        private void Awake()
        {
            SingLetonThisGameObject(this);
        }
        public void GameOver()
        {
            OnGameOver?.Invoke();
        }
        public void MissionSucced()
        {
            OnMissionSucced?.Invoke();
        }
        public void LoadLevelScene(int levelIndex=0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }
        IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            SoundManager.Instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+levelIndex);
            SoundManager.Instance.PlaySound(2);
        }
        public void LoadMenu()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }
        IEnumerator LoadMenuSceneAsync()
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.PlaySound(1);
        }
        public void Exit()
        {
            Debug.Log("Oyundan çýktýn!");
            Application.Quit();
        }
    }
}

