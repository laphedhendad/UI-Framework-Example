using System;
using Laphed.MVP.MonoViews;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Example
{
    public class BoosterButton: MonoView<int>
    {
        [SerializeField] private Button button;
        [SerializeField] private TMP_Text counterText;

        public event Action OnClicked;

        private void OnEnable() => button.onClick.AddListener(()=>OnClicked?.Invoke());

        public override void UpdateView(int value)
        {
            counterText.text = value.ToString();
        }

        private void OnDisable() => button.onClick.RemoveAllListeners();
    }
}