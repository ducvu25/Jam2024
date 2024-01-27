public enum MAP_GAME
{
    loading,
    menu,
    lv1,
    lv2,
    lv3
}
public static class DataGame
{
    static string[] name_Map = { "Load", "Menu", "Lv1", "Lv2", "Lv3" };

    public static string GetNameScene(MAP_GAME map)
    {
        return name_Map[(int)map];  
    }
}
