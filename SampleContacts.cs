using System.Collections.Generic;

public static class SampleContacts
{
    public static List<Contact> Load()
    {
        return new List<Contact>
        {
            new Contact(
                "Emily Carter",
                "Bright Studio",
                "+1 555 2222",
                "emily@example.com"
            ),

            new Contact(
                "Daniel Brown",
                "North Labs",
                "+1 555 8181",
                "daniel@example.com"
            )
        };
    }
}
