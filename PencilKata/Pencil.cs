namespace PencilKata
{
    public class Pencil
    {
        public string Written { get; set; }
        public int Durability { get; set; }
        public int PointDurability { get; set; }
        public int EraserDurability { get; set; }

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
        public Pencil(int durability, int point, int eraser)
        {
            Durability = durability;
            PointDurability = point;
            EraserDurability = eraser;
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
            int index = Written.LastIndexOf(erased);
            string replacementString = "";

            if (EraserDurability >= erased.Length)
            {
                replacementString = replacementString.PadRight(erased.Length);
                Written = Written.Remove(index, erased.Length).Insert(index, replacementString);
                EraserDurability -= erased.Length;
            }
            else
            {
                string erasedNew = erased.Substring(0, erased.Length - EraserDurability);
                replacementString = erasedNew + replacementString.PadRight(EraserDurability);
                Written = Written.Remove(index, erased.Length).Insert(index, replacementString);
                EraserDurability = 0;
            }
        }

        public void Edit(string erased, string replacement)
        {
            int index = Written.LastIndexOf(erased);
            Erase(erased);
            Written = Written.Remove(index, erased.Length).Insert(index, replacement);
        }
    }
}
