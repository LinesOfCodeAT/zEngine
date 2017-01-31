using System;

namespace zGraphics
{
	public class Window : IWindow
	{
		private IWindow windowImpl;

		public Window()
		{
			// check for OS type
			/* if macos */
			windowImpl = new WindowMac();
		}

		public void CreateWindow(int width, int height, string title)
		{
			windowImpl.CreateWindow(width, height, title);
		}
	}
}
