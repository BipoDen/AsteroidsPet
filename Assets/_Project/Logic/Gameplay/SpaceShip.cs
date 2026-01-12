using System;
using _Project.Logic.Interfaces;
using UnityEngine;
using Zenject;

namespace _Project.Logic.Gameplay
{
    public class SpaceShip : MonoBehaviour
    {
        private IInput _input;
        [SerializeField] private float _rotateSpeed;
        [SerializeField] private float _moveAcceleration;
        [SerializeField] private float _maxSpeed;

        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        [Inject]
        private void Construct(IInput input)
        {
            _input = input;
        }
        

        private void FixedUpdate()
        {
            TryMove(_input.Move());
            TryRotate(_input.Rotate());
        }
        
        private void TryMove(float input)
        {
            if (input <= 0f)
                return;
            
            Vector2 forwardForce = transform.up * _moveAcceleration * input;
            _rigidbody2D.AddForce(forwardForce, ForceMode2D.Force);
                
            if (_rigidbody2D.linearVelocity.magnitude > _maxSpeed)
            {
                _rigidbody2D.linearVelocity =
                    _rigidbody2D.linearVelocity.normalized * _maxSpeed;
            }
        }

        private void TryRotate(float input)
        {
            if (!Mathf.Approximately(input, 0f))
            { 
                float rotationAngle = -input * _rotateSpeed * Time.fixedDeltaTime;
                _rigidbody2D.MoveRotation(_rigidbody2D.rotation + rotationAngle);
            }
        }

        private void Shoot()
        {
            
        }
    }
}
