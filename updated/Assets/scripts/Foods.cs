using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Foods : MonoBehaviour
{
    public Text HealthyF;
    public Text UnhealthyF;
    public int Takenh = 0;
    public int Takenunh = 0;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "healthy")
        { 
            Destroy(other.gameObject);
            Takenh ++;
            HealthyF.text =Takenh.ToString("0");
        }
        if (other.gameObject.tag == "unhealthy")
        {
            Destroy(other.gameObject);
            Takenunh ++;
            UnhealthyF.text =Takenunh.ToString("0");
        }
}

}
