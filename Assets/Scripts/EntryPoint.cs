using Example;
using UIFramework;
using UnityEngine;
using Zenject;

namespace UIFrameworkExample.Example
{
    public class EntryPoint: MonoBehaviour, IInitializable
    {
        [SerializeField] private MonoWindow rootWindow;
        private IBooster booster;

        [Inject]
        private void Construct(IBooster booster)
        {
            this.booster = booster;
        }
        
        public void Initialize()
        {
            booster.Amount.Value = 10;
            rootWindow.Initialize();
        }
    }
}