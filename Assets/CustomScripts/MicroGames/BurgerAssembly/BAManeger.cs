using InterDineMension.MicroGame.BA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

namespace InterDineMension.MicroGame.BA
{
    public class BAManeger : MonoBehaviour
    {
        public TextMeshProUGUI leftOrder, rightOrder;
        public static List<BurgerIngredients.ingredientType> orderedIngredients=new List<BurgerIngredients.ingredientType> ();
        public GameObject lane1, lane2, lane3;//lanes will increase with higher difficulty
        /// <summary>
        /// an enum to determine the state of the microgame
        /// </summary>
        public enum phase//this will determine what will spawn
        {
            bottomBun, pickle, lettuce, Patty, condiment, veggie, topBun
        };
        public phase bAState=phase.bottomBun;
        /// <summary>
        /// lists of objects that can spawn in the microgame
        /// </summary>
        public List<GameObject> bottomBunOptions = new List<GameObject>();
        public List<GameObject> pickleOptions=new List<GameObject>();
        public List<GameObject> lettuceOptions = new List<GameObject>();
        public List<GameObject> PattyOptions = new List<GameObject>();
        public List<GameObject> condimentsOptions = new List<GameObject>();
        public List<GameObject> veggieOptions = new List<GameObject>();
        public List<GameObject> topBunOptions = new List<GameObject>();
        public List<GameObject> toSpawn=new List<GameObject>();

        public void StartMicroGame(List<BurgerIngredients.ingredientType> ingredients)
        {
            for (int i = 0; i < ingredients.Count; i++)
            {
                orderedIngredients.Add(ingredients[i]);
            }
        }

        // Start is called before the first frame update
        /// <summary>
        /// randomizes the placement of the items
        /// </summary>
        /// 
        //TODO make a 
        public void StartTheNextPhase()
        {
            switch (bAState)
            {
                case phase.bottomBun:
                    shuffleList(bottomBunOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    toSpawn.Clear();
                    bAState = phase.pickle;
                    break;
                case phase.pickle:
                    shuffleList(pickleOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    toSpawn.Clear();
                    bAState = phase.lettuce;
                    break;
                case phase.lettuce:
                    shuffleList(lettuceOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    toSpawn.Clear();
                    bAState = phase.Patty;
                    break;
                case phase.Patty:
                    shuffleList(PattyOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    toSpawn.Clear();
                    bAState = phase.condiment;
                    break;
                case phase.condiment:
                    shuffleList(condimentsOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    toSpawn.Clear();
                    bAState = phase.veggie;
                    break;
                case phase.veggie:
                    shuffleList(veggieOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    toSpawn.Clear();
                    bAState = phase.topBun;
                    break;
                case phase.topBun:
                    shuffleList(topBunOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    toSpawn.Clear();
                    break;
                default:
                    break;
            }
        }
        //code help by wideeyenow_unity at https://discussions.unity.com/t/how-can-i-shuffle-a-list/75012/7

        public void shuffleList(List<GameObject> toShuffle)
        {
            List<GameObject> temp = new List<GameObject>();
            temp.AddRange(toShuffle);
            for (int i = 0; i < toShuffle.Count; i++)
            {
                int index=Random.Range(0, temp.Count - 1);//using unity system.random
                toSpawn.Add(temp[index]);
                temp.RemoveAt(index);
            }
        }

        /// <summary>
        /// using a for loop instead of foreach so I can use the i variable to check the same position in both lists
        /// </summary>
        /// <param name="ingredientTypes"></param> used for keeping score to compare with orderedIngredients
        internal static void FinalTally(List<BurgerIngredients.ingredientType> ingredientTypes)
        {
            int finalScore=0;
            for (int i = 0;i < ingredientTypes.Count;i++)
            {
                if (ingredientTypes[i]== orderedIngredients[i])
                {
                    finalScore++;
                }
                else
                {
                    //finalScore--; maybe? not sure if we'll keep this yet
                }
            }
            //BAMicroGameScore(finalScore);
            //will be used for passing the score through to another script as needed
        }
    }
}
