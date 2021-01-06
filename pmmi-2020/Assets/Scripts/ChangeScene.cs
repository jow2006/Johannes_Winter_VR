using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Scene scene;
    public int counter = 0;
    public float angle = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.GetComponent(RightDoor).isGrabbed;
        //Debug.Log(this.transform.rotation.x);
        angle = (this.transform.eulerAngles.y); //* (180 / Mathf.PI));
        Debug.Log(angle);
       // Debug.Log(this.transform.rotation.z);
       if(this.transform.eulerAngles.y > 15)
        {
            SceneManager.LoadScene(1);
        }
    }
}
