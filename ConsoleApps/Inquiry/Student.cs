using System;

namespace Inquiry
{
    public class Student
    {
        private readonly string _firstName,
            _surname,
            _lastName,
            _dateOfBirth,
            _placeOfBirth,
            _school,
            _className;

        private readonly int _studentId;

        private Student(string firstName, string surname, string lastName, string dateOfBirth, string placeOfBirth,
            string school, string className, int studentId)
        {
            _firstName = firstName;
            _surname = surname;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _placeOfBirth = placeOfBirth;
            _school = school;
            _className = className;
            _studentId = studentId;
        }

        public void Print()
        {
            Console.WriteLine($@"Student {_firstName} {_surname} {_lastName}:");
            Console.WriteLine($@"Birth: ${_dateOfBirth} in {_placeOfBirth}.");
            Console.WriteLine($@"School: ${_school}; No {_studentId} in ${_className} class.");
        }

        public static class StudentBuilder
        {
            public static Student FromStdin()
            {
                InputUtil.ReadString("First name", out var firstName);
                InputUtil.ReadString("Surname", out var surname);
                InputUtil.ReadString("Last name", out var lastName);
                InputUtil.ReadString("Date of birth", out var dateOfBirth);
                InputUtil.ReadString("Place of birth", out var placeOfBirth);
                InputUtil.ReadString("School", out var school);
                InputUtil.ReadString("Class", out var schoolClass);
                InputUtil.ReadInt("No in class", out var studentId);

                return new Student(firstName, surname, lastName, dateOfBirth, placeOfBirth, school, schoolClass, studentId);
            }
        }
    }
}