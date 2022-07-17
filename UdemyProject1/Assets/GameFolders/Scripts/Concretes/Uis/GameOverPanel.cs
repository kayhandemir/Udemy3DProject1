using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject1.Managers;

namespace UdemyProject1.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene();
        }
        public void NoClicked()
        {
            GameManager.Instance.LoadMenu();
        }
    }
}

