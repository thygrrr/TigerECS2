namespace xTests;

using ECS;
public class UnitTest1
{
    [Fact]
    public void World_Creates()
    {
        var world = new World();
        Assert.NotNull(world);
    }
   
}