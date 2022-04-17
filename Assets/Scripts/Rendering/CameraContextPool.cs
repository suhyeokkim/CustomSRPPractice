using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Rendering
{
    public class CameraContextPool : Dictionary<Camera, CameraContext>, IDisposable
    {
        public CameraContext Get(Camera camera)
        {
            if (!TryGetValue(camera, out var context))
            {
                context = new CameraContext(camera);
                Add(camera, context);
            }

            return context;
        }

        public void Dispose()
        {
            for (var i = 0; i < Count; i++)
            {
                var value = this.ElementAt(i);
                value.Value.Dispose();
            }
            
            Clear();
        }
    }
}