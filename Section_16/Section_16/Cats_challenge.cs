using System;
using System.Linq;


namespace Section_16
{
    public class Cats_challenge
    {
        public static int NotHungryCats(string kitchen)
        {
            var cats = kitchen.Replace(" ", "").Split('F');

            var leftCats = cats[0].Where((x, i) => i % 2 == 1).Count(x => x == '~');
            var rightCats = cats[1].Where((x, i) => i % 2 == 0).Count(x => x == '~');

            return leftCats + rightCats;
        }
    }
}