using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();

        }

        private void SetUpGame()
        {
            List<string> Emoji = new List<string>()
            {
                "😊", "😊",
                "😂" , "😂",
                "🤣", "🤣",
                "❤", "❤",
                "😒", "😒",
                "👍", "👍",
                "✌", "✌",
                "😃", "😃",
                "😢", "😢",
                "✔", "✔",
            };

            Random random = new Random();
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(Emoji.Count);
                string nextEmoji = Emoji[index];
                textBlock.Text = nextEmoji;
                Emoji.RemoveAt(index);
            }


        }
    }
}
