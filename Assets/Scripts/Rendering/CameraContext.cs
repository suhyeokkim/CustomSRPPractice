using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace Rendering
{
    public class CameraContext : IDisposable
    {
        public Camera camera;
        public CommandBuffer commandBuffer;

        public CameraContext(Camera camera)
        {
            this.camera = camera;
            commandBuffer = CommandBufferPool.Get();
        }

        public void Dispose()
        {
            CommandBufferPool.Release(commandBuffer);
        }
    }
}