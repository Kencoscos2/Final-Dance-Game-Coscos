using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Animation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator CharacterAnimator;
    public GameObject Char;
    int isPress = 0;
    int gameStarted = 0;
    bool startcombo;

    void Start()
    {
         CharacterAnimator = Char.GetComponent<Animator>();
    }

    void Update()
    {
        if (gameStarted == 0){
            StartCoroutine(Timer());
            if(startcombo == true){
                FirstPattern();
            }
        
        }
        else if (gameStarted == 1){
            StartCoroutine(Timer());
            if(startcombo == true){
                SecondPattern();
            }
        }
        else if (gameStarted == 2){
            StartCoroutine(Timer());
            if(startcombo == true){
                ThirdPattern();
            }
        }
        else if (gameStarted == 3){
            StartCoroutine(Timer());
            if(startcombo == true){
                FourthPattern();
            }
        }


    }

    void FirstPattern(){
        int CurrentisPress = isPress;
        // LETTER W ----------------------------------------------------------------------------------------------------

        if (Input.GetKeyDown(KeyCode.W)){
            if (isPress == 0){
                isPress += 1;
                CharacterAnimator.SetBool("hipdance",true);
                CharacterAnimator.SetBool("house",false);
                CharacterAnimator.SetBool("snake",false);
                CharacterAnimator.SetBool("idle",false);
                CharacterAnimator.SetBool("wave",false);
                Debug.Log("Press 1 first time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.W) && isPress == 1 || isPress == 2 || isPress == 3 || isPress == 5 || isPress == 6 || isPress == 7 || isPress == 9 || isPress == 10 || isPress == 11 || isPress == 13 || isPress == 14 || isPress == 15 ){
                isPress -= CurrentisPress;
                Debug.Log("Press W in wrong combination: " + isPress);
            }
        }

        // LETTER A ----------------------------------------------------------------------------------------------------

        else if (Input.GetKeyDown(KeyCode.A)){
            if (isPress == 1){
                isPress += 1;
                Debug.Log("Press A first time:" + isPress);
            } 
            else if (Input.GetKeyDown(KeyCode.A) && isPress == 2 || isPress == 0 || isPress == 3 || isPress == 5 || isPress == 6 || isPress == 7 || isPress == 9 || isPress == 10 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15 ){
                isPress -= CurrentisPress;
                Debug.Log("Press A in a wrong combination: " + isPress );
        }
        }
        else if (Input.GetKeyDown(KeyCode.S)){
            if (isPress == 2){
                isPress += 1;
                Debug.Log("Press S first time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.S) && isPress == 3 || isPress == 0 || isPress == 1 || isPress == 2 || isPress == 5 || isPress == 6 || isPress == 7 || isPress == 9 || isPress == 10 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15 ){
                isPress -= CurrentisPress;
                Debug.Log("Press S in a wrong combo: " + isPress);
            }
        }

        // LETTER D ----------------------------------------------------------------------------------------------------

        else if (Input.GetKeyDown(KeyCode.D)){
            if (isPress == 3){
                isPress += 1;
                //New Combo
                // IEnumerator + StartCoroutine
                // StartCoroutiine(Timer(3f));
                Debug.Log("New Combo");
                Debug.Log("Press D first time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.D) && isPress == 5 || isPress == 0 || isPress == 1 || isPress == 2 || isPress == 4 || isPress == 6 || isPress == 7 || isPress == 8 || isPress == 9 || isPress == 10 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15 ){
                isPress -= CurrentisPress;
                Debug.Log("Press D in a wrong combination: " + isPress);
            }
            startcombo = false;
            gameStarted += 1;
        }
        else if (Input.anyKeyDown) {
            isPress = 0;
        }
        else if (isPress == 0){
            CharacterAnimator.SetBool("idle",true);
            CharacterAnimator.SetBool("hipdance",false);
            CharacterAnimator.SetBool("house",false);
            CharacterAnimator.SetBool("snake",false);
            CharacterAnimator.SetBool("wave",false);
        }
    }
    void SecondPattern(){
        int CurrentisPress = isPress;
        // LETTER Y ----------------------------------------------------------------------------------------------------
        if (Input.GetKeyDown(KeyCode.Y)){
            if (isPress == 4){
                isPress += 1;
                CharacterAnimator.SetBool("house",true);
                CharacterAnimator.SetBool("hipdance",false);
                CharacterAnimator.SetBool("idle",false);
                CharacterAnimator.SetBool("wave",false);
                CharacterAnimator.SetBool("snake",false);
                Debug.Log("Press Y first time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.Y) && isPress == 5 || isPress == 0 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 6 || isPress == 7 || isPress == 9 || isPress == 10 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15 ){
                isPress -= CurrentisPress;
                Debug.Log("Press in a wrong combination: " + isPress);
            }
        }

        // LETTER U ----------------------------------------------------------------------------------------------------

        else if (Input.GetKeyDown(KeyCode.U)){
            if (isPress == 5){
                isPress += 1;
                Debug.Log("Press U first time:" + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.U) && isPress == 6 || isPress == 0 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 4 || isPress == 5 || isPress == 7 || isPress == 9 || isPress == 10 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15){
                isPress -= CurrentisPress;
                Debug.Log("Press in a wrong combination: " + isPress);
            }
        }

        // LETTER I ----------------------------------------------------------------------------------------------------

        else if (Input.GetKeyDown(KeyCode.I)){
            if (isPress == 6){
                isPress += 1;
                Debug.Log("Press I first time:" + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.I) && isPress == 7 || isPress == 0 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 4 || isPress == 6 || isPress == 9 || isPress == 10 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15){
                isPress -= CurrentisPress;
                Debug.Log("Press I in a wrong combination: " + isPress);
            }
        }

        // LETTER O ----------------------------------------------------------------------------------------------------

        else if (Input.GetKeyDown(KeyCode.O)){
            if (isPress == 7){
                isPress += 1;
                 //New Combo
                // IEnumerator + StartCoroutine
                // StartCoroutiine(Timer(3f));
                Debug.Log("Press O first time: " + isPress);
                }
            else if (Input.GetKeyDown(KeyCode.O) && isPress == 4 || isPress == 0 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 5 || isPress == 6 || isPress == 8 || isPress == 9 || isPress == 10 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15){
                isPress -= CurrentisPress;
                Debug.Log("Press O in a wrong combination: " + isPress);
            }
            startcombo = false;
            gameStarted += 1;
        }
        else if (Input.anyKeyDown) {
            isPress = 0;
        }
        else if (isPress == 0){
            CharacterAnimator.SetBool("idle",true);
            CharacterAnimator.SetBool("hipdance",false);
            CharacterAnimator.SetBool("house",false);
            CharacterAnimator.SetBool("snake",false);
            CharacterAnimator.SetBool("wave",false);
        }
    }
    void ThirdPattern(){
        int CurrentisPress = isPress;
        // LETTER V ----------------------------------------------------------------------------------------------------
        if (Input.GetKeyDown(KeyCode.V)){
            if (isPress == 8){
                isPress += 1;
                CharacterAnimator.SetBool("snake",true);
                CharacterAnimator.SetBool("idle",false);
                CharacterAnimator.SetBool("hipdance",false);
                CharacterAnimator.SetBool("house",false);
                CharacterAnimator.SetBool("wave",false);
                Debug.Log("Press V first time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.V) && isPress == 9 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 4 || isPress == 5 || isPress == 6 || isPress == 7 || isPress == 8 || isPress == 10 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15){
                isPress -= CurrentisPress;
                Debug.Log("Press V in a wrong combination: " + isPress);
            }
        }

        // LETTER B ----------------------------------------------------------------------------------------------------
        
        else if (Input.GetKeyDown(KeyCode.B)){
            if(isPress == 9){
                isPress += 1;
                Debug.Log("Press B first time: " + isPress);
            }   
            else if(Input.GetKeyDown(KeyCode.B) && isPress == 10 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 4 || isPress == 5 || isPress == 6 || isPress == 7 || isPress == 8 || isPress == 9 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15){
                isPress -= CurrentisPress;
                Debug.Log("Press B second time: " + isPress);
            }
        }

        // LETTER N ----------------------------------------------------------------------------------------------------
        
        else if (Input.GetKeyDown(KeyCode.N)){
            if(isPress == 10){
                isPress += 1;
                Debug.Log("Press N first time: " + isPress);
            }   
            else if(Input.GetKeyDown(KeyCode.N) && isPress == 11 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 4 || isPress == 5 || isPress == 6 || isPress == 7 || isPress == 8 || isPress == 9 || isPress == 10 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15){
                isPress -= 11;
                Debug.Log("Press N in a wrong combination: " + isPress);

            }
        }

        // LETTER M ----------------------------------------------------------------------------------------------------

        else if (Input.GetKeyDown(KeyCode.M)){
            if (isPress == 11){
                isPress += 1;
                 //New Combo
                // IEnumerator + StartCoroutine
                // StartCoroutiine(Timer(3f));
                Debug.Log("Press M first time: " + isPress);
                }
            else if(Input.GetKeyDown(KeyCode.M) && isPress == 12 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 4 || isPress == 5 || isPress == 6 || isPress == 7 || isPress == 8 || isPress == 9 || isPress == 10 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15){
                isPress -= CurrentisPress;
                Debug.Log("Press M in a wrong combination: " + isPress);

            }
            startcombo = false;
            gameStarted += 1;
        }
        else if (Input.anyKeyDown) {
            isPress = 0;
        }
        else if (isPress == 0){
            CharacterAnimator.SetBool("idle",true);
            CharacterAnimator.SetBool("hipdance",false);
            CharacterAnimator.SetBool("house",false);
            CharacterAnimator.SetBool("snake",false);
            CharacterAnimator.SetBool("wave",false);
        }
    }
    void FourthPattern(){
        int CurrentisPress = isPress;
        // LETTER G ----------------------------------------------------------------------------------------------------

        if (Input.GetKeyDown(KeyCode.G)){
            if (isPress == 12){
                isPress += 1;
                CharacterAnimator.SetBool("wave",true);
                CharacterAnimator.SetBool("idle",false);
                CharacterAnimator.SetBool("hipdance",false);
                CharacterAnimator.SetBool("house",false);
                CharacterAnimator.SetBool("snake",false);
                Debug.Log("Press G first time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.G) && isPress == 13 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 4 || isPress == 5 || isPress == 6 || isPress == 7 || isPress == 8 || isPress == 10 || isPress == 11 || isPress == 14 || isPress == 15){
                isPress -= CurrentisPress;
                Debug.Log("Press G in a wrong combination: " + isPress);
            }
        }

        // LETTER H ----------------------------------------------------------------------------------------------------

        else if (Input.GetKeyDown(KeyCode.H)){
            if(isPress == 13){
                isPress += 1;
                Debug.Log("Press H first time: " + isPress);
            }  
            else if (Input.GetKeyDown(KeyCode.H) && isPress == 14 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 4 || isPress == 5 || isPress == 6 || isPress == 7 || isPress == 8 || isPress == 10 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 14 || isPress == 15 ){
                isPress -= CurrentisPress;
                Debug.Log("Press H in a wrong combination: " + isPress);
            }
        }

        // LETTER J ----------------------------------------------------------------------------------------------------

        else if (Input.GetKeyDown(KeyCode.J)){
            if(isPress == 14){
                isPress += 1;
                Debug.Log("Press J first time: " + isPress);
            }  
            else if (Input.GetKeyDown(KeyCode.J) && isPress == 15 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 4 || isPress == 5 || isPress == 6 || isPress == 7 || isPress == 8 || isPress == 10 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 14 ){
                isPress -= CurrentisPress;
                Debug.Log("Press J in a wrong combination: " + isPress);
            }
        }

        // LETTER K ----------------------------------------------------------------------------------------------------

        else if (Input.GetKeyDown(KeyCode.K)){
            if (isPress == 15){
                isPress += 1;
                 //New Combo
                // IEnumerator + StartCoroutine
                // StartCoroutiine(Timer(3f));
                Debug.Log("Press K first time: " + isPress);
                }
            else if (Input.GetKeyDown(KeyCode.K) && isPress == 16 || isPress == 1 || isPress == 2 || isPress == 3 || isPress == 4 || isPress == 5 || isPress == 6 || isPress == 7 || isPress == 8 || isPress == 10 || isPress == 11 || isPress == 12 || isPress == 13 || isPress == 15 ){
                isPress -= CurrentisPress;
                Debug.Log("Press K in a wrong combination: " + isPress);
            }
            startcombo = false;
            gameStarted += 1;
        }
        else if (Input.anyKeyDown) {
            isPress = 0;
        }
        else if (isPress == 0){
            CharacterAnimator.SetBool("idle",true);
            CharacterAnimator.SetBool("hipdance",false);
            CharacterAnimator.SetBool("house",false);
            CharacterAnimator.SetBool("snake",false);
            CharacterAnimator.SetBool("wave",false);
        }
    }
    IEnumerator Timer(){
        yield return new WaitForSeconds(3f);
        startcombo = true;
    }
}

 