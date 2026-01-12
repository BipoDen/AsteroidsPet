using _Project.Logic.Interfaces;
using UnityEngine;

namespace _Project.Logic.Input
{
    public class DesktopInput : IInput
    {
        public float Move()
        {
            var inputValue = UnityEngine.Input.GetAxisRaw("Vertical");
            return inputValue;
        }

        public float Rotate()
        {
            var  inputValue = UnityEngine.Input.GetAxisRaw("Horizontal");
            return inputValue;
        }
    }
}