﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Studio_Quizzes
{
    public class TrueFalse : Question
    {

        public TrueFalse(string questionText, List<string> possibleAnswers) : base(questionText, possibleAnswers)
        {
            //PossibleAnswers = possibleAnswers;
        }
    }
}
