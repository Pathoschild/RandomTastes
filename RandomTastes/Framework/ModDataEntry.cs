using System.Collections.Generic;

namespace RandomTastes.Framework
{
    public class ModDataEntry
    {
        public string id = "";
        public int[] love = { };
        public int[] like = { };
        public int[] neutral = { };
        public int[] dislike = { };
        public int[] hate = { };

        public ModDataEntry(string id, int[] love, int[] like, int[] neutral, int[] dislike, int[] hate)
        {
            this.id = id;
            this.love = love;
            this.like = like;
            this.neutral = neutral;
            this.dislike = dislike;
            this.hate = hate;
        }

        public ModDataEntry(string id, List<int> love, List<int> like, List<int> neutral, List<int> dislike, List<int> hate)
        {
            this.id = id;
            this.love = love.ToArray();
            this.like = like.ToArray();
            this.neutral = neutral.ToArray();
            this.dislike = dislike.ToArray();
            this.hate = hate.ToArray();
        }

        public ModDataEntry() { }
    }
}
