using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Additon : MonoBehaviour {

    public int NumberA;
    public int NumberB;
    public int Answer;

    public Text questionText;
    public Text feedbackText;
    public InputField input;
    public GameObject DontDestroyOnLoad;

    public bool Ongoing = false;
    public bool hasCompleted = false;

    public int NumberHolder;

	// Use this for initialization
	void Start () {

        DontDestroyOnLoad = GameObject.FindGameObjectWithTag("DontDestroy");
        //NumberHolder = DontDestroyOnLoad.GetComponent<DontDestroy>().Number;
	}
	
	// Update is called once per frame
	void Update () {
        if (Ongoing == false)
        {
            /*
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
             */
        }

    }


    void NumberGenerator()
    {
       
            NumberA = Random.Range(1, 20);

            NumberB = Random.Range(1, 20);
        
       
    }
    public void Additonn()
    {
        feedbackText.text = "";
        NumberGenerator();
        Answer = NumberA + NumberB;
        questionText.text = "Vad är " + NumberA + " + " + NumberB + "?";
        Debug.Log(Answer);
    }
    public void Subtraktion()
    {
        feedbackText.text = "";
        NumberGenerator();
        while (!hasCompleted)
        {
            NumberGenerator();

            if (NumberA - NumberB >= 0)
            {
                Answer = NumberA - NumberB;
                questionText.text = "Vad är " + NumberA + " - " + NumberB + "?";
                Debug.Log(Answer);
                hasCompleted = true;
            }
        }
       
    }
    public void Multiplikation()
    {
        feedbackText.text = "";
        NumberGenerator();
        while (!hasCompleted)
        {
            NumberGenerator();

            if (NumberA % NumberB != 0)
            {
                Answer = NumberA * NumberB;
                questionText.text = "Vad är " + NumberA + " * " + NumberB + "?";
                Debug.Log(Answer);
                hasCompleted = true;
            }
        }
        
    }
    public void Division()
    {
        feedbackText.text = "";
        NumberGenerator();
        while (!hasCompleted)
        {
            NumberGenerator();

            if (NumberA % NumberB == 0 )
            {
                Answer = NumberA / NumberB;
                questionText.text = "Vad är " + NumberA + " / " + NumberB + "?";
                Debug.Log(Answer);
                hasCompleted = true;
            }
        }
        
    }

    public void CheackAnswer()
    {
        if (input.text == Answer.ToString())
        {
            feedbackText.text = "Rätt svar! Grattis!";
            input.text = "";
            hasCompleted = false;

            //Generera ny fråga, som är av samma typ som spelaren previs hade rätt på.
        }
        else if (input.text != Answer.ToString())
        {
            feedbackText.text = "Tyvärr. Försök igen!";
            input.text = "";
            hasCompleted = false;
        }

    }
}
