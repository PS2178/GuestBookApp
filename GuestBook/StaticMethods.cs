using static System.Console;

namespace GuestBook
{
    public static class StaticMethods
    {
        public static List<string> guests = new();
        public static string hostName, numberOfGuests, guestName = "";

        public static string GetName()
        {
            Write("And what is the name for the party? ");
            hostName = ReadLine();

            return hostName;
        }

        public static int GetGuests()
        {
            Write("And for how many? ");
            numberOfGuests = ReadLine();

            return Convert.ToInt32(numberOfGuests);
        }

        public static void UpdateGuestBook()
        {
            for (int i = 0; i < Convert.ToInt32(numberOfGuests); i++)
            {
                Write("And what is the guest's name? ");
                guestName = ReadLine();

                guests.Add(guestName);
            }
        }

        public static void PrintGuestBook()
        {
            foreach (string guests in guests)
            {
                WriteLine(guests);
            }
        }
    }
}
