namespace PencilKata
{
    public class Pencil
    {
        public string Written { get; set; }

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
