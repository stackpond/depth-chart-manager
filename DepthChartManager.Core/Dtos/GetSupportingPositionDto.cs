﻿using System;

namespace DepthChartManager.Core.Dtos
{
    public class GetSupportingPositionDto
    {
        public Guid LeagueId { get; set; }
        public string SupportingPositionName { get; set; }
    }
}