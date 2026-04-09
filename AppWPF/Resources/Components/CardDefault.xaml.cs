using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AppWPF.Resources.Components
{
    public partial class CardDefault : UserControl
    {
        public CardDefault()
        {
            InitializeComponent();
        }

        // Propriedade para o valor da carta (A, 2, 3, ..., K)
        public static readonly DependencyProperty CardValueProperty =
            DependencyProperty.Register("CardValue", typeof(string), typeof(CardDefault), new PropertyMetadata("A"));

        public string CardValue
        {
            get => (string)GetValue(CardValueProperty);
            set => SetValue(CardValueProperty, value);
        }

        // Propriedade para as imagens do naipe
        public static readonly DependencyProperty SuitImagesProperty =
            DependencyProperty.Register("SuitImages", typeof(List<BitmapImage>), typeof(CardDefault), new PropertyMetadata(new List<BitmapImage>()));

        public List<BitmapImage> SuitImages
        {
            get => (List<BitmapImage>)GetValue(SuitImagesProperty);
            set => SetValue(SuitImagesProperty, value);
        }
    }
}