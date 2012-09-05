# XNA Project Templates
A collection of project templates to quickly start making games using XNA and
Visual Studio.

## Instructions
To use a template first figure out which project type you wish to deploy then:

  1. Navigate to a directory, e.g. "Portable Game"
  2. Select the directory's contents
  3. Right click and select "Send to Compressed Folder"
  4. Give the compressed folder an appropriate name, e.g. "Portable Game"
  5. Copy the compressed folder to `C:\Path\To\VisualStudio\Templates\ProjectTemplates\Visual C#`
  6. Start Visual Studio and select File > New Project
  7. Find the new template in the list and continue as normal

## Portable Game
A good place to start is the Portable Game project. This will project will
create a:

  1. Portable Class Library for common code. (Make sure to install the [Portable Class Library extension](http://visualstudiogallery.msdn.microsoft.com/b0e0b5e9-e138-410b-ad10-00cb3caf4981).)
  2. Content project to organize your game's assets.
  3. Windows 7 Desktop XNA project for your actual game.
  4. Test project to unit test classes defined in the common library.

## Windows 8 Game (Coming Soon)
Once you've created a Portable Game you may wish to add a Windows 8 project to
support the new app store. Using [MonoGame](monogame.codeplex.com/) it's
possible to target Windows 8 using most of the code written for Windows 7. To do
so you must have Visual Studio 2012 installed. This project will create a:

  1. Windows 8 project
  2. App.xaml and MainPage.xaml ready to contain your game
  3. References to MonoGame
