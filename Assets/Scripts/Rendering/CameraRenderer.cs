using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace Rendering
{
    public static class CameraRenderer
    {
        public static void Render(ScriptableRenderContext context, CameraContext cameraContext)
        {
            var camera = cameraContext.camera;
            
            context.SetupCameraProperties(camera);
            if (!camera.TryGetCullingParameters(false, out var properties))
                return;
            
            var cullingResults = context.Cull(ref properties);
            var sortSettings = new SortingSettings(camera);
            var drawSettings = new DrawingSettings(new ShaderTagId("FORWARDBASE"), sortSettings);
            var filterSettings = new FilteringSettings(RenderQueueRange.all);
            
            context.DrawRenderers(cullingResults, ref drawSettings, ref filterSettings);
            context.DrawSkybox(camera);
        }
    }
}