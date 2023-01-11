using DomainLayer.Entities;
using ServiceLayer.Helpers;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11._01._2023Console_app_Practice_.Controllers
{
    public class LibraryContreller
    {
        private readonly ILibrarySevice _libraryService;

        public LibraryContreller()
        {
            _libraryService = new LibraryService();
        }

        public void Create()
        {
            ConsoleColor.DarkCyan.WriteConsole("Please add library name:");
            LibraryName: string libraryName = Console.ReadLine();

            ConsoleColor.DarkCyan.WriteConsole("Please add library seat count");
            SeatCount: string seatCountStr = Console.ReadLine();

            int seatCount;

            bool isCorrectSeatCount = int.TryParse(seatCountStr, out seatCount);

            if (isCorrectSeatCount)
            {
                try
                {

                    Library library = new Library
                    {
                        Name = libraryName,
                        SeatCount = seatCount
                    };

                    var response = _libraryService.Create(library);

                    ConsoleColor.Green.WriteConsole($"{response.Id} {response.Name} {response.SeatCount}");
                }
                catch (Exception ex)
                {

                    ConsoleColor.Red.WriteConsole(ex.Message + "/" + "Please try again");
                    goto LibraryName;
                }


            }
            else
            {
                ConsoleColor.Red.WriteConsole("Please add correct format seat count");
                goto SeatCount;
            }

        }
    }
}
