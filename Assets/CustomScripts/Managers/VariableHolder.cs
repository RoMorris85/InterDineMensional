using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.Manager
{
    public class VariableHolder : MonoBehaviour
    {
        //these will track the stats for each character 
        /*public int moved to globals.ink
            day,
            affectionCS, chaosCS, irritatedCS,//Cheff Swats trackers
            affectionN, chaosN, irritatedN,//Nico trackers
            affectionCC, chaosCC, irritatedCC,//CeCe trackers
            affectionG, chaosG, irritatedG,//Gnomies
            affectionM, chaosM, irritatedM,//Morgan trackers
            affectionF, chaosF, irritatedF,//Fred trackers
            finalEncounterTracker;//used to keep track of wins and losses in the final encounter with */
        public bool characterStateNico;
        private static VariableHolder instance;
        // Start is called before the first frame update
        void Awake()
        {
            if (instance != null)
            {
                Destroy(this.gameObject);
                Debug.LogWarning("Found more then one DialogueManager instance");
            }
            instance = this;
            DontDestroyOnLoad(instance);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}