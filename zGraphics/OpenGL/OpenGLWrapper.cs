//
//  OpenGLWrapper.cs
//
//  Author:
//       Patrick Gantner <patrick.m.gantner92@gmail.com>
//
//  Copyright (c) 2017 
//
//

#if OPENGL // only compile if using OpenGL

using System;
using System.Runtime.InteropServices;
namespace zGraphics
{
	public static partial class zOpenGL
	{
		const string libName = "glfw3";

		/** glfwInit **/
		[DllImport(libName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "glfwInit")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool Init();

		/** glfwTerminate **/
		[DllImport(libName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "glfwTerminate")]
		public static extern void Terminate();

		/** glfwCreateWindow **/
		[DllImport(libName, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStruct)]
		static extern zGlWindow glfwCreateWindow(int width, int height, IntPtr title, IntPtr monitor, IntPtr share);

		/** glfwGetPrimaryMonitor **/
	}
}

#endif
