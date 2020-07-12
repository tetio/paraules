using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    private WordDB db;

    public GameObject[] aTiles;
    public Dictionary<string, GameObject> tiles = new Dictionary<string, GameObject>();
    public string a;

    // Start is called before the first frame update
    void Start()
    {
        tiles.Add("A", aTiles[0]);
        tiles.Add("B", aTiles[1]);
        tiles.Add("C", aTiles[2]);
        tiles.Add("D", aTiles[3]);
        tiles.Add("E", aTiles[4]);
        tiles.Add("F", aTiles[5]);
        tiles.Add("G", aTiles[6]);
        tiles.Add("H", aTiles[7]);
        tiles.Add("I", aTiles[8]);
        tiles.Add("J", aTiles[9]);
        tiles.Add("K", aTiles[10]);
        tiles.Add("L", aTiles[11]);
        tiles.Add("M", aTiles[12]);
        tiles.Add("N", aTiles[13]);
        tiles.Add("O", aTiles[14]);
        tiles.Add("P", aTiles[15]);
        tiles.Add("Q", aTiles[16]);
        tiles.Add("R", aTiles[17]);
        tiles.Add("S", aTiles[18]);
        tiles.Add("T", aTiles[19]);
        tiles.Add("U", aTiles[20]);
        tiles.Add("V", aTiles[21]);
        tiles.Add("X", aTiles[22]);
        tiles.Add("Z", aTiles[23]);
        tiles.Add("Ç", aTiles[24]);
        tiles.Add("2", aTiles[25]); // L·L
        tiles.Add("1", aTiles[26]); // NY

        Instantiate(tiles["A"], new Vector3(-5,3,0), tiles["A"].transform.rotation);
        Instantiate(tiles["B"], new Vector3(-4,3,0), tiles["A"].transform.rotation);
        Instantiate(tiles["C"], new Vector3(-3,3,0), tiles["A"].transform.rotation);
        Instantiate(tiles["D"], new Vector3(-2,3,0), tiles["A"].transform.rotation);
        Instantiate(tiles["E"], new Vector3(-1,3,0), tiles["A"].transform.rotation);
        Instantiate(tiles["F"], new Vector3(0,3,0), tiles["A"].transform.rotation);
        Instantiate(tiles["G"], new Vector3(1,3,0), tiles["A"].transform.rotation);
        Instantiate(tiles["H"], new Vector3(2,3,0), tiles["A"].transform.rotation);
        Instantiate(tiles["I"], new Vector3(3,3,0), tiles["A"].transform.rotation);
        Instantiate(tiles["J"], new Vector3(4,3,0), tiles["A"].transform.rotation);
        Instantiate(tiles["K"], new Vector3(5,3,0), tiles["A"].transform.rotation);
        Instantiate(tiles["L"], new Vector3(-5,2,0), tiles["A"].transform.rotation);
        Instantiate(tiles["M"], new Vector3(-3,2,0), tiles["A"].transform.rotation);
        Instantiate(tiles["N"], new Vector3(-4,2,0), tiles["A"].transform.rotation);
        Instantiate(tiles["O"], new Vector3(-2,2,0), tiles["A"].transform.rotation);
        Instantiate(tiles["P"], new Vector3(-1,2,0), tiles["A"].transform.rotation);
        Instantiate(tiles["Q"], new Vector3(0,2,0), tiles["A"].transform.rotation);
        Instantiate(tiles["R"], new Vector3(1,2,0), tiles["A"].transform.rotation);
        Instantiate(tiles["S"], new Vector3(2,2,0), tiles["A"].transform.rotation);
        Instantiate(tiles["T"], new Vector3(-5,1,0), tiles["A"].transform.rotation);
        Instantiate(tiles["U"], new Vector3(-4,1,0), tiles["A"].transform.rotation);
        Instantiate(tiles["V"], new Vector3(-3,1,0), tiles["A"].transform.rotation);
        Instantiate(tiles["X"], new Vector3(-2,1,0), tiles["A"].transform.rotation);
        Instantiate(tiles["Z"], new Vector3(-1,1,0), tiles["A"].transform.rotation);
        Instantiate(tiles["Ç"], new Vector3(0,1,0), tiles["A"].transform.rotation);
        Instantiate(tiles["1"], new Vector3(1,1,0), tiles["A"].transform.rotation);
        Instantiate(tiles["2"], new Vector3(2,1,0), tiles["A"].transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
       
    // Update is called once per frame
    void Awake()
    {
        db = new WordDB("ca");
        Debug.Log("We have words!!!");
        Debug.Log("At least we have "+db.dictionary.Count+" word(s)");
        Debug.Log("'OCELL' exists "+db.dictionary.Contains("OCELL")+" word(s)");
        Debug.Log("'CAÇA' exists "+db.dictionary.Contains("CAÇA")+" word(s)");
        Debug.Log("'HUND' does not exist? "+!db.dictionary.Contains("HUND"));
        Debug.Log("There are  "+db.words7.Count+" words of length 7");
        Debug.Log("There are  "+db.words5.Count+" words of length 5");
        //Debug.Log("There are  "+db.words5.Count+" words of length 5");
    }
}
