using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabScript : MonoBehaviour
{
    public bool grabbed;
    public static int watersize;
    RaycastHit2D hit;
    float grabdistance = 1f;
    public LayerMask grabableobjects;
    public LayerMask notgrabbed;
    public Transform holdpoint;
    public float throwforce = 4f;
    public static bool buttonclicked;
    public GameObject obstakel;


    // Start is called before the first frame update
    void Start()
    {
        watersize = 0;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        watersize = Spreadwater.watersize;
        if (watersize == 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        if (watersize > 0)
        {

            if (watersize == 1)
            {
                gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);

            }
            else if (watersize == 2)
                gameObject.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);
            obstakel.SetActive(true);
        }
        else
        {
            obstakel.SetActive(false);
        }
        
        
       
        
        
                if (Input.GetMouseButtonDown(1))
        {
            if (!grabbed)
            {
                hit = Physics2D.CircleCast(gameObject.transform.position, grabdistance, Vector2.up, 0f,grabableobjects);
               // hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, grabdistance, grabableobjects);

                if (hit.collider!= null)
                {
                    grabbed = true;
                }
             
            }
            else if(Physics2D.OverlapPoint(holdpoint.position,grabableobjects))
            {
                grabbed = false;
               
            }
        }
        if (grabbed)
        {
            hit.collider.gameObject.transform.position = holdpoint.position;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawSphere(transform.position, grabdistance);
    }
}
