//
//  GraphicsContext.cs
//
//  Author:
//       Patrick Gantner <patrick.m.gantner92@gmail.com>
//
//  Copyright (c) 2017 
//
//
using System;
using Glfw3;
namespace zGraphics
{
#if OPENGL
	public class OpenGLContext : IGraphicsContext
	{
		public void CloseWindow(ref IWindow window)
		{
			window.DestroyWindow();
		}

		public IWindow CreateWindow(int width, int height, string title = "Window")
		{
			var w = new GLWindow();
			return w.CreateWindow(width, height, title);
		}

		void init()
		{
			throw new NotImplementedException();
		}
	}
#elif DIRECTX

#elif APPLE_METAL

#else
	public class UnsupportedGraphicsContext
	{

	}
#endif

	public static class GraphicsContext
	{
		public static IGraphicsContext GetContext()
		{
#if OPENGL
			return new OpenGLContext();
#elif DIRECTX

#elif APPLE_METAL

#else
			return null;
#endif
		}
	}
}
