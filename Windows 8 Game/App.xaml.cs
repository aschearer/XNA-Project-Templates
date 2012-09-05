using Microsoft.Xna.Framework;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

namespace $safeprojectname$
{
    sealed partial class App : Application
    {
        private SharedGraphicsDeviceManager deviceManager;

        public App()
        {
            this.InitializeComponent();
            this.InitializeXnaApplication();
            this.Suspending += this.OnSuspending;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            MainPage rootFrame = Window.Current.Content as MainPage;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new MainPage();

                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            // Ensure the current window is active
            Window.Current.Activate();
        }

        private void InitializeXnaApplication()
        {
            this.deviceManager = new SharedGraphicsDeviceManager();
        }

        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
