using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RIverCrossingManager : MonoBehaviour
{
    [Tooltip("The contents of the boat")]
    public string[] boat;
    [Tooltip("The contents of the left side")]
    public string[] side1;
    [Tooltip("The contents of the right Side")]
    public string[] side2;
    [Tooltip("Which side boat is on (left or right)")]
    public int boatSide;

    // Start is called before the first frame update
    void Start()
    {
        //when we start we 
        boat[0] = null;
        boat[1] = null;
        side2[0] = null;
        side2[1] = null;
        side2[2] = null;
        side2[3] = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /**
     * This function along with function MoveSide2 will check to see if parameter "thing" is within the Array for it's side
     * If it's found and the boat has an empty slot then it'll move that "thing" into it and empty the side.
     * <param name="thing">The thing you want to move</param>
     */
    public void MoveSide1(string thing)
    {
        for(int i=0;i<side1.Length;i++)
        {
            if(side1[i]==thing)
            {
                if(boat[0]==null)
                {
                    boat[0] = side1[i];
                    side1[i] = null;
                }
                else if(boat[1]==null)
                {
                    boat[1] = side1[i];
                    side1[i] = null;
                }
                else
                {
                    Debug.Log("boat full");
                }
            }
        }
    }

    /**
     * This function along with function MoveSide1 will check to see if parameter "thing" is within the Array for it's side
     * If it's found and the boat has an empty slot then it'll move that "thing" into it and empty the side.
     * <param name="thing">The thing you want to move</param>
     */

    public void MoveSide2(string thing)
    {
        for (int i = 0; i < side1.Length; i++)
        {
            if (side2[i] == thing)
            {
                if (boat[0] == null)
                {
                    boat[0] = side2[i];
                    side2[i] = null;
                }
                else if (boat[1] == null)
                {
                    boat[1] = side2[i];
                    side2[i] = null;
                }
                else
                {
                    Debug.Log("boat full");
                }
            }
        }
    }

    /**
     * This function isn't used in this implementation
     */

    public void MoveBoat(string thing)
    {
        if (boatSide == 1)
        {

            if (boat[0] == thing)
            {
                for (int i = 0; i < side1.Length; i++)
                {
                    if (side1[i] == null)
                    {
                        side1[i] = boat[0];
                        return;
                    }
                }
            }
            else if (boat[1] == null)
            {
                for (int i = 0; i < side1.Length; i++)
                {
                    if (side1[i] == null)
                    {
                        side1[i] = boat[1];
                        return;
                    }
                }
            }
            else
            {
                Debug.Log("boat empty");
            }
                
            
        }
        else 
        {
            if (boat[0] == thing)
            {
                for (int i = 0; i < side2.Length; i++)
                {
                    if (side2[i] == null)
                    {
                        side2[i] = boat[0];
                        return;
                    }
                }
            }
            else if (boat[1] == thing)
            {
                for (int i = 0; i < side2.Length; i++)
                {
                    if (side2[i] == null)
                    {
                        side2[i] = boat[1];
                        return;
                    }
                }
            }
            else
            {
                Debug.Log("boat empty");
            }


        }
    }


    /**
     * This function  will, on each call, empty one "thing" from the boat
     */
    public void MoveBoat()
    {
        if (boatSide == 1)
        {

            if (boat[0] != null)
            {
                for (int i = 0; i < side1.Length; i++)
                {
                    if (side1[i] == null)
                    {
                        side1[i] = boat[0];
                        boat[0] = null;
                        return;
                    }
                }
            }
            else if (boat[1] != null)
            {
                for (int i = 0; i < side1.Length; i++)
                {
                    if (side1[i] == null)
                    {
                        side1[i] = boat[1];
                        boat[1] = null;
                        return;
                    }
                }
            }
        }
        else
        {
            Debug.Log("Side 2");
            if (boat[0] != null)
            {
                Debug.Log("Unload Side 2");
                for (int i = 0; i < side2.Length; i++)
                {
                    Debug.Log(side2[i]);
                    if (side2[i] == null)
                    {
                        side2[i] = boat[0];
                        boat[0] = null;
                        return;
                    }
                }
            }
            else if (boat[1] != null)
            {
                for (int i = 0; i < side2.Length; i++)
                {
                    Debug.Log(side2[i]);
                    if (side2[i] == null)
                    {
                        Debug.Log(side2[i]);

                        side2[i] = boat[1];
                        boat[1] = null;
                        return;
                    }
                }
            }


        }
    }

    /**
     * This function simply moves the boat from one side to the other
     */ 
    public void switchBoatSide()
    {
        if (boat[1] == "Person" || boat[0] == "Person")
        {
            if (boatSide == 1)
            {
                boatSide = 2;
            }
            else
            {
                boatSide = 1;
            }
        }
    }


}
