using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace UIFrameworkExample.Example
{
    public class ModalWindowView: MonoBehaviour
    {
        [SerializeField] private GameObject rootWindow;
        private const float TRANSITION_DURATION = 0.5f;
        private bool isOpening;
        private bool isClosing;
        
        public async void Open()
        {
            if (isOpening) return;
            isOpening = true;
            rootWindow.SetActive(true);
            await transform.DOScale(1f, TRANSITION_DURATION).ToUniTask();
            isOpening = false;
        }

        public async void Close()
        {
            if(isClosing) return;
            isClosing = true;
            await transform.DOScale(0f, TRANSITION_DURATION).ToUniTask();
            rootWindow.SetActive(false);
            isClosing = false;
        }
    }
}