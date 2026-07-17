public class BusinessCard
{
    public Contact Contact { get; }

    public string Payload { get; }

    public BusinessCard(
        Contact contact,
        string payload)
    {
        Contact = contact;
        Payload = payload;
    }
}
