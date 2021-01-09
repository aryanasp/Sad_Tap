using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGenerator : MonoBehaviour
{
    //config
    [SerializeField]
    Slot slot;
    [SerializeField]
    int count;
    int maxCount = 36;
    List<Vector2> positionLists;
    // Start is called before the first frame update
    void Start()
    {
        positionLists = new List<Vector2>();
        InitializePositionList();
        Initialize();
        
    }

    private void InitializePositionList()
    {
        float theta = Mathf.PI;
        float scalerX = slot.transform.localScale.x;
        float scalerY = slot.transform.localScale.y;
        float dx = scalerX;
        float dy = scalerY;
        int loop = 1;
        float maxX = transform.position.x + scalerX/2;
        float maxY = transform.position.y + scalerY/2;
        float minX = transform.position.x - scalerX/2;
        float minY = transform.position.y - scalerY/2;
        float x = maxX;
        float y = maxY;
        
        for (int i = 0; i < maxCount;)
        {
            while ((x <= maxX && y <= maxY) && (x >= minX && y >= minY))
            {   
                if(positionLists.Contains(new Vector2(x, y)))
                {
                   //Do Nothing
                }
                else
                {
                    positionLists.Add(new Vector2(x, y));
                    
                    i++;
                }
                if(i >= 36)
                {
                    break;
                }
                int calculator = (int) (Mathf.Sqrt(i) / 2);
                if (calculator >= loop)
                {
                    theta = 0;
                    loop++;
                    maxX += scalerX;
                    maxY += scalerY;
                    minX -= scalerX;
                    minY -= scalerY;
                    
                }
                dx = scalerX * ((int)Mathf.Cos(theta));
                dy = scalerY * ((int)Mathf.Sin(theta));
                float oldX = x;
                float oldY = y;
                x += dx;
                y += dy;
                if((x > maxX || y > maxY) || (x < minX || y < minY))
                {
                    
                    theta += Mathf.PI / 2;
                    x = oldX;
                    y = oldY;
                }
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Initialize()
    {
        for(int i = 0; i < positionLists.Count; i++)
        {
            Slot tmp = Instantiate(slot) as Slot;
            tmp.transform.position = new Vector2(positionLists[i].x, positionLists[i].y);
        }
    }
}
