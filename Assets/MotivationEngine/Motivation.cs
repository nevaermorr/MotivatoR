using UnityEngine;
using System.Collections;

public class Motivation
{
    /// <summary>
    /// What value is related to this motivation.
    /// </summary>
    protected Value value;
    /// <summary>
    /// How strong is the motivation 
    /// (negative value means repulsion towards value).
    /// </summary>
    protected float intensity = 0f;

    #region Accessors
    public Value Value
    {
        get
        {
            return value;
        }
    }
    public float Intensity
    {
        get
        {
            return intensity;
        }
    }
    #endregion
}
