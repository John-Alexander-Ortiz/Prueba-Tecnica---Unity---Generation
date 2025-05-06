using UnityEngine;

public class Sphere : MonoBehaviour
{
    private GameManager sphereClick;
     public MeshRenderer meshRenderer;
    private void Start()
    {
        sphereClick = FindAnyObjectByType<GameManager>();
        meshRenderer.material.color= Random.ColorHSV();
    }

    
    private void OnMouseDown()
    {
       
        Destroy(gameObject);
        sphereClick.RemoveFromList(gameObject);
       
    }
}