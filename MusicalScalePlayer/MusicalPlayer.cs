namespace MusicalScalePlayer
{
    internal class MusicPlayer
    {

        private readonly Dictionary<string, double> _musicalNotes = new Dictionary<string, double>
            {
                { "C", 261.63 },
                { "C#", 277.18 },
                { "D", 293.66 },
                { "D#", 311.13 },
                { "E", 329.63 },
                { "F", 349.23 },
                { "F#", 369.99 },
                { "G", 392.00 },
                { "G#", 415.30 },
                { "A", 440.00 },
                { "A#", 466.16 },
                { "B", 493.88 }
            };

        private readonly List<(string Note, int Duration)> _notes = [("A", 100), ("A#", 300), ("C", 500), ("C#", 100), ("D", 300), ("D#", 250), ("E", 100), ("F", 300), ("G", 120), ("G#", 225)];

        public void PlayAllNotes()
        {

            foreach (var pair in _musicalNotes)
            {
                Console.Beep((int)pair.Value, 500);
            }
        }

        public void PlayAvailableNote(List<(string Note, int Duration)>? notes = null)
        {
            if (notes == null)
            {
                notes = _notes;
            }

            foreach (var pair in notes)
            {
                try
                {
                    int frequency = (int)_musicalNotes[pair.Note];
                    Console.Beep(frequency, pair.Duration);
                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void GetInput()
        {
            int length;
            Console.Write("Enter the length of the notes: ");
            while (!int.TryParse(Console.ReadLine(), out length))
            {

            }

            Console.WriteLine("Enter the note the not one by one");
            List<(string Note, int Duration)> notes = new List<(string Note, int Duration)>();

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter the note: ");
                string note = Console.ReadLine() ?? string.Empty;


                Console.Write("Enter the duration: ");
                int duration;
                while (!int.TryParse(Console.ReadLine(), out duration))
                {

                }

                notes.Add((note, duration));
            }

            this.PlayAvailableNote(notes);
        }
    }
}