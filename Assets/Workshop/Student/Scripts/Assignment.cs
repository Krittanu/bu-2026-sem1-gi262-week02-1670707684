using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Assignment
{
    public class Assignment : MonoBehaviour
    {
        public void Start()
        {
            // เปิดทีละข้อเพื่อทดสอบ

             // AS01_RandomItemDrop();
            // AS02_NestedLoopForCreate2DMap();
            // AS03_NestedLoopForMakingWallAround();
            // AS04_AttackEnemy();
            // AS05_DynamicIterationLoop();
            // AS06_WhileLoopAndArray();
            // AS07_HealTargetAtIndex();
            // AS08_RandomPickingDialogue();
            // AS09_MultiplicationTable();
            // AS10_FindSummationFromZeroToNUsingWhileLoop();
            // AS11_SpawnEnemies();
            // StartCoroutine(AS12_CountTime());
            // AS13_SumOfNumbersInRow();
            // AS14_SumOfNumbersInColumn();
            // AS15_MakeTheTriangle();
            // AS16_MultiplicationTableOf_2_3_and_4();
            // EX_01_TicTacToeGame_TurnPlay();
        }

        #region Assignment

        // =========================
        // AS01 Random Item Drop
        // =========================

        [Header("AS01_RandomItemDrop")]
        public GameObject[] as01_items;

        public void AS01_RandomItemDrop()
        {
            int r = UnityEngine.Random.Range(0, as01_items.Length);

            GameObject go = Instantiate(
                as01_items[r],
                transform.position,
                transform.rotation
            );

            Debug.Log($"Got item: {go.name}");
        }


        // =========================
        // AS02 Create 2D Map
        // =========================

        [Header("AS02_NestedLoopForCreate2DMap")]
        public GameObject[] as02_floorTiles;
        public int as02_columns;
        public int as02_rows;

        public void AS02_NestedLoopForCreate2DMap()
        {
            for (int y = 0; y < as02_rows; y++)
            {
                for (int x = 0; x < as02_columns; x++)
                {
                    int r = UnityEngine.Random.Range(
                        0,
                        as02_floorTiles.Length
                    );

                    GameObject obj = as02_floorTiles[r];

                    GameObject tile = Instantiate(
                        obj,
                        new Vector2(x, y),
                        transform.rotation
                    );

                    Console.Write(tile.name);
                }

                Console.WriteLine();
            }
        }


        // =========================
        // AS03 Making Wall Around
        // =========================

        [Header("AS03_NestedLoopForMakingWallAround")]
        public GameObject as03_wall;
        public int as03_columns;
        public int as03_rows;

        public void AS03_NestedLoopForMakingWallAround()
        {
            for (int y = -1; y <= as03_rows; y++)
            {
                for (int x = -1; x <= as03_columns; x++)
                {
                    if (x == -1 ||
                        x == as03_columns ||
                        y == -1 ||
                        y == as03_rows)
                    {
                        Instantiate(
                            as03_wall,
                            new Vector2(x, y),
                            transform.rotation
                        );

                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }


        // =========================
        // AS04 Attack Enemy
        // =========================

        [Header("AS04_AttackEnemy")]
        public int[] as04_enemyHP;
        public int as04_damage;
        public int as04_target;

        public void AS04_AttackEnemy()
        {
            // Attack ตัวแรก
            as04_enemyHP[0] -= as04_damage;

            Debug.Log(
                $"FirstEnemy hp :{as04_enemyHP[0]}"
            );


            // Attack ตัวสุดท้าย
            int lastIndex = as04_enemyHP.Length - 1;

            as04_enemyHP[lastIndex] -= as04_damage;

            Debug.Log(
                $"LastEnemy hp :{as04_enemyHP[lastIndex]}"
            );


            // Attack ตัวที่กำหนด
            as04_enemyHP[as04_target] -= as04_damage;

            Debug.Log(
                $"TargetEnemy {as04_target} hp :{as04_enemyHP[as04_target]}"
            );
        }


        // =========================
        // AS05 Dynamic Iteration
        // =========================

        [Header("AS05_DynamicIterationLoop")]
        public int as05_n;

        public void AS05_DynamicIterationLoop()
        {
            for (int i = 0; i < as05_n; i++)
            {
                Debug.Log(i);
            }
        }


        // =========================
        // AS06 While Loop + Array
        // =========================

        [Header("AS06_WhileLoopAndArray")]
        public string[] as06_ironManSuitNames;

        public void AS06_WhileLoopAndArray()
        {
            Debug.Log("======Log by One======");

            int i = 0;

            while (i < as06_ironManSuitNames.Length)
            {
                Debug.Log(as06_ironManSuitNames[i]);

                i += 1;
            }


            Debug.Log("======Log by Two======");

            i = 0;

            while (i < as06_ironManSuitNames.Length)
            {
                Debug.Log(as06_ironManSuitNames[i]);

                i += 2;
            }
        }


        // =========================
        // AS07 Heal Target
        // =========================

        [Header("AS07_HealTargetAtIndex")]
        public int[] as07_heroHPs;
        public int as07_heal;
        public int as07_targetIndex;

        public void AS07_HealTargetAtIndex()
        {
            // Heal ตัวแรก
            as07_heroHPs[0] += as07_heal;

            Debug.Log(
                $"FirstHero hp :{as07_heroHPs[0]}"
            );


            // Heal ตัวสุดท้าย
            int lastIndex = as07_heroHPs.Length - 1;

            as07_heroHPs[lastIndex] += as07_heal;

            Debug.Log(
                $"LastHero hp :{as07_heroHPs[lastIndex]}"
            );


            // Heal ตัวที่กำหนด
            as07_heroHPs[as07_targetIndex] += as07_heal;

            Debug.Log(
                $"TargetHero {as07_targetIndex} hp :{as07_heroHPs[as07_targetIndex]}"
            );
        }


        // =========================
        // AS08 Random Dialogue
        // =========================

        [Header("AS08_RandomPickingDialogue")]
        public string[] as08_dialogues;

        public void AS08_RandomPickingDialogue()
        {
            int r = UnityEngine.Random.Range(
                0,
                as08_dialogues.Length
            );

            Debug.Log(as08_dialogues[r]);
        }


        // =========================
        // AS09 Multiplication Table
        // =========================

        [Header("AS09_MultiplicationTable")]
        public int as09_n;

        public void AS09_MultiplicationTable()
        {
            for (int i = 1; i <= 12; i++)
            {
                Debug.Log(
                    $"{as09_n}x{i}={as09_n * i}"
                );
            }
        }


        // =========================
        // AS10 Summation
        // =========================

        [Header("AS10_FindSummationFromZeroToNUsingWhileLoop")]
        public int as10_n;

        public void AS10_FindSummationFromZeroToNUsingWhileLoop()
        {
            int sum = 0;
            int i = 1;

            while (i <= as10_n)
            {
                sum += i;

                i++;
            }

            Debug.Log(
                $"ผลรวมของ n จาก 1 ถึง {as10_n} คือ {sum}"
            );
        }


        // =========================
        // AS11 Spawn Enemies
        // =========================

        [Header("AS11_SpawnEnemies")]
        public int[] as11_enemyHPs;
        public GameObject as11_enemyPrefab;

        public void AS11_SpawnEnemies()
        {
            for (int i = 0; i < as11_enemyHPs.Length; i++)
            {
                Vector2 spawnPosition =
                    transform.position +
                    new Vector3(i + 1, 0, 0);

                GameObject enemy = Instantiate(
                    as11_enemyPrefab,
                    spawnPosition,
                    transform.rotation
                );

                enemy.name = "Enemy_" + i;

                Debug.Log(
                    $"Spawn Enemy {i} HP : {as11_enemyHPs[i]}"
                );
            }
        }


        // =========================
        // AS12 Coroutine Timer
        // =========================

        [Header("AS12_CountTime")]
        public float as12_countTime;

        public IEnumerator AS12_CountTime()
        {
            float time = as12_countTime;

            while (time > 0)
            {
                Debug.Log($"Time : {time}");

                yield return new WaitForSeconds(1f);

                time--;
            }

            Debug.Log("Time's up!");
        }


        // =========================
        // AS13 Sum Row
        // =========================

        [Header("AS13_SumOfNumbersInRow")]
        public Grid2DInt as13_matrix = new Grid2DInt
        {
            rows = 3,
            cols = 3,
            data = new int[]
            {
                1, 2, 3,
                4, 5, 6,
                7, 8, 9
            }
        };

        public int as13_row;

        public void AS13_SumOfNumbersInRow()
        {
            var matrix = as13_matrix.Get2DArray();

            int sum = 0;

            for (
                int col = 0;
                col < matrix.GetLength(1);
                col++
            )
            {
                sum += matrix[as13_row, col];
            }

            Debug.Log(
                $"Row {as13_row} Sum = {sum}"
            );
        }


        // =========================
        // AS14 Sum Column
        // =========================

        [Header("AS14_SumOfNumbersInColumn")]
        public Grid2DInt as14_matrix = new Grid2DInt
        {
            rows = 3,
            cols = 3,
            data = new int[]
            {
                1, 2, 3,
                4, 5, 6,
                7, 8, 9
            }
        };

        public int as14_column;

        public void AS14_SumOfNumbersInColumn()
        {
            var matrix = as14_matrix.Get2DArray();

            int sum = 0;

            for (
                int row = 0;
                row < matrix.GetLength(0);
                row++
            )
            {
                sum += matrix[row, as14_column];
            }

            Debug.Log(
                $"Column {as14_column} Sum = {sum}"
            );
        }


        // =========================
        // AS15 Triangle
        // =========================

        [Header("AS15_MakeTheTriangle")]
        public int as15_size;

        public void AS15_MakeTheTriangle()
        {
            for (
                int i = 1;
                i <= as15_size;
                i++
            )
            {
                string line = "";

                for (
                    int j = 1;
                    j <= i;
                    j++
                )
                {
                    line += "*";
                }

                Debug.Log(line);
            }
        }


        // =========================
        // AS16 Multiplication 2 3 4
        // =========================

        

        public void AS16_MultiplicationTableOf_2_3_and_4()
        {
            for (int i = 1; i <= 12; i++)
            {
                string line = "";

                for (int j = 2; j <= 4; j++)
                {
                    line += $"{j} x {i} = {j * i}";

                    if (j < 4)
                    {
                        line += "\t";
                    }
                }

                Debug.Log(line);
            }
        }

        #endregion


        #region Extra assignment

        // =========================
        // Extra 01 Tic Tac Toe
        // =========================

        [Header("EX_01_TicTacToeGame_TurnPlay")]
        public Grid2DString ex01_board = new Grid2DString
        {
            rows = 3,
            cols = 3,
            data = new string[]
            {
                "X", "X", "O",
                "X", "O", "X",
                "", "", ""
            }
        };

        public string ex01_playerTurn = "O";
        public int ex01_row = 2;
        public int ex01_column = 0;

        public void EX_01_TicTacToeGame_TurnPlay()
        {
            var board = ex01_board.Get2DArray();


            // Check Player
            if (
                ex01_playerTurn != "X" &&
                ex01_playerTurn != "O"
            )
            {
                PrintBoard(board);

                Debug.Log(">> Invalid move");

                return;
            }


            // Check Position
            if (
                ex01_row < 0 ||
                ex01_row >= 3 ||
                ex01_column < 0 ||
                ex01_column >= 3
            )
            {
                PrintBoard(board);

                Debug.Log(">> Invalid move");

                return;
            }


            // Check ช่องว่าง
            if (
                !string.IsNullOrEmpty(
                    board[ex01_row, ex01_column]
                )
            )
            {
                PrintBoard(board);

                Debug.Log(">> Invalid move");

                return;
            }


            // ใส่ X หรือ O
            board[
                ex01_row,
                ex01_column
            ] = ex01_playerTurn;


            // Print Board
            PrintBoard(board);


            // =========================
            // Check Win
            // =========================

            bool win = false;


            // Check Row
            for (int row = 0; row < 3; row++)
            {
                if (
                    board[row, 0] == ex01_playerTurn &&
                    board[row, 1] == ex01_playerTurn &&
                    board[row, 2] == ex01_playerTurn
                )
                {
                    win = true;
                }
            }


            // Check Column
            for (int col = 0; col < 3; col++)
            {
                if (
                    board[0, col] == ex01_playerTurn &&
                    board[1, col] == ex01_playerTurn &&
                    board[2, col] == ex01_playerTurn
                )
                {
                    win = true;
                }
            }


            // Check Diagonal \
            if (
                board[0, 0] == ex01_playerTurn &&
                board[1, 1] == ex01_playerTurn &&
                board[2, 2] == ex01_playerTurn
            )
            {
                win = true;
            }


            // Check Diagonal /
            if (
                board[0, 2] == ex01_playerTurn &&
                board[1, 1] == ex01_playerTurn &&
                board[2, 0] == ex01_playerTurn
            )
            {
                win = true;
            }


            // ถ้าชนะ
            if (win)
            {
                Debug.Log(
                    $">> {ex01_playerTurn} Win!"
                );

                return;
            }


            // =========================
            // Check Draw
            // =========================

            bool full = true;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (
                        string.IsNullOrEmpty(
                            board[row, col]
                        )
                    )
                    {
                        full = false;
                    }
                }
            }


            if (full)
            {
                Debug.Log(">> Draw");
            }
            else
            {
                Debug.Log(">> Continue");
            }
        }

        #endregion


        // =========================
        // Print TicTacToe Board
        // =========================

        private void PrintBoard(string[,] board)
        {
            StringBuilder sb = new();

            for (int i = 0; i < 3; i++)
            {
                sb.AppendLine("-------------");

                sb.AppendLine(
                    "| " +
                    spaceIfEmpty(board[i, 0]) +
                    " | " +
                    spaceIfEmpty(board[i, 1]) +
                    " | " +
                    spaceIfEmpty(board[i, 2]) +
                    " |"
                );
            }

            sb.AppendLine("-------------");

            Debug.Log(sb.ToString());
        }


        private string spaceIfEmpty(string value)
        {
            return string.IsNullOrEmpty(value)
                ? " "
                : value;
        }
    }
}