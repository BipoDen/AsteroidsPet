using _Project.Logic.Input;
using Zenject;

namespace _Project.Logic.Installers
{
    public class GameplayInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInput>().To<DesktopInput>().FromNew().AsSingle();
        }
    }
}