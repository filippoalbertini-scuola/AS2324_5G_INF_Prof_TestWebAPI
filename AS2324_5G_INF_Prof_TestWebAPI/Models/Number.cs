namespace AS2324_5G_INF_Prof_TestWebAPI.Models
{
    public class Number
    {
        public int Value { get; set; }

        public bool Odd => (Value % 2==0);
        public bool Positive => (Value >= 0);
    }
}
