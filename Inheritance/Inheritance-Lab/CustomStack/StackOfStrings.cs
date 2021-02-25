﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;

        }

        public void AddRange(IEnumerable<string> strings)
        {
            foreach (var item in strings)
            {
                this.Push(item);
            }
        }
    }
}
