using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScript : MonoBehaviour
{
    //Declaração do array
    int vida1;
    int vida2;
    int vida3;
    [SerializeField] private int[] pipesHigh;
    private int number;

    // Start is called before the first frame update
    void Start()
    {
        //vida1 = 10;
        //vida2 = 5;
        //vida3 = 7;
        /*if (vida1 > vida2 && vida1 > vida3)
        {
            print("A vida do personagem 1 é a maior, sendo igual a: " + vida1);
        } 
        else if(vida2 > vida1 && vida2 > vida3)
        {
            print("A vida do personagem 2 é a maior, sendo igual a: " + vida2);
        }
        else
        {
            print("A vida do personagem 3 é a maior, sendo igual a: " + vida3);
        }*/
        //
        //print("The highest pipe is " + pipesHigh[3]);
        //print("The length of the pipe array is " + pipesHigh.Length);
        //
        //number = 4;
        //print(number);
        //number++; //É o mesmo que number = number + 1
        //print("I added 1 to the variable number and the result is: " + number);
        //
        //Estrutura do for -> declaração; condição; ação final
        for(int i = 0; i < pipesHigh.Length; i++)
        {
            print(pipesHigh[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
