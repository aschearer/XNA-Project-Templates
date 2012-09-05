using System;

namespace $safeprojectname$
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Win7Main game = new Win7Main())
            {
                game.Run();
            }
        }
    }
#endif
}

