namespace AndriiKutenWithChatGPT
{
    public class Name
    {
        public string Common { get; set; } = string.Empty;
    }

    public class Country
    {
        public Name Name { get; set; } = new Name();

        public double Population { get; set; }
    }
}
