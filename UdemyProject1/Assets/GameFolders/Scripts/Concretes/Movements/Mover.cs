using UnityEngine;
using UdemyProject1.Controllers;

namespace UdemyProject1.Movements
{
    public class Mover
    {
        PlayerController _playerController;
        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
        }
        public void FixedTick()
        {
            _playerController.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.Force);
        }
    }
}
