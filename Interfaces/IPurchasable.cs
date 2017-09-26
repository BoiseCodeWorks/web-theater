namespace web_theater
{
    public interface IPurchasable
    {
        float Cost { get; set; }
        int Inventory { get; set; }

        bool Purchase(int quantity);

    }
}