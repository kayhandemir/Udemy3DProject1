using UnityEngine;
using UdemyProject1.Managers;
using UdemyProject1.Controllers;

namespace UdemyProject1.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour
    {
        public void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();
            if (player?.gameObject&&player.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

