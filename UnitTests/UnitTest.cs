using GameLab3;
using Xunit;

public class UnitTests
{
    [Fact]
    public void UnitTakesDamageTest()
    {
        var unit = new Unit("Warrior", 100, 20);
        unit.TakeDamage(20);
        Assert.Equal(80, unit.Health);
    }

    [Fact]
    public void UnitAttackTest()
    {
        var attacker = new Unit("Warrior", 100, 20);
        var defender = new Unit("Monster", 100, 10);
        attacker.AttackEnemy(defender);
        Assert.Equal(90, defender.Health);
    }
}
