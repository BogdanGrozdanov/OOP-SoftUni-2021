namespace _06.FoodShortage
{
    interface IBuyer
    {
        string Name { get; }
        string Age { get; }
        int Food { get; }
        int BuyFood();
    }
}
