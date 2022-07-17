using UnityEngine;
using UdemyProject1.Managers;

namespace UdemyProject1.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
        public void ExitClick()
        {
            GameManager.Instance.Exit();
        }
    }
}

