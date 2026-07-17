# QR Business Card Generator

Generate digital business cards and prepare them for QR code export.

This project converts contact information into a vCard payload,
creates a QR object and simulates exporting it as PNG and SVG.

---

## Pipeline

```
Contact
   │
   ▼
vCard Builder
   │
   ▼
 QR Generator
   │
   ▼
 PNG Export
 SVG Export
```

---

## Example

```
Generating Business Card...

Emily Carter
Bright Studio

PNG created
SVG created

Completed.
```

---

## Source Files

Program.cs — application entry

Contact.cs — contact information

BusinessCard.cs — generated card

VCardBuilder.cs — builds vCard payload

QrGenerator.cs — creates QR object

ExportManager.cs — export operations

ConsoleView.cs — output

SampleContacts.cs — demo contacts

Settings.cs — application settings

---

Run

```
dotnet run
```

Console project for .NET 8.
