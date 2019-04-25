namespace PencilKata
{
    public class Pencil
    {
        public string Written { get; set; }
        public int Durability { get; set; }
        public int PointDurability { get; set; }

        public Pencil()
        {

        }
        public Pencil(int durability)
        {
            Durability = durability;
        }
        public Pencil(int durability, int point)
        {
            Durability = durability;
            PointDurability = point;
        }

        public string Write(string input)
        {
            foreach (char c in input)
            {
                if (PointDurability > 0)
                {
                    if (char.IsUpper(c))
                    {
                        Durability -= 2;
                        PointDurability -= 2;
                    }
                    else if(char.IsLower(c))
                    {
                        Durability -= 1;
                        PointDurability -= 1;
                    }

                    Written += c;
                }
                else
                {
                    Written += " ";
                }
            }

            return Written;
        }

        public void Sharpen(int point)
        {
            if (Durability < point)
            {
                PointDurability = Durability;
            }
            else
            {
                PointDurability = point;
            }
        }

        public void Erase(string erased)
        {
            //Written = "How much wood would a woodchuck chuck if a woodchuck could       wood?";
            int index = Written.LastIndexOf(erased);
            string emptySpace = "";
            emptySpace = emptySpace.PadRight(erased.Length);
            Written = Written.Remove(index, erased.Length).Insert(index, emptySpace);
        }
    }
}
