﻿// <copyright file="HeroWalk.cs" company="Late Start Studio">
// Copyright (C) Late Start Studio
// This file is subject to the terms and conditions of the MIT license specified in the file
// 'LICENSE.CODE.md', which is a part of this source code package.
// </copyright>

namespace LateStartStudio.Hero6.Engine.Campaigns.RitesOfPassage.Animations.Characters.Hero.Walk
{
    using LateStartStudio.Hero6.Engine.Campaigns.Animations;

    public class HeroWalk : CharacterAnimationModule
    {
        private readonly ICampaigns campaigns;

        public HeroWalk(ICampaigns campaigns)
        {
            this.campaigns = campaigns;
        }

        public override string Name => "Hero Walk Animation";

        protected override void Initialize()
        {
            base.Initialize();

            CenterDown = campaigns.Current.GetAnimation<HeroWalkCenterDown>();
            CenterUp = campaigns.Current.GetAnimation<HeroWalkCenterUp>();
            LeftCenter = campaigns.Current.GetAnimation<HeroWalkLeftCenter>();
            LeftDown = campaigns.Current.GetAnimation<HeroWalkLeftDown>();
            LeftUp = campaigns.Current.GetAnimation<HeroWalkLeftUp>();
            RightCenter = campaigns.Current.GetAnimation<HeroWalkRightCenter>();
            RightDown = campaigns.Current.GetAnimation<HeroWalkRightDown>();
            RightUp = campaigns.Current.GetAnimation<HeroWalkRightUp>();
        }
    }
}
