using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Additon : MonoBehaviour {

    public float NumberA;

    public float NumberB;

    public float Answer;

    public GameObject DontDestroyOnLoad;

    public bool Ongoing = false;

    public int NumberHolder;

	// Use this for initialization
	void Start () {

        DontDestroyOnLoad = GameObject.FindGameObjectWithTag("DontDestroy");
        NumberHolder = DontDestroyOnLoad.GetComponent<DontDestroy>().Number;
	}
	
	// Update is called once per frame
	void Update () {
        if (Ongoing == false)
        {
            switch (NumberHolder)
            {

                case 1:
                    NumberGenerator();
                    Additonn();
                    Ongoing = true;
                    break;

                case 2:
                    NumberGenerator();
                    Subration();
                    Ongoing = true;
                    break;

                case 3:
                    NumberGenerator();
                    Multiation();
                    Ongoing = true;
                    break;

                case 4:
                    NumberGenerator();
                    Dividtion();
                    Ongoing = true;
                    break;

                default:
                    break;
            }
        }

    }


    void NumberGenerator()
    {
        NumberA = Random.Range(0f, 10f);

        NumberB = Random.Range(0f, 10f);

    }
    void Additonn()
    {
        Answer = NumberA + NumberB;
        Debug.Log(Answer);
    }
    void Subration()
    {
        Answer = NumberA - NumberB;
        Debug.Log(Answer);
    }
    void Multiation()
    {
        Answer = NumberA * NumberB;
        Debug.Log(Answer);
    }
    void Dividtion()
    {
        Answer = NumberA / NumberB;
        Debug.Log(Answer);
    }
}
