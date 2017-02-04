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
		/// <summary>
		/// Creates the window.
		/// </summary>
		/// <returns>id of the window</returns>
		/// <param name="width">Width.</param>
		/// <param name="height">Height.</param>
		/// <param name="title">Title.</param>
		int CreateWindow(int width, int height, string title = "Window", bool makeCurrent = true);

		/// <summary>
		/// closes window
		/// </summary>
		/// <param name="id">Identifier.</param>
		void CloseWindow(int id);

	}
}
