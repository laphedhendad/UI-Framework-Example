using Example;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UIFrameworkExample.Example
{
    public class BuyBoostersBinder: MonoBinder
    {
        [SerializeField] private Button underLayerExitButton;
        [SerializeField] private Button exitButton;
        [SerializeField] private ModalWindowView modalWindow;
        [SerializeField] private Button buyButton;
        
        private IBooster booster;

        [Inject]
        private void Construct(IBooster booster)
        {
            this.booster = booster;
        }
        
        public override void Bind()
        {
            underLayerExitButton.onClick.AddListener(modalWindow.Close);
            exitButton.onClick.AddListener(modalWindow.Close);
            buyButton.onClick.AddListener(BuyBooster);
        }

        protected override void Unbind()
        {
            underLayerExitButton.onClick.RemoveListener(modalWindow.Close);
            exitButton.onClick.RemoveListener(modalWindow.Close);
            buyButton.onClick.RemoveListener(BuyBooster);
        }

        private void BuyBooster()
        {
            booster.Amount.Value++;
        }
    }
}