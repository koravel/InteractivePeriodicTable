using System.Windows;
using System.Windows.Controls;

namespace OresDatabase
{
    class ElementDesign : FrameworkElement
    {
        private TextBlock _numberTextBlock;
        private Button _button;
        public ElementDesign()
        {
            _numberTextBlock = new TextBlock();
            _button = new Button();

            _numberTextBlock.Style = Resources["elementNumber"] as Style;
            _button.Style = Resources["elementButton"] as Style;
        }
    }
}
