using UnityEngine;
using UdemyProject1.Inputs;
using UdemyProject1.Movements;
using UdemyProject1.Managers;

namespace UdemyProject1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _turnSpeed=10f;
        [SerializeField] float _force = 350f;
        Mover _mover;
        DefaultInput _input;
        Rotator _rotator;
        Fuel _fuel;
        public float TrunSpeed => _turnSpeed;
        public float Force => _force;
        public bool CanMove => _canMove;
        bool _canMove;
        bool _canForceUp;
        float _leftRight;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }
        private void Start()
        {
            _canMove = true;
        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
            GameManager.Instance.OnMissionSucced += HandleOnGameOver;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOver;
            GameManager.Instance.OnMissionSucced -= HandleOnGameOver;
        }
        private void Update()
        {
            //Debug.Log(_input.LeftRight);
            if (!_canMove) return;

            if (_input.IsForceUp&&!_fuel.IsEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.01f);
            }
            _leftRight = _input.LeftRight;
        }
        private void FixedUpdate()
        {
            if (_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }
            _rotator.FixedTick(_leftRight);
        }

        private void HandleOnGameOver()
        {
            _canMove = false;
            _canForceUp = false;
            _leftRight = 0f;
            _fuel.FuelIncrease(0f);
        }
    }
}

