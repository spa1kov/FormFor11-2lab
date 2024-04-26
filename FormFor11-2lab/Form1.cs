using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NoteRecordApp
{
    public partial class Form1 : Form
    {
        private List<Note> noteList = new List<Note>();

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateDataButton_Click(object sender, EventArgs e)
        {
            noteList = GenerateNotes(10);
            WriteToFile(noteList);
            MessageBox.Show("Данные успешно сгенерированы и записаны в файл.");
        }

        private void ReadDataButton_Click(object sender, EventArgs e)
        {
            noteList = ReadFromFile();
            DisplayData(noteList);
        }

        private void DisplayBirthdaysButton_Click(object sender, EventArgs e)
        {
            string monthString = MonthTextBox.Text.Trim();
            int month;
            if (int.TryParse(monthString, out month))
            {
                List<Note> birthdayNotes = noteList.FindAll(note => note.BirthDate.Month == month);
                if (birthdayNotes.Count > 0)
                {
                    DisplayData(birthdayNotes);
                }
                else
                {
                    MessageBox.Show("Нет записей с днями рождения в указанном месяце.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректный номер месяца.");
            }
        }

        private List<Note> GenerateNotes(int count)
        {
            List<Note> generatedNotes = new List<Note>();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                string fullName = "Фамилия" + i + " Имя" + i;
                string phoneNumber = "123456789" + i;
                DateTime birthDate = new DateTime(2000 + i, random.Next(1, 13), random.Next(1, 29));
                generatedNotes.Add(new Note(fullName, phoneNumber, birthDate));
            }
            return generatedNotes;
        }

        private void WriteToFile(List<Note> notesToWrite)
        {
            using (StreamWriter writer = new StreamWriter("notes.txt"))
            {
                foreach (Note note in notesToWrite)
                {
                    writer.WriteLine(note.ToString());
                }
            }
        }

        private List<Note> ReadFromFile()
        {
            List<Note> readNotes = new List<Note>();
            using (StreamReader reader = new StreamReader("notes.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    string fullName = parts[0];
                    string phoneNumber = parts[1];
                    DateTime birthDate = DateTime.Parse(parts[2]);
                    readNotes.Add(new Note(fullName, phoneNumber, birthDate));
                }
            }
            return readNotes;
        }

        private void DisplayData(List<Note> notesToDisplay)
        {
            DisplayTextBox.Clear();
            foreach (Note note in notesToDisplay)
            {
                DisplayTextBox.AppendText(note.ToString() + Environment.NewLine);
            }
        }
    }

    public class Note
    {
        public string FullName { get; }
        public string PhoneNumber { get; }
        public DateTime BirthDate { get; }

        public Note(string fullName, string phoneNumber, DateTime birthDate)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{FullName}; {PhoneNumber}; {BirthDate.ToShortDateString()}";
        }
    }
}