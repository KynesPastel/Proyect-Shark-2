using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player Data", menuName = "Create Shark Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] public int lifePlayer = 100;
    [SerializeField] public string namePlayer = "Sharko";
    [SerializeField] public float speedPlayer = 50.0f;
    //[SerializeField] public Vector3 directionPlayer = new Vector3 (0,0,1) ;

     

}
    
