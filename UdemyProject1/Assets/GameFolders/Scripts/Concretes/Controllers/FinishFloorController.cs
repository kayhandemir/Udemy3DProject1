using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UdemyProject1.Managers;

namespace UdemyProject1.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _fireWorks;
        [SerializeField] GameObject _finisLight;

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();
            if (player == null||!player.CanMove) return;
            if (collision.GetContact(0).normal.y == -1)
            {
                _fireWorks.gameObject.SetActive(true);
                _finisLight.gameObject.SetActive(true);
                GameManager.Instance.MissionSucced();
            }
            else
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

