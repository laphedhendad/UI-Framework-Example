using Example;
using UIFramework;
using UIFrameworkExample.Example;
using UnityEngine;
using Zenject;

namespace UIFrameworkExample
{
    public class BoostersBinder : MonoBinder
    {
        [SerializeField] private BoosterButton boosterButton;
        [SerializeField] private ModalWindowView buyBoosterWindow;
        
        private IBooster booster;
        private BoosterPresenter boosterPresenter;
        
        [Inject]
        private void Construct(IBooster booster)
        {
            this.booster = booster;
        }
        
        public override void Bind()
        {
            boosterPresenter = new BoosterPresenter(boosterButton, buyBoosterWindow);
            boosterPresenter.SubscribeModel(booster.Amount);
        }

        protected override void Unbind()
        {
            boosterPresenter?.Dispose();
        }
    }
}
