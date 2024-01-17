using Example;
using Zenject;

namespace UIFrameworkExample.Example
{
    public class SceneInstaller: MonoInstaller
    {
        public override void InstallBindings()
        {
            BindBooster();
        }

        private void BindBooster()
        {
            Container.Bind<IBooster>().To<Booster>().AsSingle();
        }
    }
}