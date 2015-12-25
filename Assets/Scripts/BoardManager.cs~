using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour {

    public class Count {
        public int min, max;

        public Count(int a, int b) {
            min = a;
            max = b;
        }
    }

    public int columns = 8;
    public int rows = 8;
    public Count wallCount = new Count(5, 9);
    public Count foodCount = new Count(1, 5);
    public GameObject exit;
    public GameObject[] floorTiles;
    public GameObject[] wallTiles;
    public GameObject[] foodTiles;
    public GameObject[] enemyTiles;
    public GameObject[] outerWallTiles;

    private Transform boardHolder;
    private List<Vector3> gridPositions = new List<Vector3>();

    void InitializeList() {
        gridPositions.Clear();

        for (int x = 1; x < columns - 1; x++) {
            for (int y = 1; y < rows - 1; y++) {
                gridPositions.Add(new Vector3(x, y, 0f));
            }
        }
    }

    void BoardSetup() {
        boardHolder = new GameObject("Board").transform;

        for (int a = -1; a < columns + 1; a++) {
            for (int b = -1; b < rows + 1; b++) {
                GameObject toInstantiate = floorTiles[Random.Range(0, floorTiles.Length)];
                if (a == -1 || a == columns || b == -1 || b == rows) {
                    toInstantiate = wallTiles[Random.Range(0,wallTiles.Length)];
                }
                GameObject instance = Instantiate(toInstantiate, new Vector3(a, b, 0f), Quaternion.identity) as GameObject;
                instance.transform.SetParent(boardHolder);
            }
        }
    }

    Vector3 RandomPosition() {
        int randomIndex = Random.Range(0, gridPositions.Count);
        Vector3 randomPos = gridPositions[randomIndex];
        gridPositions.RemoveAt(randomIndex);
        return randomPos;
    }

    void LayoutObjectAtRandom(GameObject[] tileArray, int min, int max) {
        int objCount = Random.Range(min, max + 1);
        for (int a = 0; a < objCount; a++) {
            Vector3 rp = RandomPosition();
            GameObject tile = tileArray[Random.Range(0,tileArray.Length)];
            Instantiate(tile, rp, Quaternion.identity);
        }
    }
    public void SetupScene(int lvl) {
        BoardSetup();
        InitializeList();
        LayoutObjectAtRandom(wallTiles, wallCount.min, wallCount.max);
        LayoutObjectAtRandom(foodTiles, foodCount.min, foodCount.max);
        Debug.Log(lvl);
        int enemyCount = (int)Mathf.Log(lvl, 2);
        LayoutObjectAtRandom(enemyTiles, enemyCount, enemyCount);
        Debug.Log(enemyCount);
        Instantiate(exit, new Vector3(columns - 1, rows - 1, 0f), Quaternion.identity);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
