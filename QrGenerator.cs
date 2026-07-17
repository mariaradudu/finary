public class QrGenerator
{
    public BusinessCard Create(Contact contact)
    {
        var payload = VCardBuilder.Build(contact);

        return new BusinessCard(
            contact,
            payload
        );
    }
}
