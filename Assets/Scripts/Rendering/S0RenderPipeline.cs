using UnityEngine;
using UnityEngine.Rendering;

namespace Rendering
{
    public static class S0RenderPipeline 
    {
        public static void Render(ScriptableRenderContext context, Camera[] cameras, S0RenderContext renderContext)
        {
            renderContext.beforeCamera.ClearRenderTarget(true, true, Color.black);
            context.ExecuteCommandBuffer(renderContext.beforeCamera);

            for (var i = 0; i < cameras.Length; i++)
            {
                CameraRenderer.Render(context, renderContext.cameraContextPool.Get(cameras[i]));
            }

            context.ExecuteCommandBuffer(renderContext.afterCamera);
            context.Submit();
        }
    }
}