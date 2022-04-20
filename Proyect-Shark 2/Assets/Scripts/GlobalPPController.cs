using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GlobalPPController : MonoBehaviour
{
 private PostProcessVolume globalVolume;
 private Vignette colorEffect;

 private void Awake() {
     globalVolume = GetComponent<PostProcessVolume>();
     globalVolume.profile.TryGetSettings(out colorEffect);
 }
     IEnumerator Decresing(){
     colorEffect.active = true;
     colorEffect.color.value = Color.red;
     yield return new WaitForSeconds(2f);
     colorEffect.color. value = Color.white;
     colorEffect.active = false; }
     public void OnDecresing(){
         StartCoroutine(Decresing());
     }
}
