using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SoftServe_IT_Academy.Practice._IEnumerable__IEnumerator_interfaces
{
    public class CircleOfChildren
    {
        private readonly IEnumerable<string> children;

        public CircleOfChildren(IEnumerable<string> child)
        {
            this.children = child;
        }

        public IEnumerable GetChildrenInOrder(int syllablesCount, int countOfChildren = default)
        {
            if (syllablesCount <= 0)
            {
                yield break;
            }
            else
            {
                Queue<string> circle = new Queue<string>(children);

                while (circle.Count != 0)
                {
                    var moveChild = syllablesCount - 1;

                    while (moveChild > 0)
                    {
                        circle.Enqueue(circle.Dequeue());
                        moveChild--;
                    }

                    yield return circle.Dequeue();
                }
            }
        }
    }

    public class OutputUtils
    {
        public static void ExitOutput(CircleOfChildren circleOfChildren, int syllablesCount, int countOfChildren = default)
        {
            foreach (var item in circleOfChildren.GetChildrenInOrder(syllablesCount, countOfChildren))
            {
                Console.Write(item + " ");
            }
        }
    }
}
