﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TappingMouseExperimentConfiguration : ExperimentConfiguration
{
    static readonly PlaneOrientation[] planeOrientations = { PlaneOrientation.PlaneYZ };
    static readonly IndexOfDifficultyConfiguration[] configurations = {
        new IndexOfDifficultyConfiguration(0.04f, 0.2f),
        new IndexOfDifficultyConfiguration(0.04f, 0.3f),
        new IndexOfDifficultyConfiguration(0.04f, 0.4f),
        new IndexOfDifficultyConfiguration(0.015f, 0.2f),
        new IndexOfDifficultyConfiguration(0.015f, 0.3f),
        new IndexOfDifficultyConfiguration(0.015f, 0.4f),
        new IndexOfDifficultyConfiguration(0.005f, 0.2f),
        new IndexOfDifficultyConfiguration(0.005f, 0.3f),
        new IndexOfDifficultyConfiguration(0.005f, 0.4f)
    };

    public override int GetNumBlocksPerTest()
    {
        return 3;
    }

    public override int GetNumTargetsPerTest()
    {
        return 13;
    }

    public override PlaneOrientation[] GetPlaneOrientationsToTest()
    {
        return planeOrientations;
    }

    public override IndexOfDifficultyConfiguration[] GetTargetConfigurationsToTest()
    {
        return configurations;
    }
}