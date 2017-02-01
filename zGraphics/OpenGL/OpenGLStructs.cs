//
//  OpenGLStructs.cs
//
//  Author:
//       Patrick Gantner <patrick.m.gantner92@gmail.com>
//
//  Copyright (c) 2017 
//
//

#if OPENGL

using System;
using System.Runtime.InteropServices;
namespace zGraphics
{
	public static partial class zOpenGL
	{
		#region zGLWindow
		/// <summary>
		/// zGL wrapper for Window struct
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct zGLWindow : IEquatable<zGLWindow>
		{
			public static readonly zGLWindow None = new zGLWindow(IntPtr.Zero);

			public IntPtr Ptr;

			internal zGLWindow(IntPtr ptr)
			{
				Ptr = ptr;
			}

			public bool Equals(zGLWindow other)
			{
				return Ptr == other.Ptr;
			}

			public override bool Equals(object obj)
			{
				if (obj is zGLWindow)
				{
					return Equals((zGLWindow)obj);
				}
				return false;
			}

			public override string ToString() => Ptr.ToString();
			public override int GetHashCode() => Ptr.GetHashCode();

			public static bool operator ==(zGLWindow a, zGLWindow b) => a.Equals(b);
			public static bool operator !=(zGLWindow a, zGLWindow b) => !a.Equals(b);

			public static implicit operator bool(zGLWindow w) => w.Ptr != IntPtr.Zero;
		}
		#endregion

		#region zGLMonitor
		[StructLayout(LayoutKind.Sequential)]
		public struct zGLMonitor : IEquatable<zGLMonitor>
		{
			public static readonly zGLMonitor None = new zGLMonitor(IntPtr.Zero);

			public IntPtr Ptr;

			public zGLMonitor(IntPtr ptr)
			{
				Ptr = ptr;
			}

			public bool Equals(zGLMonitor other)
			{
				return Ptr == other.Ptr;
			}
			public override bool Equals(object obj)
			{
				if (obj is zGLMonitor)
				{
					return Equals((zGLMonitor)obj);
				}
				return false;
			}

			public override string ToString() => Ptr.ToString();
			public override int GetHashCode() => Ptr.GetHashCode();

			public static bool operator ==(zGLMonitor a, zGLMonitor b) => a.Equals(b);
			public static bool operator !=(zGLMonitor a, zGLMonitor b) => !a.Equals(b);

			public static implicit operator bool(zGLMonitor m) => m.Ptr != IntPtr.Zero;
		}
		#endregion

		#region zGLVideoMode
		[StructLayout(LayoutKind.Sequential)]
		public struct zGLVideoMode : IEquatable<zGLVideoMode>
		{
			public IntPtr Ptr;
			public int width, height;
			public int

			public bool Equals(zGLVideoMode other)
			{
				return Ptr == other.Ptr;
			}
		}
		#endregion
	}
}

#endif
