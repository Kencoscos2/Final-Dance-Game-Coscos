using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class hipdance : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator CharacterAnimator;
    public GameObject Char;
    int isPress = 0;
    void Start()
    {
         CharacterAnimator = Char.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            if (isPress == 0){
                isPress += 1;
                CharacterAnimator.SetBool("hipdance",true);
                CharacterAnimator.SetBool("house",false);
                CharacterAnimator.SetBool("idle",false);
                Debug.Log("Press 1 first time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.W) && isPress == 1){
                isPress -= 1;
                Debug.Log("Press W second time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.W) && isPress == 2){
                isPress -= 2;
                Debug.Log("Press W third time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.W) && isPress == 3){
                isPress -= 3;
                Debug.Log("Press W third time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.W) && isPress == 5){
                isPress -= 5;
                Debug.Log("Wrong Combo: " + isPress);
            }
        }
        else if (Input.GetKeyDown(KeyCode.A)){
            if (isPress == 1){
                isPress += 1;
                Debug.Log("Press A first time:" + isPress);
            } 
            else if (Input.GetKeyDown(KeyCode.A) && isPress == 2){
                isPress -= 2;
                Debug.Log("Press A second time");
            }
            else if (Input.GetKeyDown(KeyCode.A) && isPress == 0){
                isPress = 0;
                Debug.Log("Press A: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.A) && isPress == 5){
                isPress -= 5;
                Debug.Log("Wrong Combo: " + isPress);
            }
        }
        else if (Input.GetKeyDown(KeyCode.S)){
            if (isPress == 2){
                isPress += 1;
                Debug.Log("Press S first time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.S) && isPress == 3){
                isPress -= 3;
                Debug.Log("Press S second time");
            }
            else if (Input.GetKeyDown(KeyCode.S) && isPress == 5){
                isPress -= 5;
                Debug.Log("Wrong Combo: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.S) && isPress == 0){
                isPress = 0;
                Debug.Log("Press S: " + isPress);
            }
        }
        else if (Input.GetKeyDown(KeyCode.D)){
            if (isPress == 3){
                isPress += 1;
                //New Combo
                // IEnumerator + StartCoroutine
                // StartCoroutiine(Timer(3f));
                Debug.Log("New Combo");
                Debug.Log("Press D first time: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.D) && isPress == 5){
                isPress -= 5;
                Debug.Log("Wrong Combo: " + isPress);
            }
            else if (Input.GetKeyDown(KeyCode.D) && isPress == 0){
                isPress = 0;
                Debug.Log("Press D: " + isPress);
            }
        }

        // // Next Combo ----------------------------------------------------------------------------------------------------

        // else if (Input.GetKeyDown(KeyCode.Y)){
        //     if (isPress == 4){
        //         isPress += 1;
        //         CharacterAnimator.SetBool("house",true);
        //         CharacterAnimator.SetBool("hipdance",false);
        //         CharacterAnimator.SetBool("idle",false);
        //         Debug.Log("Press Y first time: " + isPress);
        //     }
        //     else if (Input.GetKeyDown(KeyCode.Y) && isPress == 0){
        //         isPress = 0;
        //         Debug.Log("Press Y: " + isPress);
        //     }
        //     else if (Input.GetKeyDown(KeyCode.Y) && isPress == 5){
        //         isPress -= 5;
        //         Debug.Log("Press Y: " + isPress);
        //     }
        // }
        // else if (Input.GetKeyDown(KeyCode.U)){
        //     if (isPress == 5){
        //         isPress += 1;
        //         Debug.Log("Press U first time:" + isPress);
        //     }
        // else if (Input.GetKeyDown(KeyCode.U) && isPress == 6){
        //         isPress -= 6;
        //         Debug.Log("Press U: " + isPress);
        //     }
        // }







        // For Idle ---------------------------------------------------------------------------------------------------------------
        else if (Input.anyKeyDown) {
            isPress = 0;
        }
        else if (isPress == 0){
            CharacterAnimator.SetBool("idle",true);
            CharacterAnimator.SetBool("hipdance",false);
            CharacterAnimator.SetBool("house",false);
        }
    }
    IEnumerator Timer(){
        yield return new WaitForSeconds(3f);
    }
}

 