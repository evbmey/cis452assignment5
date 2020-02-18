
public class Scissors : RPS
{
    public override bool LivesOnShoot(RPS other)
    {
        if (other is Scissors) return false;
        else return true;
    }
}
