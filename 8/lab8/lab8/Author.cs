﻿using System;


namespace Lab8
{
    public class Author : Person
    {
        public Author() { }
        public Author(string _name, string _surname, int _countPublications)
        {
            Name = _name;
            Surname = _surname;
            CountPublications = _countPublications;
        }

        public override float WritingExperience(int year, int yearOfWriting) => (float)yearOfWriting / year;

        public override string CreateAlias() => Name.ToUpper() + Surname.Substring(0, 2);

        public override string ToString() => $"Тип объекта: {GetType()}, фамилия и имя автора - {Surname} {Name}, количество книг - {CountPublications}";

        public override int GetHashCode() => base.GetHashCode();

        public override bool Equals(object obj) => base.Equals(obj);
    }
}