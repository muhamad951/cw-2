using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    string heroName = "muhamad man";
    float heroHeight = 1.85f;
    int heroAge = 17;
    string heroSuperPower = "powered gun";

    string villianName = "asmaa";
    float villianHeight = 1.89f;
    int villianAge = 31;
    string villianSuperPower = "superhuman strength";

    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = villianAge - heroAge;

        print(" the hero's name is " + heroName + " his age is " + heroAge);
        print(" his height is " + heroHeight + "and his superpower is " + heroSuperPower);

        print(" the villians name is" + villianName + " his age is " + villianAge);
        print("his height is " + villianHeight + " and his superPower is " + villianSuperPower);

        print("and the age difference between the hero and villian is " + ageDifference);

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
