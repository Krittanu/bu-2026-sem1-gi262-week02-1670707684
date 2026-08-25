using System;

using UnityEngine;

using UnityEngine.Tilemaps;

namespace Workshop.Student

{

    public class MapGenerator : MonoBehaviour

    {

        public int columns = 10;

        public int rows = 10;

        public GameObject[] floorTiles;

        public GameObject[] wallTiles;

        public GameObject[] foodTiles;

        public string[,] saveItemMap = new string[3, 3]

        {

            { " ", "Soda", " " },

            { " ", " ", " " },

            { " ", " ", "Food" },

        };

        // 1. declare Players variable

        public GameObject player;

        // 7. declare Exit variable

        public GameObject exit;


        public void Start()

        {

            // 1. Player

            if (player != null)

            {

                Instantiate(

                    player,

                    new Vector2(0, 0),

                    Quaternion.identity

                );

            }


            // 3. Create Floor

            for (int floorY = 0; floorY < rows; floorY++)

            {

                for (int floorX = 0; floorX < columns; floorX++)

                {

                    int r = UnityEngine.Random.Range(

                        0,

                        floorTiles.Length

                    );

                    GameObject tile = Instantiate(

                        floorTiles[r],

                        new Vector2(floorX, floorY),

                        Quaternion.identity

                    );

                    tile.name = "Floor_" + floorX + "_" + floorY;

                }

            }


            // 4. Create Walls รอบนอก

            for (int wallY = -1; wallY < rows + 1; wallY++)

            {

                for (int wallX = -1; wallX < columns + 1; wallX++)

                {

                    if (

                        wallX == -1 ||

                        wallX == columns ||

                        wallY == -1 ||

                        wallY == rows

                    )

                    {

                        GameObject tile = Instantiate(

                            wallTiles[0],

                            new Vector2(wallX, wallY),

                            Quaternion.identity

                        );

                        tile.name = "Wall_" + wallX + "_" + wallY;

                    }

                }

            }


            // 2. Create Obstacles

            int obstacleX = columns / 2;

            for (int obstacleY = 0;

                 obstacleY < rows / 2;

                 obstacleY++)

            {

                GameObject tile = Instantiate(

                    wallTiles[0],

                    new Vector2(obstacleX, obstacleY),

                    Quaternion.identity

                );

                tile.name =

                    "Obstacle_" + obstacleX + "_" + obstacleY;

            }


            // 5. Random Foods

            int numberOfFoods = UnityEngine.Random.Range(1, 3);

            for (int foodIndex = 0;

                 foodIndex < numberOfFoods;

                 foodIndex++)

            {

                int foodX = UnityEngine.Random.Range(0, columns);

                int foodY = UnityEngine.Random.Range(0, rows);

                int foodRandom = UnityEngine.Random.Range(

                    0,

                    foodTiles.Length

                );

                Instantiate(

                    foodTiles[foodRandom],

                    new Vector2(foodX, foodY),

                    Quaternion.identity

                );

            }


            // 6. Generate Item

            for (int mapY = 0;

                 mapY < saveItemMap.GetLength(0);

                 mapY++)

            {

                for (int mapX = 0;

                     mapX < saveItemMap.GetLength(1);

                     mapX++)

                {

                    string item = saveItemMap[mapX, mapY];

                    if (!string.IsNullOrWhiteSpace(item))

                    {

                        foreach (var foodTile in foodTiles)

                        {

                            if (foodTile.name == item)

                            {

                                Instantiate(

                                    foodTile,

                                    new Vector2(mapX, mapY),

                                    Quaternion.identity

                                );

                                break;

                            }

                        }

                    }

                }

            }


            // 7. Exit ขวาบน

            if (exit != null)

            {

                Instantiate(

                    exit,

                    new Vector2(columns - 1, rows - 1),

                    Quaternion.identity

                );

            }

        }

    }

}
