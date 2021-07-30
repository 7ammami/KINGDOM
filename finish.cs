using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    private AudioSource finishsound;

    // Start is called before the first frame update
    void Start()
    {
      
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
      //  finishsound = GetComponent<AudioSource>();
        if (collision.gameObject.name == "player")
        {
          //  finishsound.Play();
            CompleteLevel();
        }
    
    }

    private void CompleteLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
