using UdemyProject1.Abstracts.Controllers;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _factor;
        [SerializeField] float _speed = 1f;
        Vector3 _startPosition;
        const float FullCircle = Mathf.PI * 2f;
        private void Awake()
        {
            _startPosition = transform.position;
        }
        private void Update()
        {
            float cyle = Time.time / _speed;
            float sinWave = cyle * FullCircle;
            _factor = Mathf.Abs(Mathf.Sin(sinWave));
            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;
        }
    }
}

