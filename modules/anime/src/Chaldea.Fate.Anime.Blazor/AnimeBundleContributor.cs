﻿using Volo.Abp.Bundling;

namespace Chaldea.Fate.Anime.Blazor
{
    public class AnimeBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}