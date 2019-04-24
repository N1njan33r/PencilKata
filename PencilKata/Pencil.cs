namespace PencilKata
{
    public class Pencil
    {
        public string Written { get; set; }
        public int Durability { get; set; }

        public Pencil() { }
        public Pencil(int durability)
        {
            Durability = durability;
        }

        public string Write(string input)
        {
            if (Written == null)
            {
                Written = input;
            }
            else
            {
                Written += " " + input;
            }

            return Written;
        }
    }
}
