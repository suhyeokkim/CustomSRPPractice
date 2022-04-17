using System;
using UnityEditor;
using UnityEngine.Rendering;

namespace Rendering
{
    public class S0RenderContext : IDisposable
    {
        public readonly CameraContextPool cameraContextPool;
        public CommandBuffer beforeCamera;
        public CommandBuffer afterCamera;

        public S0RenderContext()
        {
            cameraContextPool = new CameraContextPool();
            beforeCamera = CommandBufferPool.Get(ObjectNames.NicifyVariableName(nameof(beforeCamera)));
            afterCamera = CommandBufferPool.Get(ObjectNames.NicifyVariableName(nameof(afterCamera)));
        }

        public void Dispose()
        {
            CommandBufferPool.Release(beforeCamera);
            CommandBufferPool.Release(afterCamera);
            cameraContextPool.Dispose();
        }
    }
}