﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;


namespace Salt.DialogueSystem.Editor
{
    [Serializable]
    public class ChoiceNode : CustomNode
    {
        public int choiceCount = 0;
        public Dictionary<int, string> QuestionDict = new Dictionary<int, string>();
    }

}
