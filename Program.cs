string[] guestList = ["Rebecca", "Nadia", "Noor", "Jonte"];
string[] rsvp = new string[10];
int count = 0;

//void RSVP(string name, int partySize, string allergies, bool inviteOnly)
void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)  // Declare optional parameters
{
    if (inviteOnly)
    {
        // search guestList before adding rsvp
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;  // Prevent adding uninvited guests
        }
    }

    rsvp[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvp[i]);
    }
}


// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);  // "Linh" had inviteOnly = false, so he skipped the guest list check entirely and got added.
// RSVP("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);  // Use named arguments
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

/*
Sorry, Tony is not on the guest list

Total RSVPs:
Name: Rebecca,  Party Size: 1,  Allergies: none
Name: Nadia,    Party Size: 2,  Allergies: Nuts
Name: Linh,     Party Size: 2,  Allergies: none
Name: Noor,     Party Size: 4,  Allergies: none
Name: Jonte,    Party Size: 2,  Allergies: Stone fruit
*/