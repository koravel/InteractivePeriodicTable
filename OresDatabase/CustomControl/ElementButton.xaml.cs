using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OresDatabase.CustomControl
{
    /// <summary>
    /// Interaction logic for ElementButton.xaml
    /// </summary>
    public partial class ElementButton : UserControl
    {


        public Style ElementStyleProperty
        {
            get { return (Style)GetValue(ElementStylePropertyProperty); }
            set { SetValue(ElementStylePropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ElementStyleProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ElementStylePropertyProperty =
            DependencyProperty.Register("ElementStyleProperty", typeof(Style), typeof(ElementButton), new PropertyMetadata(new Style()));



        public string ElementTextProperty
        {
            get { return (string)GetValue(ElementTextPropertyProperty); }
            set { SetValue(ElementTextPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ElementTextProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ElementTextPropertyProperty =
            DependencyProperty.Register("ElementTextProperty", typeof(string), typeof(ElementButton), new PropertyMetadata("Nil"));



        public string ElementNumberProperty
        {
            get { return (string)GetValue(ElementNumberPropertyProperty); }
            set { SetValue(ElementNumberPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ElementNumberProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ElementNumberPropertyProperty =
            DependencyProperty.Register("ElementNumberProperty", typeof(string), typeof(ElementButton), new PropertyMetadata("0"));




        public ElementButton()
        {
            InitializeComponent();
        }
    }
}
