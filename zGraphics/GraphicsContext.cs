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
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace zGraphics
{
#if OPENGL
	using OpenGL;
	public class OpenGLContext : IGraphicsContext
	{
		private Dictionary<int, Glfw.Window> windows;
		private Dictionary<int, CancellationTokenSource> windowThreads;

		private TaskFactory tF;

		internal OpenGLContext()
		{
			windows = new Dictionary<int, Glfw.Window>();
			windowThreads = new Dictionary<int, CancellationTokenSource>();
			tF = new TaskFactory();
		}

		~OpenGLContext()
		{
			foreach (var t in windowThreads)
			{
				t.Value.Cancel();
			}
			Glfw.Terminate();
		}

		public void CloseWindow(int id)
		{
			Glfw.Window w;
			if (windows.TryGetValue(id, out w))
			{
				Glfw.DestroyWindow(w);
				windows.Remove(id);
				CancellationTokenSource cts;
				if (windowThreads.TryGetValue(id, out cts))
				{
					cts.Cancel();
				}
			}
		}

		/// <summary>
		/// Creates the window.
		/// </summary>
		/// <returns>id for the window</returns>
		/// <param name="width">Width.</param>
		/// <param name="height">Height.</param>
		/// <param name="title">Title.</param>
		/// <param name="makeCurrent">If set to <c>true</c> make current.</param>
		public int CreateWindow(int width, int height, string title = "Window", bool makeCurrent = true)
		{
			var window = Glfw.CreateWindow(width, height, title);
			var id = window.GetHashCode();
			windows.Add(id, window);
			if (makeCurrent)
			{
				Glfw.MakeContextCurrent(window);
			}
			var cts = new CancellationTokenSource();
			var tok = cts.Token;
			tF.StartNew(() => startWindowThread(window), tok);
			windowThreads.Add(id, cts);
			return id;
		}

		internal void init()
		{
			if (!Glfw.Init())
			{
				throw new Exception("Unable to initialize GLFW!");
			}
		}

		/// <summary>
		/// Starts the window thread.
		/// </summary>
		/// <param name="w">window</param>
		private void startWindowThread(Glfw.Window w)
		{
			while (!Glfw.WindowShouldClose(w)) {
				Gl.Clear(ClearBufferMask.ColorBufferBit);
				Glfw.SwapBuffers(w);
				Glfw.PollEvents();
			}
			return;
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
			var ctx = new OpenGLContext();
			ctx.init();
			return ctx;
#elif DIRECTX

#elif APPLE_METAL

#else
			return null;
#endif
		}
	}
}
