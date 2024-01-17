using Laphed.MVP;
using UIFrameworkExample.Example;

namespace Example
{
    public class BoosterPresenter: PropertyPresenter<int>
    {
        private new readonly BoosterButton view;
        private readonly ModalWindowView buyBoosterWindow;

        public BoosterPresenter(BoosterButton view, ModalWindowView buyBoosterWindow) : base(view)
        {
            this.view = view;
            this.buyBoosterWindow = buyBoosterWindow;
            this.view.OnClicked += HandleClick;
        }

        private void HandleClick()
        {
            if (model == null) return;
            if (model.Value == 0)
            {
                buyBoosterWindow.Open();
                return;
            }
            model.Value--;
        }

        public override void Dispose()
        {
            view.OnClicked -= HandleClick;
            base.Dispose();
        }
    }
}