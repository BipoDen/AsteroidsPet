using System;
using UnityEngine;

namespace _Project.Logic.Camera
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private float _smoothTime = 0.25f;
        
        private Transform _target;
        private Vector3 _offset;
        private Vector3 _velocity;
        
        public void Initialization(Transform target)
        {
            _target = target;
            _offset.z = transform.position.z;
        }

        private void FixedUpdate()
        {
            Vector3 targetPosition = _target.position + _offset;
            Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, _smoothTime);
            transform.position = smoothedPosition;
        }
    }
}