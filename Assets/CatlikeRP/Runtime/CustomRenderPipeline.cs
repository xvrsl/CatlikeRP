using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CustomRenderPipeline : RenderPipeline
{
    CameraRenderer renderer = new CameraRenderer();

    bool useDynamicBaching, useGPUInstancing;

    public CustomRenderPipeline(bool useDynamicBaching, bool useGPUInstancing,bool useSRPBatcher)
    {
        this.useDynamicBaching = useDynamicBaching;
        this.useGPUInstancing = useGPUInstancing;
        GraphicsSettings.useScriptableRenderPipelineBatching = useSRPBatcher;
    }
    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        foreach (Camera camera in cameras)
        {
            renderer.Render(context, camera,useDynamicBaching,useGPUInstancing);
        }
    }
}
