using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };
    public List<int> jedynki = new List<int>();
    public List<int> dwojki = new List<int>();
    public List<int> trojki = new List<int>();
    void Start()
    {
        List<int> dane_copy = dane;
        int length = dane.Count;
        for (int i = 0; i < length; i++)
        {
            if (dane_copy[i] == 1)
            {
                jedynki.Add(dane[i]);
                
            }
            else if (dane[i] == 2)
            {
                dwojki.Add(dane[i]);
                
            }
            else if (dane[i] == 3)
            {
                trojki.Add(dane[i]);
                
                
            }
            Debug.Log(dane[0]);
        }
        dane.Clear();
        //jedynki.Add(int);
        //jedynki.Remove(int);
        //Debug.Log(dane.Count);
        //Debug.Log(jedynki.Count);
        
    }

    void Update()
    {

    }
}
