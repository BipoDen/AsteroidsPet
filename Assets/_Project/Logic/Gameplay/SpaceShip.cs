using UnityEngine;

namespace _Project.Logic.Gameplay
{
    public class SpaceShip : MonoBehaviour
    {
        [SerializeField] private float _rotateSpeed;
        [SerializeField] private float _moveSpeed;

        private Rigidbody2D _rigidbody2D;
        
        void Update()
        {
            /*if (Input.GetKey(KeyCode.A))
            {
                transform.rotation *= Quaternion.Euler(0f, 0f, rotateSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.rotation *= Quaternion.Euler(0f, 0f, -rotateSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.up * (moveSpeed * Time.deltaTime);
            }

            if (Input.GetMouseButtonDown(0))
            {
                
            }*/
        }

        private void FixedUpdate()
        {
            
        }
        
        private void TryMove(float input)
        {
            Vector2 forwardForce = -transform.up * _moveSpeed * input * Time.fixedDeltaTime;
            _rigidbody2D.linearVelocity = forwardForce;
        }

        private void Shoot()
        {
            
        }
    }
}
