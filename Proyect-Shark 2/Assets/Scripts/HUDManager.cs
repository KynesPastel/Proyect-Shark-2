using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDManager : MonoBehaviour
{[SerializeField] private TextMeshProUGUI textGameOver;
[SerializeField] private Image imageDamage;
[SerializeField] private Text textComplete;



    // Start is called before the first frame update
    private void Awake() {
       PlayerEvent.onDeath += EnableGameOverUI;
       PlayerEvent.onDamage += EnableDamageUI;
        PlayerEvent.onComplete += EnableCompleteUI;
       
       //PlayerEvent.onDamage += EnableDamageUI;
    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnableGameOverUI()
    {
        textGameOver.gameObject.SetActive(true);
    } 
    public void EnableDamageUI(){
        
     imageDamage.gameObject.SetActive(true);
    }
    public void EnableCompleteUI(){
        
     imageDamage.gameObject.SetActive(true);
    }
  

   
}
