public class Contact
{
    public string Name { get; set; }

    public string Company { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public Contact(
        string name,
        string company,
        string phone,
        string email)
    {
        Name = name;
        Company = company;
        Phone = phone;
        Email = email;
    }
}
