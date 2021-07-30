using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class itemcollector : MonoBehaviour
  {

    private int cherries = 0;
    public Text cherriesText;
    private void OnTriggerEnter2D(Collider2D collision)
 
    {

        if (collision.gameObject.CompareTag("cherry"))
        {

            Destroy(collision.gameObject);
             cherries=cherries+1;
        cherriesText.text="cherries : "+ cherries;
    // Debug.Log("cherry"+ cherries);
}





    }

}
