﻿using System.Collections.Generic;

public class Grass : Environment
{
    public override Dictionary<FarmingItemData, int> Farming(out Define.FarmingType farmingType)
    {
        return base.Farming(out farmingType);
    }
}