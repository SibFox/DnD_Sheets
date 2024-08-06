using DnDSheets.Structures;
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

namespace DnDSheets.Pages
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        //Image slachImage = new Image();
        //Image pierceImage = new Image();
        //Image crushImage = new Image();
        List<DamageType> damageTypes = new List<DamageType>();
        public TestPage()
        {
            InitializeComponent();

            //slachImage.Width = 18; slachImage.Height = 18;
            //slachImage.Stretch = Stretch.Uniform;
            //slachImage.Source = new BitmapImage(new Uri(@"C:\Users\Petrush\Desktop\Own C#\DnDSheets\Resources\ico_dmg_slach.png", UriKind.Absolute));

            //pierceImage.Width = 18; pierceImage.Height = 18;
            //pierceImage.Stretch = Stretch.Uniform;
            //pierceImage.Source = new BitmapImage(new Uri(@"C:\Users\Petrush\Desktop\Own C#\DnDSheets\Resources\ico_dmg_pierce.png", UriKind.Absolute));

            //crushImage.Width = 18; crushImage.Height = 18;
            //crushImage.Stretch = Stretch.Uniform;
            //crushImage.Source = new BitmapImage(new Uri(@"C:\Users\Petrush\Desktop\Own C#\DnDSheets\Resources\ico_dmg_crush.png", UriKind.Absolute));

            damageTypes.Add(new DamageType("Рубящий", "руб. ур.", new Uri(@"C:\Users\Petrush\Desktop\Own C#\DnDSheets\Resources\ico_dmg_slach.png", UriKind.Absolute)));
            damageTypes.Add(new DamageType("Колющий", "кол. ур.", new Uri(@"C:\Users\Petrush\Desktop\Own C#\DnDSheets\Resources\ico_dmg_pierce.png", UriKind.Absolute)));
            damageTypes.Add(new DamageType("Дробящий", "дрб. ур.", new Uri(@"C:\Users\Petrush\Desktop\Own C#\DnDSheets\Resources\ico_dmg_crush.png", UriKind.Absolute)));

            foreach (DamageType damageType in damageTypes)
            {
                cmbDamage.Items.Add($"{damageType.Name} ({damageType.Name_Short})");
            }

            cmbDamage.SelectedIndex = 0;
            //Image image = new Image();
            //InlineUIContainer container = new InlineUIContainer(image);
            //Paragraph paragraph = new Paragraph(container);
            //damage.Document.Blocks.Add(paragraph);
        }

        private void buttonApply_Click(object sender, RoutedEventArgs e)
        {
            blockDamage.Text = string.Empty;
            richDamage.Document.Blocks.Clear();
            int selected = cmbDamage.SelectedIndex;
            int fontSize = 18;
            //Image image = new Image()
            //{
            //    Source = new BitmapImage(damageTypes[selected].uriSource),
            //    Margin = new Thickness(2, 10, 0, -3),
            //    Width = 16,
            //    Height = 16,
            //    Stretch = Stretch.Uniform
            //};
            //Ставить один и тот же Image(элемент) не прокатывает, поскольку становится дочерним элементом того, которому он ставится первым
            //Работает только создавать новый экземпляр с теми же свойствами каждый раз
            blockDamage.FontSize = fontSize;
            richDamage.FontSize = fontSize;
            blockDamage.Inlines.Add($"{boxDamage.Text}");
            blockDamage.Inlines.Add(new InlineUIContainer(new Image()
            {
                Source = new BitmapImage(damageTypes[selected].uriSource),
                Margin = new Thickness(blockDamage.FontSize / 12, 0, 0, -blockDamage.FontSize / 2.5),
                Width = blockDamage.FontSize * 1.5,
                Height = blockDamage.FontSize * 1.5,
                Stretch = Stretch.Uniform
            }));
            blockDamage.Inlines.Add($" ({damageTypes[selected].Name_Short})");
            //Подобное не работает
            //blockDamage.Inlines.Add($"{boxDamage.Text} {new InlineUIContainer(new Image() { Source = new BitmapImage(damageTypes[selected].uriSource), Margin = new Thickness(2, 10, 0, -3), Width = 16, Height = 16, Stretch = Stretch.Uniform })} ({damageTypes[selected].Name_Short})");

            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add($"{boxDamage.Text}");
            paragraph.Inlines.Add(new InlineUIContainer(new Image()
            {
                Source = new BitmapImage(damageTypes[selected].uriSource),
                Margin = new Thickness(2, 0, 0, -5),
                Width = richDamage.FontSize * 1.5,
                Height = richDamage.FontSize * 1.5,
                Stretch = Stretch.Uniform
            }));
            paragraph.Inlines.Add($" ({damageTypes[selected].Name_Short})");
            richDamage.Document.Blocks.Add(paragraph);
        }
    }
}
