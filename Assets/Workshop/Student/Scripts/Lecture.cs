using System.Collections;

using System.Collections.Generic;

using System.Text;

using Unity.VisualScripting;

using UnityEngine;

namespace Assignment

{

    public class Lecture : MonoBehaviour

    {

        void Start()

        {

            // LCT01_SyntaxArray();

            // LCT02_ArrayInitialize();

            // LCT03_SyntaxLoop();

            // LCT04_LoopAndArray();

            // LCT05_Syntax2DArray();

            // LCT06_SizeOf2DArray();

            // LCT07_SyntaxNestedLoop();

        }

        #region Lecture

        public string[] ironManSuit = new string[2];

        public void LCT01_SyntaxArray()

        {

            string[] _ironManSuit = new string[2];

            _ironManSuit[0] = "Mark I";

            _ironManSuit[1] = "Mark II";

            string tonyStarWear = ironManSuit[0];

            Debug.Log("tonyStar Wear " + tonyStarWear);

            Debug.Log("Room size: " + ironManSuit.Length);

            Debug.Log(_ironManSuit[0]);

            Debug.Log(_ironManSuit[1]);

        }


        public void LCT02_ArrayInitialize()

        {

            string[] spidermanSuits =

                new string[] { "Classic", "Black Suit", "Iron Spider" };

            string[] batmanSuits =

                new string[2] { "Classis batman", "White bat" };

            Debug.Log("Room size: " + spidermanSuits.Length);

            Debug.Log(spidermanSuits[0]);

            Debug.Log(spidermanSuits[1]);

            Debug.Log(spidermanSuits[2]);

            Debug.Log("Room size: " + batmanSuits.Length);

            Debug.Log(batmanSuits[0]);

            Debug.Log(batmanSuits[1]);

        }


        public void LCT03_SyntaxLoop()

        {

            for (int i = 0; i < 10; i++)

            {

                Debug.Log("<10 : " + i);

            }

            for (int i = 1; i <= 10; i++)

            {

                Debug.Log("<=10 : " + i);

            }

        }


        [Header("LCT04_LoopAndArray")]

        public string[] lct04_ironManSuitNames;

        public void LCT04_LoopAndArray()

        {

            // lct04_ironManSuitNames =

            //     new string[] { "Mark I", "Mark II", "Mark III" };

            Debug.Log("====== Log by One incrementer ======");

            for (int i = 0; i < lct04_ironManSuitNames.Length; i++)

            {

                Debug.Log(lct04_ironManSuitNames[i]);

            }

            Debug.Log("====== Log by Two incrementer ======");

            for (int i = 0; i < lct04_ironManSuitNames.Length; i += 2)

            {

                Debug.Log(lct04_ironManSuitNames[i]);

            }

        }


        public void LCT05_Syntax2DArray()

        {

            int[,] my2DArray = new int[3, 3]

            {

                { 1, 2, 3 },

                { 4, 5, 6 },

                { 7, 8, 9 }

            };

            // GetLength(0) = Row

            for (int row = 0; row < my2DArray.GetLength(0); row++)

            {

                string rowStr = "";

                // GetLength(1) = Column

                for (int col = 0; col < my2DArray.GetLength(1); col++)

                {

                    rowStr += my2DArray[row, col] + " ";

                }

                Debug.Log(rowStr);

            }

        }


        private void PrintBoard(string[,] board)

        {

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)

            {

                sb.AppendLine("-------------");

                sb.AppendLine(

                    "| " + board[i, 0] +

                    " | " + board[i, 1] +

                    " | " + board[i, 2] + " |"

                );

            }

            sb.AppendLine("-------------");

            Debug.Log(sb.ToString());

        }

        #endregion

    }

}

