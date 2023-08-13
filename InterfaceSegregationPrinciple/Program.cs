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
    public class AllyUnit : IDamageable, IDamageDealer, ITurnable
    {

    }

    public class Obstacle : IDamageable, IDamageDealer
    {

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

    }
    public class AllyUnit : IUnitAbilities
    {

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
