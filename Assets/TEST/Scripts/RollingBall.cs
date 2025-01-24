using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RollingBall : MonoBehaviour
{
    [Header("Ball Properties")]
    public Rigidbody ballPhysics;
    public float baseForce = 50f;

    [Header("Gameplay Settings")]
    public int currentScore = 0;
    private int attemptsMade = 0;
<<<<<<< HEAD
    private const int maxTries = 5;
=======
<<<<<<< HEAD
    private const int maxTries = 5;
=======
    private const int maxTries = 3 ;
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)

    private bool isRolling = false;
    private Vector3 startingPosition;

    public List<GameObject> bowlingPins = new List<GameObject>();
    private Dictionary<GameObject, Vector3> initialPinPositions = new Dictionary<GameObject, Vector3>();
    private Dictionary<GameObject, Quaternion> initialPinRotations = new Dictionary<GameObject, Quaternion>();

    [Header("Power Adjustment")]
    public float forceMultiplier = 0f;
    public progres_Bar powerIndicator;

    public GameObject Fallow_Camra;


    [Header("Panels : \n")]
    public GameObject Win_Panel;
    public GameObject Lost_Panel;

    public bool Game_is_Finish = false;

<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

    public float retern_time = 3f;
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
    private void Start()
    {
        attemptsMade++;
        ballPhysics = GetComponent<Rigidbody>();
        startingPosition = transform.position;

        GameObject[] foundPins = GameObject.FindGameObjectsWithTag("Pin");
        foreach (GameObject pin in foundPins)
        {
            bowlingPins.Add(pin);
            initialPinPositions[pin] = pin.transform.position;
            initialPinRotations[pin] = pin.transform.rotation;
        }

        
    }

    private void Update()
    {
        if (Game_is_Finish)
            return;

        if (isRolling)
            return;

        AdjustPower();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ThrowBall());
        }
    }

    private IEnumerator ThrowBall()
    {
        isRolling = true;

        ballPhysics.isKinematic = false;
<<<<<<< HEAD
        Vector3 throwDirection = Camera.main.transform.forward * (baseForce * forceMultiplier);
=======
<<<<<<< HEAD
        Vector3 throwDirection = Camera.main.transform.forward * (baseForce * forceMultiplier);
=======
        Vector3 throwDirection = Camera.main.transform.forward/2 * (baseForce * forceMultiplier);
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
        Vector3 impactPoint = transform.position + transform.forward * 0.3f;

        ballPhysics.AddForceAtPosition(throwDirection, impactPoint, ForceMode.Impulse);
        Fallow_Camra.SetActive(true);


<<<<<<< HEAD
        yield return new WaitForSeconds(3f); 
=======
<<<<<<< HEAD
        yield return new WaitForSeconds(3f); 
=======
        yield return new WaitForSeconds(retern_time); 
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
        
        isRolling = false;
        attemptsMade++;

        if (currentScore >= 10)
        {
            Game_is_Finish = true;
            TriggerVictory();
        }
        else if (attemptsMade >= maxTries)
        {
            Game_is_Finish = true;
            TriggerDefeat();
        }
        else
        {
            ResetBallAndPins();
            Fallow_Camra.SetActive(false);
<<<<<<< HEAD
            Fallow_Camra.transform.position = new Vector3(62.80375f, 1.39432f, -48.38221f); 
          
        }
=======
<<<<<<< HEAD
            Fallow_Camra.transform.position = new Vector3(62.80375f, 1.39432f, -48.38221f); 
          
        }
=======
            if (SceneManager.GetActiveScene().name == "Level 2")
            {
                Fallow_Camra.transform.position = new Vector3(91.09405f, 48.18733f, -167.6766f);

            }
            else
            {
                Fallow_Camra.transform.position = new Vector3(62.80375f, 1.39432f, -48.38221f);
            }        
}
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
    }

    private void ResetBallAndPins()
    {
        ballPhysics.isKinematic = true;
        ballPhysics.linearVelocity = Vector3.zero;
        ballPhysics.angularVelocity = Vector3.zero;

        transform.position = startingPosition;
        transform.rotation = Quaternion.identity;

      
    }

    private void TriggerVictory()
    {
        Debug.Log("You won! All pins are down!");
<<<<<<< HEAD
        StartCoroutine(ReloadSceneAfterDelay());
=======
<<<<<<< HEAD
        StartCoroutine(ReloadSceneAfterDelay());
=======
        Win_Panel.SetActive(true);
        //StartCoroutine(ReloadSceneAfterDelay());
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
    }

    private void TriggerDefeat()
    {
        Debug.Log("Game Over! Try again.");
<<<<<<< HEAD
        StartCoroutine(ReloadSceneAfterDelay());
=======
<<<<<<< HEAD
        StartCoroutine(ReloadSceneAfterDelay());
=======
        Lost_Panel.SetActive(true);
        //StartCoroutine(ReloadSceneAfterDelay());
>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
    }

    private IEnumerator ReloadSceneAfterDelay()
    {
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void AdjustPower()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            forceMultiplier = Mathf.Min(forceMultiplier + Time.deltaTime, 1f);
            powerIndicator.Set_Progrees_Bar_Ammount(forceMultiplier);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            forceMultiplier = Mathf.Max(forceMultiplier - Time.deltaTime, 0f);
            powerIndicator.Set_Progrees_Bar_Ammount(forceMultiplier);
        }
    }

    public void OnPinFallen()
    {
        currentScore++;
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
     

>>>>>>> 367e0f9 (add level2 and sound)
>>>>>>> 47e1bc3 (add level2 and sound)
        if (currentScore >= 10)
        {
            TriggerVictory();
        }
    }
}
