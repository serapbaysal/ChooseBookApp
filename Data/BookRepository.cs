
using System.Collections.Generic;
using System.Linq;
using ChooseBookApp.Models;


namespace ChooseBookApp.Data
{
    public static class BookRepository
    {
        private static List<Book> _books = null;

        static BookRepository() {
            _books = new List<Book>() {
                new Book() {
                    Id = 0,
                    Name = "It",
                    Author = "Stephen King",
                    ShortDescription="It is a 1986 horror novel by American author Stephen King.",
                    Description = "It is a 1986 horror novel by American author Stephen King. It was his 22nd book and his 17th novel written under his own name. The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself while hunting its prey. ",
                    Pages = 1138,
                    ImageUrl = "1.jpg",
                    CategoryId = 1

                },
                new Book() {
                    Id = 1,
                    Name = "The Stand",
                    Author = "Stephen King",
                    ShortDescription = "The Stand is a post-apocalyptic dark fantasy novel written by American author Stephen King.",
                    Description = "The Stand is a post-apocalyptic dark fantasy novel written by American author Stephen King and first published in 1978 by Doubleday. The plot centers on a deadly pandemic of weaponized influenza and its aftermath, in which the few surviving humans gather into factions that are each led by a personification of either good or evil. King started writing the story in February 1975",
                    Pages = 823,
                    ImageUrl = "2.jpg",
                    CategoryId = 1

                },

                new Book() {
                    Id = 2,
                    Name = "Pet Sematary",
                    Author = "Stephen King",
                    ShortDescription = "Pet Sematary is a 1983 horror novel by American writer Stephen King.",
                    Description = "Pet Sematary is a 1983 horror novel by American writer Stephen King. The novel was nominated for a World Fantasy Award for Best Novel in 1986,[1] and adapted into two films: one in 1989 and another in 2019. In November 2013, PS Publishing released Pet Sematary in a limited 30th-anniversary edition.[2]",
                    Pages = 373,
                    ImageUrl = "3.jpg",
                    CategoryId = 1

                },

                new Book() {
                    Id = 3,
                    Name = "Salem's Lot",
                    Author = "Stephen King",
                    ShortDescription = "'Salem's Lot is a 1975 horror novel by American author Stephen King.",
                    Description = "'Salem's Lot is a 1975 horror novel by American author Stephen King. It was his second published novel. The story involves a writer named Ben Mears who returns to the town of Jerusalem's Lot (or 'Salem's Lot for short) in Maine, where he lived from the age of five through nine, only to discover that the residents are becoming vampires. ",
                    Pages = 439,
                    ImageUrl = "4.jpg",
                    CategoryId = 1

                }

            };
        }

        public static List<Book> Books {
            get {
                return _books;
            }
        }
        

        public static void AddBook(Book entity){
            _books.Add(entity);
        }

        public static Book GetById(int id){
            return _books.FirstOrDefault(i => i.Id == id);
        }
    }
}