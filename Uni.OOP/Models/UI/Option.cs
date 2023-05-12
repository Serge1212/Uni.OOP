namespace Uni.OOP.Models.UI
{
    /// <summary>
    /// Represents the menu option information that a user selected.
    /// </summary>
    public class Option
    {
        public Option(string title, Action handler)
        {
            Title = title;
            Handler = handler;
        }

        /// <summary>
        /// The option's title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The handler that performs something for this option.
        /// </summary>
        public Action Handler { get; set; }
        
    }
}
