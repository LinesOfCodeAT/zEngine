//
//  IGraphicsContext.cs
//
//  Author:
//       Patrick Gantner <patrick.m.gantner92@gmail.com>
//
//  Copyright (c) 2017 
//
//

namespace zGraphics
{
	public interface IGraphicsContext
	{
		IWindow CreateWindow(int width, int height, string title = "Window");

		void CloseWindow(ref IWindow window);

	}
}
