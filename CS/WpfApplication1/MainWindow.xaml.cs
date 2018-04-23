using System;
using System.Windows;
using DevExpress.Xpf.Gauges;

namespace WpfApplication1 {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void OnCreepingLineAnimationCompleted(object sender, EventArgs e) {
            BlinkingAnimation blinking = new BlinkingAnimation();
            matrix.Animation = blinking;
            digitalGaugeControl1.Text = "www.devexpress.com";
        }

    }
}
