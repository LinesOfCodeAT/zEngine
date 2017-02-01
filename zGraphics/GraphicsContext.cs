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
namespace zGraphics
{
#if OPENGL
	public class OpenGLContext // : IGraphicsContext
	{
		
	}
#elif DIRECTX

#elif APPLE_METAL

#else
	public class UnsupportedGraphicsContext
	{

	}
#endif
}
