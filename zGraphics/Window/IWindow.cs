using System;
namespace zGraphics
{
	public interface IWindow
	{
		IWindow CreateWindow(int width, int height, string title);
		void DestroyWindow();
		void setTitle(string title);
		void setWidth(int width);
		void setHeight(int height);
		void setSize(int width, int height);
	}
}
