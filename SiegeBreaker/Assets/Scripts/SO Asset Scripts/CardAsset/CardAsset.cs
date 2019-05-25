using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TargetingOptions
{
    NoTarget,
    AllUnits, // Changed from AllCreatures
    EnemyUnits, // Changed from EnemyCreatures
    YourUnits, // Changed from  YourCreatures
    AllCharacters, 
    EnemyCharacters,
    YourCharacters
}

public class CardAsset : ScriptableObject 
{
    // this object will hold the info about the most general card
    [Header("General Info")]
    public CharacterAsset characterAsset;  // if this is null, it`s a neutral card
    [TextArea(2,3)]
    public string Description;  // Description for spell or character
	public Sprite CardImage;
    public int BuilderManaCost;
    public int RecruiterManaCost;

    [Header("Unit Info")]
    public int MaxHealth;
    public int Attack;
    public int AttacksForOneTurn = 1;
    public bool Defend; // Changed from Taunt
    public bool Mounted; // Changed from Charge
    public string UnitScriptName; // Changed from CreatureScriptName
    public int specialUnitAmount; // Changed from specialCreatureAmount

    [Header("Tactic Info")]
    public string TacticScriptName; // Changed from SpellScriptName
    public int SpecialTacticAmount; // Changed from specialSpellAmount
    public TargetingOptions Targets;

}
