namespace Model
{
    public class Cell
    {
        public readonly Type type;
        private Cell(Type type)
        {
            this.type = type;
        }
        public enum Type
        {
            Empty, Water
        }

        public static Cell CreateEmpty() => new Cell(Type.Empty);
    }
}