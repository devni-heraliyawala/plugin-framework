using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PluginFramework.Services.PluginService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PluginFramework.Controllers
{
    [Route("api/[controller]")]
    public class PluginController : Controller
    {
        private static readonly List<ImageFeatureSet> imageSetWithFeatures = new List<ImageFeatureSet>
        {
            new ImageFeatureSet
            {
                ImageName = "1",
                Image = null,
                EffectsWithConfiguration = new List<EffectsWithConfiguration>
                {
                    new EffectsWithConfiguration{Effect = Effect.Blur, EffectKind=EffectKind.Slider, EffectValue=10},
                    new EffectsWithConfiguration{Effect = Effect.GrayScale, EffectKind=EffectKind.Slider, EffectValue=5},
                    new EffectsWithConfiguration{Effect = Effect.Resize, EffectKind=EffectKind.InputBox, EffectValue=60}
                }
            },
            new ImageFeatureSet
            {
                ImageName = "2",
                Image = null,
                EffectsWithConfiguration = new List<EffectsWithConfiguration>
                {
                    new EffectsWithConfiguration{Effect = Effect.Blur, EffectKind=EffectKind.Slider, EffectValue=20},
                    new EffectsWithConfiguration{Effect = Effect.Resize, EffectKind=EffectKind.InputBox, EffectValue=70}
                }
            },
            new ImageFeatureSet
            {
                ImageName = "3",
                Image = null,
                EffectsWithConfiguration = new List<EffectsWithConfiguration>
                {
                    new EffectsWithConfiguration{Effect = Effect.Resize, EffectKind=EffectKind.InputBox, EffectValue=30},
                    new EffectsWithConfiguration{Effect = Effect.GrayScale, EffectKind=EffectKind.Slider, EffectValue=50}
                }
            }
        };
        private readonly IPluginService _pluginService;
        public PluginController(IPluginService pluginService)
        {
            _pluginService = pluginService;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<string>>>> ImageManipulation([FromBody] List<ImageFeatureSet> features)
        {
            features = imageSetWithFeatures;

            var result = await _pluginService.ImageManipulation(features);
            return Ok(result);
        }
    }
}

