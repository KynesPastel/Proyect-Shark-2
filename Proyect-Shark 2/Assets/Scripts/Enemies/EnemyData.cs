using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Enemy Data", menuName = "Create Fishes Data" )]
public class EnemyData : ScriptableObject
{
    // DESING DATA
    
    [SerializeField][Range(0.1f, 20f)] public float speed = 2f;
    [SerializeField] public int HP = 1;

    [SerializeField] public float rangeAttack = 10f;
   
}
