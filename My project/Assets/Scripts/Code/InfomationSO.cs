using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewInfomationSO", menuName = "Custom/Create InfomationSO")]
public class InfomationSO : ScriptableObject
{
    [SerializeField] float force = 10f;
    [SerializeField] float weight = 5f;
    [SerializeField] float speed = 5f;
    [SerializeField] float dame = 10f;
    [SerializeField] PhysicsMaterial2D material2D;
    public float Force
    {
        get { return force; }
    }
    public float Weight
    {
        get { return weight; }
    }
    public float Speed
    {
        get { return speed; }
    }
    public float Dame
    {
        get { return dame; }
    }
    public PhysicsMaterial2D PhysicsMaterial2D { 
        get { return material2D; } 
    }
}
