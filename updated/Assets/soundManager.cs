using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundManager : MonoBehaviour
{
    [SerializeField] Image soundOnIcone;
    [SerializeField] Image SoundOffIcone;
    private bool muted= false;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted")){
            PlayerPrefs.SetInt("muted" , 0);
            load();
        }
        else {
            load();
        }
        UpdateBottonIcone();
        AudioListener.pause=muted;
    }
    public void OnBottonPress(){

        if (muted== false){
            muted= true;
            AudioListener.pause=true;
        }
        else {

            muted=false;
            AudioListener.pause=false;
        }
        save();
        UpdateBottonIcone();
    }
    private void UpdateBottonIcone(){
        if(muted==false){
            soundOnIcone.enabled=true;
            SoundOffIcone.enabled=false;
        }
        else{
            soundOnIcone.enabled=false;
            SoundOffIcone.enabled=true;
        }

    }
   private void load(){
       muted=PlayerPrefs.GetInt("muted")==1 ;
    }
    private void save(){

      PlayerPrefs.SetInt("muted", muted ? 1 : 0);

    }
}
