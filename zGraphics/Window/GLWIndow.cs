//
//  GLWIndow.cs
//
//  Author:
//       Patrick Gantner <patrick.m.gantner92@gmail.com>
//
//  Copyright (c) 2017 
//
//

#if OPENGL
using System;
using Glfw3;

namespace zGraphics
{
	public class GLWindow : IWindow
	{
		private Glfw.Window? glfwWindow;
		private int width, height;
		private string title;

		public GLWindow()
		{
			glfwWindow = null;
		}
		private GLWindow(Glfw.Window window)
		{
			glfwWindow = window;
		}

		public IWindow CreateWindow(int width, int height, string title)
		{
			this.width = width;
			this.height = height;
			this.title = title;
			var window = Glfw.CreateWindow(width, height, title);
			return new GLWindow(window);
		}

		public void DestroyWindow()
		{
			if (glfwWindow.HasValue)
			{
				Glfw.DestroyWindow(glfwWindow.Value);
			}
		}

		public void setHeight(int height)
		{
			if (glfwWindow.HasValue)
			{
				this.height = height;
				Glfw.SetWindowSize(glfwWindow.Value, width, height);
			}
		}

		public void setSize(int width, int height)
		{
			if (glfwWindow.HasValue)
			{
				this.height = height;
				this.width = width;
				Glfw.SetWindowSize(glfwWindow.Value, width, height);
			}
		}

		public void setTitle(string title)
		{
			if (glfwWindow.HasValue)
			{
				this.title = title;
				Glfw.SetWindowTitle(glfwWindow.Value, title);
			}
		}

		public void setWidth(int width)
		{
			if (glfwWindow.HasValue)
			{
				this.width = width;
				Glfw.SetWindowSize(glfwWindow.Value, width, height);
			}
		}
	}
}

#endif
