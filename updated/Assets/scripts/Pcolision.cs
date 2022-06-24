
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pcolision : MonoBehaviour
{
    public PlayerMovement Move;
    public PlayerMovement rb;
  
    void OnTriggerEnter(Collider colisionInfo)
    {
        
         if (colisionInfo.GetComponent<Collider>().tag == "unhealthy"){
            
         
         Move.forwardforce -=20f  ;
         }
          if (colisionInfo.GetComponent<Collider>().tag == "healthy"){
           
           Move.forwardforce +=20f  ;
          }
        if (colisionInfo.GetComponent<Collider>().tag == "Finish")
        {
         restart();
        }

}
        void restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

}