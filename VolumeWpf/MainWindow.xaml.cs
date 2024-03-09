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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VolumeWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    
        public MainWindow()
        {
            InitializeComponent();
            VolumeControl(Convert.ToInt32(volumtxt.Text));
            VolumeControl1(Convert.ToInt32(volumtxt1.Text));
        }

        private void minbtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int vol = Convert.ToInt32(volumtxt.Text);
            if (vol != 0)
            {
                vol--;
                volbl.Width = volbl.Width + 15.5;
                volcol.Width = volcol.Width - 15.5;
                volumtxt.Text=vol.ToString();
                VolumeControl(vol);
            }
        }

        private void maxbtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int vol = Convert.ToInt32(volumtxt.Text);
            if (vol != 10)
            {
                vol++;
                volbl.Width = volbl.Width - 15.5;
                volcol.Width = volcol.Width+15.5;
                volumtxt.Text = vol.ToString();
                VolumeControl(vol);
            }

        }
        public void VolumeControl(int value)
        {
            if (value < 4)
            {
                volcol.Background = Brushes.Green;
                volcol.Effect = new DropShadowEffect()
                {
                    BlurRadius = 20,
                    Color = Color.FromRgb(0, 255, 0),
                    Direction = 0,
                    Opacity = 1,
                    RenderingBias = RenderingBias.Quality,
                    ShadowDepth = 1


                };
            }
            if (value > 3 && value < 8)
            {
                volcol.Background = Brushes.Yellow;
                volcol.Effect = new DropShadowEffect()
                {
                    BlurRadius = 20,
                    Color = Color.FromRgb(225, 255, 0),
                    Direction = 0,
                    Opacity = 1,
                    RenderingBias = RenderingBias.Quality,
                    ShadowDepth = 1


                };
            }
            if (value > 7)
            {
                volcol.Background = Brushes.Red;
                volcol.Effect = new DropShadowEffect()
                {
                    BlurRadius = 20,
                    Color = Color.FromRgb(255, 0, 0),
                    Direction = 0,
                    Opacity = 1,
                    RenderingBias = RenderingBias.Quality,
                    ShadowDepth = 1


                };
            }
          
           
            
        }
        public void VolumeControl1(int value)
        {
            if (value < 4)
            {
                volcol1.Background = Brushes.LightBlue;
                volcol1.Effect = new DropShadowEffect()
                {
                    BlurRadius = 20,
                    Color = Color.FromRgb(92, 247, 238),
                    Direction = 0,
                    Opacity = 1,
                    RenderingBias = RenderingBias.Quality,
                    ShadowDepth = 1


                };
            }
            if (value > 3 && value < 8)
            {
                volcol1.Background = Brushes.Aqua;
                volcol1.Effect = new DropShadowEffect()
                {
                    BlurRadius = 20,
                    Color = Color.FromRgb(0, 210, 255),
                    Direction = 0,
                    Opacity = 1,
                    RenderingBias = RenderingBias.Quality,
                    ShadowDepth = 1


                };
            }
            if (value > 7)
            {
                volcol1.Background = Brushes.Blue;
                volcol1.Effect = new DropShadowEffect()
                {
                    BlurRadius = 20,
                    Color = Color.FromRgb(0, 0, 255),
                    Direction = 0,
                    Opacity = 1,
                    RenderingBias = RenderingBias.Quality,
                    ShadowDepth = 1


                };
            }



        }

        private void maxbtn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            int vol = Convert.ToInt32(volumtxt1.Text);
            if (vol != 10)
            {
                vol++;
                volbl1.Width = volbl1.Width - 15.5;
                volcol1.Width = volcol1.Width + 15.5;
                volumtxt1.Text = vol.ToString();
                VolumeControl1(vol);
            }
        }

        private void minbtn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int vol = Convert.ToInt32(volumtxt1.Text);
            if (vol != 0)
            {
                vol--;
                volbl1.Width = volbl1.Width + 15.5;
                volcol1.Width = volcol1.Width - 15.5;
                volumtxt1.Text = vol.ToString();
                VolumeControl1(vol);
            }
        }
    }
}
