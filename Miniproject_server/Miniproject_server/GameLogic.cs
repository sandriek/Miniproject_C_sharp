﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniproject_server
{
    class GameLogic
    {
        public GameLogic()
        {

        }

        //color colorOption amount shape => pf3s = purple filled 3 swiggle
        public Boolean CheckSet(string set1, string set2, string set3)
        {
            byte control = 0;
            for (byte stringIndex = 0; stringIndex <= set1.Length; stringIndex++)
            {
                if (set1[stringIndex] == set2[stringIndex])
                {
                    if (set1[stringIndex] == set3[stringIndex])
                    {
                        control += 1;
                    }
                }
                else if (set1[stringIndex] != set2[stringIndex])
                {
                    if (set1[stringIndex] != set3[stringIndex])
                    {
                        if (set2[stringIndex] != set3[stringIndex])
                        {
                            control += 1;
                        }
                    }
                }
            }
            if (control == 4)
                return true;
            else return false;
        }

        public List<string> CreateBoard()
        {


            return new List<string>();
        }
    }
}
