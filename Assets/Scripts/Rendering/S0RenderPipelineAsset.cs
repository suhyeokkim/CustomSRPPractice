using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Rendering
{
    [CreateAssetMenu]
    public sealed class S0RenderPipelineAsset : RenderPipelineAsset
    {
        protected override RenderPipeline CreatePipeline()
        {
            return new S0RenderPipelineProxy();
        }
    }
}
