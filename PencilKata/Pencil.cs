namespace PencilKata
{
    public class Pencil
    {
        public string Written { get; set; }
        public int Durability { get; set; }
        public int PointDurability { get; set; }

        public Pencil() { }
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

                if (PointDurability >= 0)
                {
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
            PointDurability = point;
        }
    }
}
