﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SteamWebAPI2.Models.TF2;

namespace SteamWebAPI2.Interfaces
{
    public interface ITFItems
    {
        Task<IReadOnlyCollection<GoldenWrench>> GetGoldenWrenchesAsync();
    }
}