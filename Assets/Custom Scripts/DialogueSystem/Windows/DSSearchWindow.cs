using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace DS.Windows
{
    using Enumeration;
    using Elements;
    using Windows;
    public class DSSearchWindow : ScriptableObject, ISearchWindowProvider
    {
        private Texture2D indentationIcon;
        private DSGraphView graphView;
        public void initialize(DSGraphView dSGraphView)
        {
            graphView=dSGraphView;

            indentationIcon = new Texture2D(1, 1);
            indentationIcon.SetPixel(0, 0, Color.clear);
            indentationIcon.Apply();
        }
        public List<SearchTreeEntry> CreateSearchTree(SearchWindowContext context)
        {
            List<SearchTreeEntry> searchTreeEntries = new List<SearchTreeEntry>()
            {
                new SearchTreeGroupEntry(new GUIContent("Create Element")),
                new SearchTreeGroupEntry(new GUIContent("Dialogue Node"),1),
                new SearchTreeEntry(new GUIContent("Single Choice", indentationIcon))
                {
                    level=2,
                    userData=DSDialogueType.SingleChoice
                },
                 new SearchTreeEntry(new GUIContent("Multiple Choice", indentationIcon))
                {
                    level=2,
                    userData=DSDialogueType.MultipleChoice
                },
                 new SearchTreeGroupEntry(new GUIContent("Dialogue Group"),1),
                 new SearchTreeEntry(new GUIContent("Single Group", indentationIcon))
                 {
                     level =2,
                     userData=new Group()
                 },
            };

            return searchTreeEntries;
        }

        public bool OnSelectEntry(SearchTreeEntry SearchTreeEntry, SearchWindowContext context)
        {
            Vector2 localMousePosition = graphView.GetLocalMousePosition(context.screenMousePosition, true);
            switch (SearchTreeEntry.userData)
            {
                case DSDialogueType.SingleChoice:
                    DSSingleChoice singleChoiceNode = (DSSingleChoice)graphView.createNodeActivator(DSDialogueType.SingleChoice, localMousePosition);
                    graphView.AddElement(singleChoiceNode);
                    return true;
                case DSDialogueType.MultipleChoice:
                    DSMultipleChoice multipleChoiceNode = (DSMultipleChoice)graphView.createNodeActivator(DSDialogueType.MultipleChoice, localMousePosition);
                    graphView.AddElement(multipleChoiceNode);
                    return true;
                case Group _:
                    graphView.CreateGroup("DialogueGroup", localMousePosition);

                    return true;
                default: return false;
            }

        }
    }
}
