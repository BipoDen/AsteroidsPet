using _Project.Logic.Camera;
using _Project.Logic.Gameplay;
using _Project.Logic.Input;
using UnityEngine;
using Zenject;

namespace _Project.Logic.Installers
{
    public class GameplayInstaller : MonoInstaller
    {
        [SerializeField] private SpaceShip _playerShip;
        [SerializeField] private CameraFollow _cameraFollow;
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<DesktopInput>().AsSingle();
            _cameraFollow.Initialization(_playerShip.transform);
        }
    }
}