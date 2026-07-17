var contacts = SampleContacts.Load();

var generator = new QrGenerator();

var card = generator.Create(
    contacts[0]
);

ConsoleView.Show(card);
