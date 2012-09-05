using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace $safeprojectname$
{
    public sealed partial class MainPage : SwapChainBackgroundPanel
    {
        private readonly GameTimer gameTimer;

        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += this.OnLoad;

            this.gameTimer = new GameTimer();
            this.gameTimer.Draw += this.OnDraw;
            this.gameTimer.Update += this.OnUpdate;
            this.gameTimer.UpdateInterval = TimeSpan.Zero;

            var services = new AppServiceProvider();
            services.AddService(typeof(IGraphicsDeviceService), SharedGraphicsDeviceManager.Current);
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            var deviceManager = SharedGraphicsDeviceManager.Current;
            deviceManager.PreferredBackBufferWidth = (int)this.ActualWidth;
            deviceManager.PreferredBackBufferHeight = (int)this.ActualHeight;
            deviceManager.SwapChainPanel = this;
            deviceManager.ApplyChanges();

            this.gameTimer.Start();
        }

        private void OnUpdate(object sender, GameTimerEventArgs e)
        {
            GameTime gameTime = new GameTime(e.TotalTime, e.ElapsedTime);
        }

        private void OnDraw(object sender, GameTimerEventArgs e)
        {
            GameTime gameTime = new GameTime(e.TotalTime, e.ElapsedTime);
        }
    }
}
