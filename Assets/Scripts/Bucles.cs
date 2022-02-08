using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{
    public int numberinitial = 10;
    public GameObject[] enemyprefab;
    public Vector3[] positions;
    public GameObject Enemy;
   
    void Start()
    {
        /*
        for (int i = numberinitial; i >= 0; i--)
        {
            Debug.Log(i);
        }

        /*for (int s = 0; s < positions.Length; s++)
        {
            Instantiate(enemyprefab, positions[s], enemyprefab.transform.rotation);
        }

        for (int s = 0; s < positions.Length; s++)
        {
            Instantiate(enemyprefab[s], positions[s], enemyprefab[s].transform.rotation);
        }

        foreach(Vector3 pos in positions)
        {
            Instantiate(Enemy,pos, Enemy.transform.rotation);
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(FadeCorroutine());
        }
    }

    public IEnumerator FadeCorroutine()
    {
        float alphaValue = 0;
        MeshRenderer cubeMeshRenderer = GetComponent<MeshRenderer>();
        Color color = cubeMeshRenderer.material.color;

        while (alphaValue <= 1)
        {
            color.a = alphaValue;
            Debug.Log(color);
            cubeMeshRenderer.material.color = color;
            alphaValue += 0.1f;
            yield return new WaitForSeconds(1);


        }






    }
}
