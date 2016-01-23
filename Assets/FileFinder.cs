using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;

public class FileFinder : MonoBehaviour {

    public GameObject myCube;
    public Vector3 spawnSpot = new Vector3(0, 2, 0);
    public int varDist = 5;
    private object otherObj;

    // Use this for initialization
    void Start ()
    {
            varDist = 5;
            var playerObject = GameObject.Find("Player");
            var playerPos = playerObject.transform.position;

            var info = new DirectoryInfo("U:/Users/El-Amir");
            var fileInfo = info.GetFiles();
            foreach (FileInfo file in fileInfo) genFile(file, playerPos);

            var dinfo = new DirectoryInfo("U:/Users/El-Amir");
            var dirInfo = dinfo.GetDirectories();
            foreach (DirectoryInfo dir in dirInfo) genDir(dir, playerPos);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void genFile(FileInfo name, Vector3 playerPos)
    {
        GameObject cubeSpawn = (GameObject)Instantiate(myCube, new Vector3(playerPos.x + varDist, 
                                                                           playerPos.y + varDist, 
                                                                           playerPos.z), transform.rotation);
    }
    void genDir(DirectoryInfo name, Vector3 playerPos)
    {
        GameObject cubeSpawn = (GameObject)Instantiate(myCube, new Vector3(playerPos.x + varDist, 
                                                                           playerPos.y + varDist, 
                                                                           playerPos.z), transform.rotation);
    }
}
