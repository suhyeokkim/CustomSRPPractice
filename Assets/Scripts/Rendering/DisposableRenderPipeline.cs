using System;
using UnityEngine.Rendering;

namespace Rendering
{
    public abstract class DisposableRenderPipeline : RenderPipeline, IDisposable
    {
        public abstract void Dispose();
    }
}