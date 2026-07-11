namespace IT_ELECTIVE_2_PRELIM_EXAM.Models;

public class Meal
{
    private string _name;
    private string _category;
    private string _area;
    private string _instructions;
    private string _thumbnail;
    private string _tags;
    // ADD THIS PROPERTY
    private int _prepTimeMinutes;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Category
    {
        get => _category;
        set => _category = value;
    }

    public string Area
    {
        get => _area;
        set => _area = value;
    }

    public string Instructions
    {
        get => _instructions;
        set => _instructions = value;
    }

    public string Thumbnail
    {
        get => _thumbnail;
        set => _thumbnail = value;
    }

    public string Tags
    {
        get => _tags;
        set => _tags = value;
    }

    // ADD THIS PROPERTY
    public int PrepTimeMinutes
    {
        get => _prepTimeMinutes;
        set => _prepTimeMinutes = value;
    }

    public Meal()
    {
        _name = "";
        _category = "";
        _area = "";
        _instructions = "";
        _thumbnail = "";
        _tags = "";
        // Initialize new property
        _prepTimeMinutes = 0;
    }

    public Meal(string name, string category, string area)
    {
        _name = name;
        _category = category;
        _area = area;
        _instructions = "";
        _thumbnail = "";
        _tags = "";
        _prepTimeMinutes = 0;
    }

    public override string ToString()
    {
        return $"Meal: {Name} | Category: {Category} | Area: {Area}";
    }
}