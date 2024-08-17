public class InventoryItem {
    public InventoryItem() {
        
    }
    public string Name { get; set; } = "Default Name";
    public string Description { get; set; } = "";
    public string Category { get; set; } = "Default";
    public string ImageURL { get; set; } = "https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=facearea&facepad=2&w=256&h=256&q=80";
    public bool Status { get; set; } = false;
    public int Quantity { get; set; } = 0;
}