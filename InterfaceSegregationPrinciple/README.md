# Interface Segregation Principle

The Interface Segregation Principle (ISP) states that clients should not be forced to depend on interfaces they do not use. In other words, a class should not be required to implement methods it does not need. Instead of one large interface, smaller and more specific interfaces should be preferred, allowing clients to implement only the methods relevant to their needs.

## Applying Interface Segregation Principle

Consider the example of units in a Tower Defense game. In a well-designed implementation, distinct interfaces (`IMovable`, `ITurnable`, `IDamageable`, `IDamageDealer`, `IBuyable`) are defined to capture specific abilities and characteristics of the units. Each unit class then implements only the relevant interfaces, ensuring that it does not have to provide unnecessary methods.

## Bad Design

In the bad design, a single large interface `IUnitAbilities` includes all abilities regardless of the unit type, violating the Interface Segregation Principle. This forces classes to implement methods they don't need, leading to unnecessary coupling.

 ```C#
public class EnemyUnit : IUnitAbilities
{
    // No need for Price, RefundFee on the EnemyUnit
}

public class AllyUnit : IUnitAbilities
{
    // No need for MoveSpeed, Acceleration, TopSpeed, GoForward(), GoBackward() on the AllyUnit
}

public class ObstacleUnit : IUnitAbilities
{
    // No need for TurnSpeed, TurnLeft(), TurnRight(), MoveSpeed, Acceleration, 
    // TopSpeed, GoForward(), GoBackward() on the ObstacleUnit
}

public interface IUnitAbilities
{
    float MoveSpeed { get; set; }
    float Acceleration { get; set; }
    float TopSpeed { get; set; }
    float TurnSpeed { get; set; }
    float HitPoints { get; set; }
    int Defense { get; set; }
    float Damage { get; set; }
    int AttackRatio { get; set; }

    void GoForward();
    void GoBackward();
    void TurnLeft();
    void TurnRight();
    void Die();
    void TakeDamage();
    void Attack();
}

 ```

## Good Design

 ```C#
public class EnemyUnit : IMovable, IDamageable, IDamageDealer, ITurnable
{
    // Implementation of relevant methods
}

public class AllyUnit : IDamageable, IDamageDealer, ITurnable, IBuyable
{
    // Implementation of relevant methods
}

public class ObstacleUnit : IDamageable, IDamageDealer, IBuyable
{
    // Implementation of relevant methods
}

public interface IBuyable
{
    float Price { get; set; }
    float RefundFee { get; set; }
}

public interface IMovable
{
    float MoveSpeed { get; set; }
    float Acceleration { get; set; }
    float TopSpeed { get; set; }
    void GoForward();
    void GoBackward();
}

public interface ITurnable
{
    float TurnSpeed { get; set; }
    void TurnLeft();
    void TurnRight();
}

public interface IDamageable
{
    float HitPoints { get; set; }
    int Defense { get; set; }
    void Die();
    void TakeDamage();
}

public interface IDamageDealer
{
    float Damage { get; set; }
    int AttackRatio { get; set; }
    void Attack();
}
 ```

## Conclusion

By adhering to the Interface Segregation Principle, as demonstrated in the good design example, interfaces are segregated based on specific roles and functionalities, leading to more cohesive and maintainable code.

