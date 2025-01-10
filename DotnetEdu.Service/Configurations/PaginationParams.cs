﻿using DotnetEdu.Service.Helpers;

namespace DotnetEdu.Service.Configurations;

public class PaginationParams
{
    public PaginationParams()
    {
        PageIndex = EnvironmentHelper.PageIndex;
        PageSize = EnvironmentHelper.PageSize;
    }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
}
