using System.Collections.Generic;

public class Character
{
    #region Character attributes

    /// <summary>
    /// The motivations driving this character
    /// </summary>
    protected List<Motivation> motivations = new List<Motivation>();
    /// <summary>
    /// The actions that this character can perform depending on motivations.
    /// </summary>
    protected List<ActionOutcome> possibleActions = new List<ActionOutcome>();
    /// <summary>
    /// How much damage can the character withstand.
    /// </summary>
    protected float health;
    /// <summary>
    /// If health goes below this value, charachter becomes unconcious.
    /// </summary>
    protected float unconciusThreshold;
    #endregion
    
    #region Actions
    public ActionOutcome StealFrom(Character character)
    {
        return null;
    }

    public ActionOutcome Attack(Character character)
    {
        return null;
    }
    #endregion
}
