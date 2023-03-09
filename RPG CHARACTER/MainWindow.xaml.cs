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

namespace RPG_CHARACTER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RPGChar _characterSheet = new RPGChar();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _characterSheet;
            updateStats();

        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Update the name
            _characterSheet.Name = textboxName2.Text;
            MessageBox.Show(_characterSheet.Name);
        }

        private void buttonRoll_Click(object sender, RoutedEventArgs e)
        {
            _characterSheet.Roll();
            updateStats();
        }

        private void updateStats()
        {
            txtStrength.Text = _characterSheet.Strength.ToString();
            txtIntelligence.Text = _characterSheet.Intelligence.ToString();
            txtWisdom.Text = _characterSheet.Wisdom.ToString();
            txtDexterity.Text = _characterSheet.Dexterity.ToString();
            txtCharisma.Text = _characterSheet.Charisma.ToString();
            txtLuck.Text = _characterSheet.Luck.ToString();
        }
    }
}
