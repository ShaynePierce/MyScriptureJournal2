using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                Random rand = new Random();

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = 3,
                        Verse = 7,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Quickly I'll obey!"
                    },

                    new Scripture
                    {
                        Book = "Mosiah",
                        Chapter = 3,
                        Verse = 19,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Yield to the Spirit. The natural man is not good."
                    },

                    new Scripture
                    {
                        Book = "D&C",
                        Chapter = 89,
                        Verse = 1,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Law of health."
                    },
 
                    new Scripture
                    {
                        Book = "Helaman",
                        Chapter = 5,
                        Verse = 12,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Foundation of Christ"
                    },
                    
                    new Scripture
                    {
                        Book = "D&C",
                        Chapter = 4,
                        Verse = 1,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "A Marvelous Work"
                    },

                    new Scripture
                    {
                        Book = "John",
                        Chapter = 3,
                        Verse = 16,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "God loves us"
                    },

                    new Scripture
                    {
                        Book = "D&C",
                        Chapter = 1,
                        Verse = 1,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Hearken"
                    },

                    new Scripture
                    {
                        Book = "Hebrews",
                        Chapter = 5,
                        Verse = 4,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "No man taketh this honor."
                    },

                    new Scripture
                    {
                        Book = "1 John",
                        Chapter = 5,
                        Verse = 3,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Keeping commandments shows our love."
                    },

                    new Scripture
                    {
                        Book = "Mosiah",
                        Chapter = 29,
                        Verse = 26,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Most people will choose the right."
                    },

                    new Scripture
                    {
                        Book = "Alma",
                        Chapter = 5,
                        Verse = 14,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Image of God in your countenance?"
                    },

                    new Scripture
                    {
                        Book = "Helaman",
                        Chapter = 12,
                        Verse = 3,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Chastening needed to remember God."
                    },

                    new Scripture
                    {
                        Book = "4 Nephi",
                        Chapter = 1,
                        Verse = 3,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "All things in common."
                    },

                    new Scripture
                    {
                        Book = "D&C",
                        Chapter = 45,
                        Verse = 3,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Our advocate with the Father."
                    },

                    new Scripture
                    {
                        Book = "D&C",
                        Chapter = 59,
                        Verse = 21,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Be grateful!"
                    },

                    new Scripture
                    {
                        Book = "D&C",
                        Chapter = 84,
                        Verse = 20,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Power of godliness is in the ordinances."
                    },

                    new Scripture
                    {
                        Book = "1 Kings",
                        Chapter = 17,
                        Verse = 8,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Elijah and the miracle of the barrel of meal and cruse of oil."
                    },

                    new Scripture
                    {
                        Book = "Amos",
                        Chapter = 3,
                        Verse = 7,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "Prophets will know what the Lord has planned."
                    },

                    new Scripture
                    {
                        Book = "Moses",
                        Chapter = 1,
                        Verse = 39,
                        EntryDate = DateTime.Now.AddDays(-rand.Next(1, 100)),
                        Thoughts = "God loves work!"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
