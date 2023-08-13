namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // Tower Defense Game Sample Units

    // Good Design

    public class EnemyUnit : IMovable, IDamageable, IDamageDealer, ITurnable
    {

    }
    public class AllyUnit : IDamageable, IDamageDealer, ITurnable, IBuyable
    {

    }

    public class ObstacleUnit : IDamageable, IDamageDealer, IBuyable
    {

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



    //Bad Design

    /*
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
    */
}
