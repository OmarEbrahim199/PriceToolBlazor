
public class SearchService
{
    public bool SearchBar { get; set; } = true;

    // Define an event that will be raised when SearchBar changes
    public event Action SearchBarChanged;
    public void ToggleSearchBar()
    {
        SearchBar = !SearchBar;
        Console.WriteLine(SearchBar);
        // Raise the event to notify subscribers that SearchBar has changed
        SearchBarChanged?.Invoke();
    }


}

