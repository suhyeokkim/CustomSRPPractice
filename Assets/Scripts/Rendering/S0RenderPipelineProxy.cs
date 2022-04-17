using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace Rendering
{
    public class S0RenderPipelineProxy : DisposableRenderPipeline
    {
        private readonly S0RenderContext renderContext = new();
        
        protected override void Render(ScriptableRenderContext context, Camera[] cameras)
        {
            S0RenderPipeline.Render(context, cameras, renderContext);
        }

        public override void Dispose()
        {
            renderContext.Dispose();
        }
    }
}