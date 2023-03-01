﻿using System;
using System.Runtime.CompilerServices;
namespace var20
{
    public class Material
    {
        private readonly string? name; // Имя
        public string? Name { get => name; }

        private readonly string? creator; // Автор

        public string? Creator { get => creator; }

        public static DateTime Now { get; } // Дата
        private DateTime? date;
        public DateTime? Date { get => date; }
        Material(string? name, string? creator, DateTime? date)
        {
            this.name = name;
            this.creator = creator;
            this.date = date ?? DateTime.Today;
        }
    }

}