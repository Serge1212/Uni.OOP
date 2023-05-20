using Uni.OOP.Interfaces;
using Uni.OOP.Models.UI;

namespace Uni.OOP.UI
{
    /// <summary>
    /// The dedicated handler for working with main menu.
    /// </summary>
    public class MenuHandler : IMenuHandler
    {
        /// <summary>
        /// The default index of the menu options.
        /// </summary>
        const int DEFAULT_INDEX = 0;

        int _currentIndex;

        readonly IFeatureService _featureService;
        readonly ICarService _carService;
        public MenuHandler(
            IFeatureService featureService,
            ICarService carService)
        {
            _featureService = featureService;
            _carService = carService;
        }

        /// <inheritdoc />
        public void DisplayMenu()
        {
            
            var options = new List<Option>
            {
                new Option("Show Cars", async () => await _carService.ShowAllAsync()),
                new Option("Add Car", async () => await _carService.AddAsync()),
                new Option("Show Car Features", async () => await _featureService.ShowAllAsync()),
                new Option("Add Car Feature", async () => await _featureService.AddAsync()),
                new Option("Exit", () => Environment.Exit(0)),
            };

            _currentIndex = DEFAULT_INDEX;

            RenderMenu(options, options[_currentIndex]);

            ListenMenu(options);
        }

        static void RenderMenu(List<Option> options, Option selected)
        {
            // Each render will go fresh in console.
            Console.Clear();

            foreach (Option option in options)
            {
                if (option == selected)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.WriteLine(option.Title);
            }
        }

        void ListenMenu(List<Option> options)
        {
            // Actual selected key.
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                // Handle each key input (down arrow will write the menu again with a different selected item)
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (_currentIndex + 1 < options.Count)
                    {
                        _currentIndex++;
                        RenderMenu(options, options[_currentIndex]);
                    }
                }
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (_currentIndex - 1 >= 0)
                    {
                        _currentIndex--;
                        RenderMenu(options, options[_currentIndex]);
                    }
                }
                // Handle Select action for the option.
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    options[_currentIndex].Handler.Invoke();
                    _currentIndex = 0;
                }
            }
            while (keyinfo.Key != ConsoleKey.Escape); // Exit on Escape button.

            Console.ReadKey();
        }
    }
}
