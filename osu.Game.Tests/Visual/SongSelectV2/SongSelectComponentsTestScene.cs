// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Testing;
using osu.Game.Beatmaps;
using osu.Game.Overlays;

namespace osu.Game.Tests.Visual.SongSelectV2
{
    public abstract partial class SongSelectComponentsTestScene : OsuTestScene
    {
        protected Container ComponentContainer = null!;

        private Container? resizeContainer;
        private float relativeWidth;

        [Cached]
        protected readonly OverlayColourProvider ColourProvider = new OverlayColourProvider(OverlayColourScheme.Aquamarine);

        /// <summary>
        /// The beatmap. Can be local/online depending on the context.
        /// </summary>
        [Cached(typeof(IBindable<IBeatmapInfo?>))]
        protected readonly Bindable<IBeatmapInfo?> BeatmapInfo = new Bindable<IBeatmapInfo?>();

        [BackgroundDependencyLoader]
        private void load()
        {
            AddSliderStep("change relative width", 0, 1f, 0.5f, v =>
            {
                if (resizeContainer != null)
                    resizeContainer.Width = v;

                relativeWidth = v;
            });
        }

        protected override void LoadComplete()
        {
            base.LoadComplete();

            // mimics song select's `WorkingBeatmap` binding
            Beatmap.BindValueChanged(b =>
            {
                BeatmapInfo.Value = b.NewValue.BeatmapInfo;
            });
        }

        [SetUpSteps]
        public virtual void SetUpSteps()
        {
            AddStep("reset dependencies", () =>
            {
                Beatmap.SetDefault();
                SelectedMods.SetDefault();
                BeatmapInfo.Value = null;
            });

            AddStep("set content", () =>
            {
                Child = resizeContainer = new Container
                {
                    RelativeSizeAxes = Axes.X,
                    AutoSizeAxes = Axes.Y,
                    Padding = new MarginPadding(10),
                    Width = relativeWidth,
                    Children = new Drawable[]
                    {
                        new Box
                        {
                            RelativeSizeAxes = Axes.Both,
                            Colour = ColourProvider.Background5,
                        },
                        ComponentContainer = new Container
                        {
                            RelativeSizeAxes = Axes.X,
                            AutoSizeAxes = Axes.Y,
                            Padding = new MarginPadding(10),
                        }
                    }
                };
            });
        }
    }
}
