using System;
namespace zGraphics
{
	public interface IWindow
	{
		void setTitle(string title);
		void setWidth(int width);
		void setHeight(int height);
		void setSize(int width, int height);
	}
}
