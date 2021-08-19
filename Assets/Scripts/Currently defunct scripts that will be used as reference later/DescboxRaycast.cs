using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescboxRaycast : MonoBehaviour
{


   /// <summary>
   /// This was originally going to be the method for opening the description boxes but for some reason,
   /// every time I had more than one object it would just manage to detect as hitting them all at once.
   /// Therefore, I had to scrap it.
   /// Based on this code: https://kylewbanks.com/blog/unity-2d-detecting-gameobject-clicks-using-raycasts
   /// </summary>
    
    
    public GameObject RaycastedDescBox;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(RaycastedDescBox.activeSelf.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider.CompareTag("TextShower"))
            {
                Debug.Log("FUCK!!!!!!!!!!");
                RaycastedDescBox.SetActive(true);
                
            }
        }
    
      

       
    }
}
