namespace Model
{
    public class World
    {
        private World(Level.Level level)
        {
            
        }

        public void Advance(ref WorldState stateAfter)
        {
        
        }

        public static World Create(Level.Level level)
        {
            return new World(level);
        }
    }
}
