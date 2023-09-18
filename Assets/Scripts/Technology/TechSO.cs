using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTechnology", menuName = "Technology")]
public class TechSO : ScriptableObject //it's like a abstract script.
{
    public int id;
    public string techName;
    public Sprite icon;
    public int[] requiredTechID;
    public TechCost cost;
    public int daysRequired;
    public string description;
}