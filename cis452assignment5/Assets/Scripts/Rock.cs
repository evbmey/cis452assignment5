
public class Rock : RPS
{
    public override bool LivesOnShoot(RPS other)
    {
        if (other is Paper) return false;
        else return true;
    }
}
