public static class VCardBuilder
{
    public static string Build(Contact c)
    {
        return
$@"BEGIN:VCARD
FN:{c.Name}
ORG:{c.Company}
TEL:{c.Phone}
EMAIL:{c.Email}
END:VCARD";
    }
}
