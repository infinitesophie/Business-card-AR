using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickForGirl : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Transform select = GameObject.FindWithTag("select").transform;
            if (Physics.Raycast(Vector2(ray), hit, 100))
            {
                select.tag = "none";
                hit.collider.transform.tag = "select";
            }
        }
    }
}

