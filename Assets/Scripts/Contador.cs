using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    public int sphereRest;
    public TextMeshProUGUI contadorText;
    public 
    void Start()
    {
        

    }

    
    void Update()
    {
        sphereRest = FindObjectsByType<Sphere>(FindObjectsSortMode.None).Length;
        contadorText.text = "Esferas: " + sphereRest;
    }
}
