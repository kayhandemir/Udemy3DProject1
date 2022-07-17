using UnityEngine;
using UdemyProject1.Managers;
namespace UdemyProject1.Uis
{
    public class WinConditionPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }
}

